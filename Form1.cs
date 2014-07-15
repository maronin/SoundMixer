using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave.SampleProviders;
using NAudio;
using SoundWiz;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SoundWiz
{


    public partial class Form1 : Form
    {
        public static readonly Regex YoutubeVideoRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);
        private string fileName = null;
        private WaveStream fileWaveStreamDAC;
        private WaveStream fileWaveStreamDefault;
        public Action<float> setVolumeDelegateDAC;
        public Action<float> setVolumeDelegateDefault;
        private List<FileFormats> InputFileFormats;
        private WaveOut waveOutToMe, waveOutToSkype;
        private bool filePlaying = false;
        WebClient webClient;
        WebBrowser browser;
        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.WaveOut waveOut = null;
        MusicPlayer musicPlayer;
        public Form1()
        {
            InitializeComponent();

            //initialize supported file formats
            InputFileFormats = new List<FileFormats>();
            InputFileFormats.Add(new FileFormats("MP3", ".mp3"));
            InputFileFormats.Add(new FileFormats("WAV", ".wav"));
            InputFileFormats.Add(new FileFormats("AIFF", ".aiff"));



            //populate the combobox with current input devices (mic, digital cable, etc.)
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));

            }

            foreach (var source in sources)
            {
                cbInputDevices.Items.Add(source.ProductName);
            }
            cbInputDevices.SelectedIndexChanged += cbInputDevices_SelectedIndexChanged;

            //initialize browser youtube stuff here.
            webClient = new WebClient();
            browser = new WebBrowser();
            browser.Navigate("http://www.youtube-mp3.org/");
            browser.DocumentCompleted += browser_DocumentCompleted;
            browser.ScriptErrorsSuppressed = true;
            tbYoutubeAddURL.KeyUp += tbYoutubeAddURL_KeyUp;
            loadingIcon.Image = Image.FromFile(@"C:\Users\Mark\Documents\Visual Studio 2013\Projects\YouTube to MP3\images\loading.gif");


            musicPlayer = new MusicPlayer(this);
            volumeSlider.Volume = (float)0.254;
        }

        //overriding this method to prevent "ding" sound when pressing enter on a one line textbox
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || keyData == Keys.Enter)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbYoutubeAddURL_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                //set the youtube url to convert on the form
                browser.Document.GetElementById("youtube-url").SetAttribute("Value", tbYoutubeAddURL.Text);
                string link = null;

                do
                {
                    //click convert
                    browser.Document.GetElementById("submit").InvokeMember("Click");

                    loadingIcon.Visible = true;
                    lblErrorMessageYoutubeLInk.Text = "";
                    waitTillLoad();
                    //waitTillLoad();


                    //check to see if there are any error from converting
                    HtmlElement error = browser.Document.GetElementById("error_text");
                    if (error.Style == "DISPLAY: block")
                    {
                        lblErrorMessageYoutubeLInk.Text = error.InnerText;
                        //textBox2.Text = ""; replace with whats going to be reading the stream for mp3
                        loadingIcon.Visible = false;
                        break;
                    }

                    HtmlElement status = browser.Document.GetElementById("status_text");

                    if (status.InnerText.Contains("Video successfully converted to mp3"))
                    {
                        link = browser.Document.GetElementById("dl_link").InnerHtml;

                    }

                    /* old way of doing it, might work if the processing takes too long?
                    while(true){
                        HtmlElement status = browser.Document.GetElementById("status_text");
                        if (status.InnerText.Contains("Video successfully converted to mp3"))
                        {
                            link = browser.Document.GetElementById("dl_link").InnerHtml;
                            break;

                        }

                    }*/



                } while (link == null);


                if (link != null)
                {

                    //extract the youtube mp3 download link
                    string downloadUrl = ExtractFromString(link, "get?ab=", "\"");
                    //remove the last character " not sure how to make this better
                    downloadUrl = downloadUrl.Remove(downloadUrl.Length - 1);

                    //textBox2.Text = "http://www.youtube-mp3.org/" + downloadUrl; replace with whats going to be reading the stream for mp3

                    lblErrorMessageYoutubeLInk.Text = "";

                    Match youtubeMatch = YoutubeVideoRegex.Match(tbYoutubeAddURL.Text);
                    string youtubeID = string.Empty;

                    if (youtubeMatch.Success)
                        youtubeID = youtubeMatch.Groups[1].Value;

                    string y = webClient.DownloadString("http://gdata.youtube.com/feeds/api/videos/" + youtubeID + "?v=2&alt=json&prettyprint=true");

                    //string y = webClient.DownloadString("http://gdata.youtube.com/feeds/api/videos/" + youtubeID + "?v=2&alt=json");
                    JObject JObj = (JObject)JsonConvert.DeserializeObject(y);

                    YouTubeDataFeed youTubeDataFeed = JsonConvert.DeserializeObject<YouTubeDataFeed>(y);

                    //var entry = JObj["feed"]["entry"];
                    //var imgURL = entry["media$group"];
                    loadingIcon.Visible = false;
                    picYouTubePicture.ImageLocation = youTubeDataFeed.entry.mediagroup.mediathumbnail[3].url.ToString();
                    listYoutubeMP3s.Items.Add(tbYoutubeAddURL.Text);
                    tbYoutubeAddURL.Text = "";
                }
                else
                {
                    lblErrorMessageYoutubeLInk.ForeColor = Color.Red;

                }


            }


        }

        private static string ExtractFromString(string source, string start, string end)
        {
            string rc = "";

            var results = new List<string>();

            string pattern = string.Format(
                "{0}{1}{2}",
                Regex.Escape(start),
                ".+?",
                 Regex.Escape(end)
           );


            Match m = Regex.Match(source, pattern);
            rc = m.Value;



            return rc;

        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        void cbInputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveOutToSkype != null)
                waveOutToSkype.Stop();
            if (waveOutToMe != null)
                waveOutToMe.Stop();

            System.Threading.Thread.Sleep(300);//to prevent looping of sound when switching to the virtual audio cable

            int deviceNumber = cbInputDevices.SelectedIndex;

            //get the selected input device
            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            //set the input waveIn to the input device selected
            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            //waveOut = new NAudio.Wave.DirectSoundOut();

            //waveOut = Where the mic output will go
            waveOut = new NAudio.Wave.WaveOut();
            waveOut.DeviceNumber = 3;//digital audio cable
            waveOut.DesiredLatency = 150;
            waveOut.Init(waveIn);

            sourceStream.StartRecording();
            waveOut.Play();

        }

        //play button
        private void button5_Click(object sender, EventArgs e)
        {




        }

        public void setPlayBtnState(string state)
        {
            btnPlay.BackgroundImage = Image.FromFile(@"C:\Users\Mark\Documents\GitHub\SoundWiz\SoundWiz\Resources\" + state + ".png");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (musicPlayer.play())
            {
                trackFileLocation.Maximum = (int)musicPlayer.getTotalSongSeconds();
                lblTotalTime.Text = String.Format("{0:00}:{1:00}", (int)musicPlayer.getWaveStream("dac").TotalTime.TotalMinutes, musicPlayer.getWaveStream("dac").TotalTime.Seconds);
                trackFileLocation.TickFrequency = trackFileLocation.Maximum / 30;
                btnPause.Enabled = true;
                btnPause.Visible = true;
                btnPlay.Enabled = false;
                btnPlay.Visible = false;



            }

        }
        //open file icon
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string allExtensions = "*.mp3;*.aiff;*.wav";
            //string allExtensions = string.Join(";", (from f in InputFileFormats select "*" + f.Extension).ToArray());
            openFileDialog.Filter = String.Format("All Supported Files|{0}|All Files (*.*)|*.*", allExtensions);
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                lblSoundFile.Text = fileName;
                musicPlayer.loadSong(fileName);
                trackFileLocation.Maximum = (int)musicPlayer.getTotalSongSeconds();
                lblTotalTime.Text = String.Format("{0:00}:{1:00}", (int)musicPlayer.getTotalSongMinutes(), musicPlayer.getTotalSongSeconds());
                trackFileLocation.TickFrequency = trackFileLocation.Maximum / 30;
            }
        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            if (setVolumeDelegateDAC != null)
            {
                setVolumeDelegateDAC(volumeSlider.Volume);
            }
            if (setVolumeDelegateDefault != null)
            {
                setVolumeDelegateDefault(volumeSlider.Volume);
            }
            label1.Text = ((int)(volumeSlider.Volume * 100)).ToString() + "%";
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            float volume = (float)trackBarVolume.Value / 100;
            if (setVolumeDelegateDAC != null)
            {
                setVolumeDelegateDAC(volume);
            }
            if (setVolumeDelegateDefault != null)
            {
                setVolumeDelegateDefault(volume);
            }

            label1.Text = volume.ToString();
        }
        /*
        private List<ISampleProvider> CreateInputStream(string fileName)
        {


            this.fileWaveStreamDAC = CreateWaveStream(fileName);
            var waveChannelDAC = new SampleChannel(this.fileWaveStreamDAC);
            this.setVolumeDelegateDAC = (vol) => waveChannelDAC.Volume = vol;
            waveChannelDAC.PreVolumeMeter += OnPreVolumeMeter;
            var postVolumeMeterDAC = new MeteringSampleProvider(waveChannelDAC);
            postVolumeMeterDAC.StreamVolume += OnPostVolumeMeter;


            this.fileWaveStreamDefault = CreateWaveStream(fileName);
            var waveChannelDefault = new SampleChannel(this.fileWaveStreamDefault);
            this.setVolumeDelegateDefault = (vol) => waveChannelDefault.Volume = vol;
            //waveChannel2.PreVolumeMeter += OnPreVolumeMeter;
            var postVolumeMeterDefault = new MeteringSampleProvider(waveChannelDefault);
            postVolumeMeterDefault.StreamVolume += OnPostVolumeMeter;


            List<ISampleProvider> postVolumeMeters = new List<ISampleProvider>();
            postVolumeMeters.Add(postVolumeMeterDAC);
            postVolumeMeters.Add(postVolumeMeterDefault);
            return postVolumeMeters;
        }
        */
        public void OnPreVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            // we know it is stereo
            waveformPainter1.AddMax(e.MaxSampleValues[0]);

        }

        public void OnPostVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            // we know it is stereo
            volumeMeter1.Amplitude = e.MaxSampleValues[0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }



        private void waitTillLoad()
        {
            WebBrowserReadyState loadStatus = default(WebBrowserReadyState);
            int waittime = 100000;
            int counter = 0;

            while (true)
            {
                loadStatus = browser.ReadyState;
                Application.DoEvents();

                if ((counter > waittime) || (loadStatus == WebBrowserReadyState.Uninitialized) || (loadStatus == WebBrowserReadyState.Loading) || (loadStatus == WebBrowserReadyState.Interactive))
                {
                    break; // TODO: might not be correct. Was : Exit While
                }
                counter += 1;
            }

            counter = 0;
            while (true)
            {
                loadStatus = browser.ReadyState;
                Application.DoEvents();

                if (loadStatus == WebBrowserReadyState.Complete)
                {
                    break; // TODO: might not be correct. Was : Exit While
                }

                counter += 1;
            }
        }

        private void trackFileLocation_Scroll(object sender, EventArgs e)
        {
            // if (waveOut != null || waveOutToMe != null && waveOutToSkype != null)
            if (musicPlayer.streamExists())
            {
                //fileWaveStreamDAC.CurrentTime = TimeSpan.FromSeconds(trackFileLocation.Value);
                //fileWaveStreamDefault.CurrentTime = TimeSpan.FromSeconds(trackFileLocation.Value);
                musicPlayer.setCurrentTime(trackFileLocation.Value);
            }
        }

        private void playerTimer_Tick(object sender, EventArgs e)
        {
            //if (waveOutToMe != null && fileWaveStreamDAC != null && waveOutToSkype != null)
            if (musicPlayer.streamExists())
            {
                TimeSpan currentTime = (musicPlayer.getPlaybackState() == PlaybackState.Stopped) ? TimeSpan.Zero : musicPlayer.getCurrentSongTime();
                if (musicPlayer.getCurrentSongPosition() >= musicPlayer.getCurrentSongLength())
                {
                    //button3_Click(sender, e);
                    musicPlayer.stop();
                }
                else
                {
                    trackFileLocation.Value = (int)currentTime.TotalSeconds;
                    lblCurrentTime.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);
                }
            }
            else
            {
                trackFileLocation.Value = 0;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            musicPlayer.pause();
            System.Threading.Thread.Sleep(150);
            btnPlay.Visible = true;
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnPause.Visible = false;

        }



    }
}

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
using System.Threading;
using Microsoft.WindowsAPICodePack.Shell;
using NAudio.CoreAudioApi;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
namespace SoundWiz
{


    public partial class Form1 : Form
    {
        public static readonly Regex YoutubeVideoRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);
        private string filePath = null;
        public Action<float> setVolumeDelegateDAC;
        public Action<float> setVolumeDelegateDefault;
        private List<FileFormats> InputFileFormats;
        private int songNumber = 1;
        WebClient webClient;
        WebBrowser browser;
        IWaveIn sourceStream = null;
        WaveOut waveOut = null;
        MusicPlayer musicPlayer;
        YouTubeDownloader youTubeDownloader;
        double testingNumber = 20.034;
        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += Application_ApplicationExit;
            //initialize supported file formats
            InputFileFormats = new List<FileFormats>();
            InputFileFormats.Add(new FileFormats("MP3", ".mp3"));
            InputFileFormats.Add(new FileFormats("WAV", ".wav"));
            InputFileFormats.Add(new FileFormats("AIFF", ".aiff"));
            //backgroundWorkerOpenFile.WorkerReportsProgress = true;
            //backgroundWorkerOpenFile.WorkerSupportsCancellation = true;
            LoadWasapiDevicesCombo();
            label3.Text = testingNumber.ToString();

            //populate the combobox with current input devices (mic, digital cable, etc.)
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));

            }
            /*
            foreach (var source in sources)
            {
                cbInputDevices.Items.Add(source.ProductName);
            } */

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
            youTubeDownloader = new YouTubeDownloader(this, musicPlayer);

            //volumeSlider.Volume = (float)0.254;

            playList.MouseDoubleClick += playList_SongSelected;

        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            musicPlayer.exit();
            Environment.Exit(0);

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

        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            label2.Text = "Completed";
        }

        private void tbYoutubeAddURL_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                progressBarYoutube.Value = 0;
                //progressBarYoutube.Visible = true;
                loadingIcon.Visible = true;
                youTubeDownloader.downloadMP3(tbYoutubeAddURL.Text);

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

        private void LoadWasapiDevicesCombo()
        {
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
            MMDeviceCollection deviceCol = deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);

            Collection<MMDevice> devices = new Collection<MMDevice>();

            foreach (MMDevice device in deviceCol)
            {
                devices.Add(device);
            }

            foreach (var item in devices)
            {
                cbInputDevices.Items.Add(item);
            }

        }

        public void cbInputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //attachInputMicrophone();
            Thread t = new Thread(attachInputMicrophone);
            t.Start();
        }

        public void wClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarYoutube.Value = e.ProgressPercentage;
        }

        public void attachInputMicrophone()
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

            System.Threading.Thread.Sleep(300);//to prevent looping of sound when switching to the virtual audio cable
            
            int deviceNumber = -1;

            if (cbInputDevices.InvokeRequired)
            {
                Action action = () => deviceNumber = cbInputDevices.SelectedIndex;
                cbInputDevices.Invoke(action);
            }
            else
            {
                deviceNumber = cbInputDevices.SelectedIndex;
            }

           // int deviceNumber = cbInputDevices.SelectedIndex;

            //get the selected input device
            // sourceStream = new WaveIn();
            //sourceStream.DeviceNumber = deviceNumber;
            //sourceStream.WaveFormat = new NAudior.Wave.WaveFormat(96000, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            //sourceStream.WaveFormat = new WaveFormat(16000, 1);
            if (deviceNumber == -1)
            {
                sourceStream = new WasapiCapture((MMDevice)cbInputDevices.Items[0]);
            }
            else
            {
                if (cbInputDevices.InvokeRequired)
                {
                    Action action = () => sourceStream = new WasapiCapture((MMDevice)cbInputDevices.SelectedItem);
                    cbInputDevices.Invoke(action);
                }
                else
                {
                    sourceStream = new WasapiCapture((MMDevice)cbInputDevices.SelectedItem);
                }
                
            }
            //set the input waveIn to the input device selected
            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            //waveOut = new NAudio.Wave.DirectSoundOut();

            //waveOut = Where the mic output will go
            waveOut = new NAudio.Wave.WaveOut();
            waveOut.DeviceNumber = 3;//digital audio cable
            waveOut.DesiredLatency = 150;
            waveOut.Init(waveIn);
            

            waveOut.Play();
            sourceStream.StartRecording();





        }

        public void setPlayBtnState(string state)
        {
            btnPlay.BackgroundImage = Image.FromFile(@"C:\Users\Mark\Documents\GitHub\SoundWiz\SoundWiz\Resources\" + state + ".png");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (musicPlayer.play())
            {
                trackFileLocation.Maximum = (int)musicPlayer.getTotalSongMiliseconds() * 10;
                lblTotalTime.Text = String.Format("{0:00}:{1:00}", (int)musicPlayer.getWaveStream("dac").TotalTime.TotalMinutes, musicPlayer.getWaveStream("dac").TotalTime.Seconds);
                trackFileLocation.TickFrequency = trackFileLocation.Maximum / 30;
                activatePauseButton();
                setDefaultVolume((float)trackBarVolume.Value / 100, (float)trackBarVolumeDAC.Value / 100);


            }
            else
            {

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
                // Filename to process was passed to RunWorkerAsync(), so it's available
                // here in DoWorkEventArgs object.
                filePath = openFileDialog.FileName;
                lblSoundFile.Text = filePath;

                ShellFile so = ShellFile.FromFilePath(filePath);
                double nanoseconds;
                double.TryParse(so.Properties.System.Media.Duration.Value.ToString(),
                out nanoseconds);
                Console.WriteLine("NanaoSeconds: {0}", nanoseconds);
                //if (nanoseconds > 0)
                //{
                double seconds = Convert100NanosecondsToMilliseconds(nanoseconds) / 1000;
                TimeSpan t = TimeSpan.FromSeconds(seconds);

                string duration = t.ToString(@"mm\:ss");
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                //}

                Song songToAdd = new Song(fileName, null, duration, filePath, true, songNumber);

                //musicPlayer.loadSong(fileName);
                musicPlayer.addSong(songToAdd);
                addSongToPlayList(songToAdd);


            }
            // attachInputMicrophone();
        }

        public void addSongToPlayList(Song songToAdd)
        {
            ListViewItem songItem = new ListViewItem(songNumber.ToString());
            songItem.SubItems.Add(songToAdd.title);
            songItem.SubItems.Add(songToAdd.duration);
            
            
            
            if (playList.InvokeRequired)
            {
                Action action = () => playList.Items.Add(songItem);
                playList.Invoke(action);
            }
            else
            {
                playList.Items.Add(songItem);
            }
            
            tbYoutubeAddURL.Text = "";
            songNumber++;

            if (songToAdd.imageURL != null)
            {
                picYouTubePicture.ImageLocation = songToAdd.imageURL;
            }
            else
            {
                picYouTubePicture.ImageLocation = "";
            }
            setProgressBarState(false);
            setLoadingIconState(false);

        }
        public void setProgressBarState(bool state)
        {
            progressBarYoutube.Visible = state;
            lblLoading.Visible = state;
        }

        public void setLoadingIconState(bool state)
        {
            loadingIcon.Visible = state;
            lblLoading.Visible = state;
        }

        public static double Convert100NanosecondsToMilliseconds(double nanoseconds)
        {
            // One million nanoseconds in 1 millisecond, 
            // but we are passing in 100ns units...
            return nanoseconds * 0.0001;
        }

        private void setDefaultVolume(float volume, float volume2)
        {
            if (setVolumeDelegateDAC != null)
            {
                setVolumeDelegateDAC(volume2);
            }
            if (setVolumeDelegateDefault != null)
            {
                setVolumeDelegateDefault(volume);
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
            label1.Text = volumeSlider.Volume.ToString();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            float volume = (float)trackBarVolume.Value / 100;
            if (setVolumeDelegateDefault != null)
            {
                setVolumeDelegateDefault(volume);
            }

            label1.Text = volume.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float volume = (float)trackBarVolumeDAC.Value / 100;
            if (setVolumeDelegateDAC != null)
            {
                setVolumeDelegateDAC(volume);
            }

            label1.Text = volume.ToString();
        }

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
            if (musicPlayer.streamExists() && musicPlayer.getPlaybackState() != PlaybackState.Stopped)
            {
                TimeSpan currentTime = (musicPlayer.getPlaybackState() == PlaybackState.Stopped) ? TimeSpan.Zero : musicPlayer.getCurrentSongTime();
                if (musicPlayer.getCurrentSongPosition() >= musicPlayer.getCurrentSongLength())
                {
                    //button3_Click(sender, e);
                    musicPlayer.stop();
                }
                else
                {
                    trackFileLocation.Value = (int)currentTime.TotalMilliseconds * 10;
                    lblCurrentTime.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);
                    label3.Text = trackFileLocation.Value.ToString();
                }
            }
            else
            {
                trackFileLocation.Value = 0;
                activatePlayButton();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            musicPlayer.pause();
            //System.Threading.Thread.Sleep(150);
            activatePlayButton();

        }


        private void playList_SongSelected(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = playList.HitTest(e.Location);
            if (hit.Item != null)
            {
                
                int songNumber = Convert.ToInt32(hit.Item.SubItems[0].Text) - 1;
                musicPlayer.loadSongBySongNumber(songNumber);
                btnPlay_Click(sender, e);

                setDefaultVolume((float)trackBarVolume.Value / 100, (float)trackBarVolumeDAC.Value / 100);
            };
        }

        private void activatePauseButton()
        {
            btnPlay.Visible = false;
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnPause.Visible = true;
        }

        private void activatePlayButton()
        {
            btnPlay.Visible = true;
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnPause.Visible = false;
        }

        ~Form1()
        {


            filePath = null;
            setVolumeDelegateDAC = null;
            setVolumeDelegateDefault = null;
            InputFileFormats = null;
            songNumber = 0;
            webClient = null;
            browser = null;
            sourceStream = null;
            waveOut = null;
            musicPlayer = null;
        }

    }
}

using Microsoft.WindowsAPICodePack.Shell;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SoundMixer
{
    public class YouTubeDownloader
    {
        public static readonly Regex YoutubeVideoRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);
        private WebClient webClient;
        private WebBrowser webBrowser;
        private Form1 _form;
        private Song youTubeSong;
        private MusicPlayer musicPlayer;
        public YouTubeDownloader(Form1 _form, MusicPlayer musicPlayer)
        {
            this._form = _form;
            webClient = new WebClient();
            webBrowser = new WebBrowser();
            webBrowser.Navigate("http://www.youtube-mp3.org/");
            webBrowser.ScriptErrorsSuppressed = true;
            this.musicPlayer = musicPlayer;

        }

        public Song getDownloadedYoutubeSong()
        {
            return youTubeSong;
        }

        public void downloadMP3(string url)
        {
            //set the youtube url to convert on the form
            webBrowser.Document.GetElementById("youtube-url").SetAttribute("Value", url);
            string link = null;

            do
            {
                //click convert
                webBrowser.Document.GetElementById("submit").InvokeMember("Click");
                waitTillLoad();

                //check to see if there are any error from converting
                HtmlElement error = webBrowser.Document.GetElementById("error_text");
                if (error.Style == "DISPLAY: block")
                {
                    //lblErrorMessageYoutubeLInk.Text = error.InnerText;
                    //textBox2.Text = ""; replace with whats going to be reading the stream for mp3
                    //loadingIcon.Visible = false;
                    break;
                }

                HtmlElement status = webBrowser.Document.GetElementById("status_text");

                if (status.InnerText.Contains("Video successfully converted to mp3"))
                {
                    link = webBrowser.Document.GetElementById("dl_link").InnerHtml;

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

                //textBox2.Text = "http://www.youtube-mp3.org/" + downloadUrl; //replace with whats going to be reading the stream for mp3

                //lblErrorMessageYoutubeLInk.Text = "";

                Match youtubeMatch = YoutubeVideoRegex.Match(url);
                string youtubeID = string.Empty;

                if (youtubeMatch.Success)
                    youtubeID = youtubeMatch.Groups[1].Value;

                string y = webClient.DownloadString("http://gdata.youtube.com/feeds/api/videos/" + youtubeID + "?v=2&alt=json&prettyprint=true");

                JObject JObj = (JObject)JsonConvert.DeserializeObject(y);

                YouTubeDataFeed youTubeDataFeed = JsonConvert.DeserializeObject<YouTubeDataFeed>(y);

                string fileURL = "http://www.youtube-mp3.org/" + downloadUrl;

                var dialog = new SaveFileDialog();

                List<string> invalidCharacters = new List<string>() { "<", ">", ":", "/", "\\", "|", "?", "*" };
                string filePath = youTubeDataFeed.entry.title.t.ToString();
                foreach (var item in invalidCharacters)
                {
                    filePath = filePath.Replace(item, "");
                }
                string pictureURL = youTubeDataFeed.entry.mediagroup.mediathumbnail[2].url.ToString();
                

                dialog.FileName = filePath  + ".mp3";
                dialog.Filter = "MP3 (*.mp3)|*.mp3";


                var result = dialog.ShowDialog(); //shows save file dialog

                if (result == DialogResult.OK)
                {
                    var wClientMP3 = new WebClient();
                    var wClientMP3Picture = new WebClient();
                    wClientMP3.DownloadFileCompleted += client_DownloadFileCompleted;
                    wClientMP3.DownloadProgressChanged += _form.wClient_DownloadProgressChanged;
                    _form.setLoadingIconState(false);
                    _form.setProgressBarState(true);
                    wClientMP3.DownloadFileAsync(new System.Uri(fileURL), dialog.FileName);
                    wClientMP3Picture.DownloadFileAsync(new System.Uri(pictureURL), dialog.FileName.Replace(".mp3", ".jpg"));
                    youTubeSong = new Song(youTubeDataFeed.entry.title.t.ToString(), pictureURL, null, dialog.FileName, false, 0);

                }


            }
            else
            {
                //lblErrorMessageYoutubeLInk.ForeColor = Color.Red;

            }
        }



        private void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

            youTubeSong.duration = getDuration(youTubeSong.filePath);
            youTubeSong.isReady = true;
            musicPlayer.addSong(youTubeSong);
            youTubeSong.songNumber = musicPlayer.totalSongs;
            _form.addSongToPlayList(youTubeSong);

        }

        public string getDuration(string filePath)
        {
            ShellFile so = ShellFile.FromFilePath(filePath);
            double nanoseconds;
            double.TryParse(so.Properties.System.Media.Duration.Value.ToString(),
            out nanoseconds);
            Console.WriteLine("NanaoSeconds: {0}", nanoseconds);

            double seconds = Convert100NanosecondsToMilliseconds(nanoseconds) / 1000;
            TimeSpan t = TimeSpan.FromSeconds(seconds);

            string duration = t.ToString(@"mm\:ss");
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            return duration;
        }

        public static double Convert100NanosecondsToMilliseconds(double nanoseconds)
        {
            // One million nanoseconds in 1 millisecond, 
            // but we are passing in 100ns units...
            return nanoseconds * 0.0001;
        }

        private void waitTillLoad()
        {
            WebBrowserReadyState loadStatus = default(WebBrowserReadyState);
            int waittime = 100000;
            int counter = 0;

            while (true)
            {
                loadStatus = webBrowser.ReadyState;
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
                loadStatus = webBrowser.ReadyState;
                Application.DoEvents();

                if (loadStatus == WebBrowserReadyState.Complete)
                {
                    break; // TODO: might not be correct. Was : Exit While
                }

                counter += 1;
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



    }
}

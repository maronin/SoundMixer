using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundMixer
{
    public class Song
    {
        public string title { get; set; }
        public string imageURL;
        public string duration { get; set; }
        public string filePath { get; set; }
        public bool isReady = false;
        public int songNumber { get; set; }
        public Song(string title, string imageURL, string duration, string filePath, bool isReady, int songNumber)
        {
            this.title = title;
            this.imageURL = imageURL;
            this.duration = duration;
            this.filePath = filePath;
            this.isReady = isReady;
            this.songNumber = songNumber;
        }


    }
}

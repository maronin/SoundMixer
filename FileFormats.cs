using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SoundWiz
{
    public class FileFormats
    {
        string name, extension;

        public FileFormats(string name, string extension)
        {
            this.name = name;
            this.extension = extension;
        }


    }
}

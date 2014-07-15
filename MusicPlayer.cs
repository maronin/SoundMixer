﻿using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave.WaveFormats;
namespace SoundWiz
{
    public class MusicPlayer
    {

        private string currentSong;
        private Queue playerQueue;
        private WaveStream fileWaveStreamDAC;
        private WaveStream fileWaveStreamDefault;
        private IWavePlayer waveOutToMe, waveOutToSkype; //IwaveOutPlayer!!!
        private Form1 _form;
        public bool isPlaying = false;
        public MusicPlayer(Form1 _form)
        {
            this._form = _form;
        }

        public void stop()
        {

            if (waveOutToSkype != null)
                waveOutToSkype.Stop();
            if (waveOutToMe != null)
                waveOutToMe.Stop();
            isPlaying = false;
        }

        public bool play()
        {
            bool rc = false;

            if (waveOutToMe != null && waveOutToSkype != null)
            {
                if (waveOutToMe.PlaybackState == PlaybackState.Paused || waveOutToMe.PlaybackState == PlaybackState.Stopped)
                {
                    waveOutToMe.Play();
                    waveOutToSkype.Play();
                    isPlaying = true;
                    rc = true;
                }
            }


            return rc;



        }

        public bool loadSong(string filename)
        {
            currentSong = filename;
            ISampleProvider wavFileToSkype = null;
            ISampleProvider wavFileToMe = null;
            
            
            try
            {

               List<ISampleProvider> volumeMeters = CreateInputStream(currentSong);

                wavFileToSkype = volumeMeters[0];
                wavFileToMe = volumeMeters[1];

               var waveOut = new WaveOutEvent();
               waveOut.DeviceNumber = 0;
               waveOut.DesiredLatency = 150;
               waveOutToMe = waveOut;

                
                
                
               
                //play out to me
               // WaveOut device = new NAudio.Wave.WaveOut();
                //waveOutToMe = new NAudio.Wave.IWavePlayer();
                //device.DeviceNumber = 0; //default output device
                //device.DesiredLatency = 150;



                waveOutToMe.Init(new SampleToWaveProvider(wavFileToMe));
                //waveOutToMe.Play();

                //play out to skype

                var waveOut2 = new WaveOutEvent();
                waveOut2.DeviceNumber = 0;
                waveOut2.DesiredLatency = 150;
                waveOutToSkype = waveOut2;

               // waveOutToSkype = new NAudio.Wave.WaveOut();
             //   waveOutToSkype.DeviceNumber = 3; //digital audio cable
             //   waveOutToSkype.DesiredLatency = 150;
                waveOutToSkype.Init(new SampleToWaveProvider(wavFileToSkype));
                //waveOutToSkype.Play();
                isPlaying = true;
                return true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("not a valid file type");
                return false;
            }
        }

        public void setCurrentTime(int time)
        {
            fileWaveStreamDAC.CurrentTime = TimeSpan.FromSeconds(time);
            fileWaveStreamDefault.CurrentTime = TimeSpan.FromSeconds(time);
        }



        public void pause()
        {
            if (waveOutToMe != null)
            {
                if (waveOutToMe.PlaybackState == PlaybackState.Playing)
                {
                    waveOutToMe.Pause();
                    waveOutToSkype.Pause();
                }
            }
        }

        public void next()
        {

        }

        public void prev()
        {

        }

        public void setSong(string filename)
        {
            currentSong = filename;
        }

        public TimeSpan getCurrentSongTime()
        {

            return fileWaveStreamDefault.CurrentTime;
        }

        public double getTotalSongSeconds()
        {
            return fileWaveStreamDefault.TotalTime.TotalSeconds;
        }

        public double getTotalSongMinutes()
        {
            return fileWaveStreamDefault.TotalTime.TotalMinutes;
        }

        public long getCurrentSongPosition()
        {
            return fileWaveStreamDefault.Position;
        }

        public long getCurrentSongLength()
        {
            return fileWaveStreamDefault.Length;
        }

        public PlaybackState getPlaybackState()
        {
            return waveOutToMe.PlaybackState;
        }

        public bool streamExists()
        {
            if (waveOutToSkype != null && waveOutToMe != null && fileWaveStreamDAC != null && fileWaveStreamDefault != null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public WaveStream getWaveStream(string stream)
        {
            if (stream.ToLower() == "dac")
            {
                return fileWaveStreamDAC;
            }
            else if (stream.ToLower() == "default")
            {
                return fileWaveStreamDefault;
            }
            else
            {
                return null;
            }
        }
        private List<ISampleProvider> CreateInputStream(string fileName)
        {

            if (fileName != null)
            {
                this.fileWaveStreamDAC = CreateWaveStream(fileName);
                var waveChannelDAC = new SampleChannel(this.fileWaveStreamDAC);

                _form.setVolumeDelegateDAC = (vol) => waveChannelDAC.Volume = vol;
                waveChannelDAC.PreVolumeMeter += _form.OnPreVolumeMeter;
                var postVolumeMeterDAC = new MeteringSampleProvider(waveChannelDAC);
                postVolumeMeterDAC.StreamVolume += _form.OnPostVolumeMeter;


                this.fileWaveStreamDefault = CreateWaveStream(fileName);
                var waveChannelDefault = new SampleChannel(this.fileWaveStreamDefault);
                _form.setVolumeDelegateDefault = (vol) => waveChannelDefault.Volume = vol;
                waveChannelDefault.Volume = (float)0.254;
                //waveChannel2.PreVolumeMeter += OnPreVolumeMeter;
                var postVolumeMeterDefault = new MeteringSampleProvider(waveChannelDefault);
                postVolumeMeterDefault.StreamVolume += _form.OnPostVolumeMeter;


                List<ISampleProvider> postVolumeMeters = new List<ISampleProvider>();
                postVolumeMeters.Add(postVolumeMeterDAC);
                postVolumeMeters.Add(postVolumeMeterDefault);
                return postVolumeMeters;
            }
            else
            {
                return null;
            }
        }

        public WaveStream CreateWaveStream(string fileName)
        {
            if (Path.GetExtension(fileName) == ".wav")
            {
                WaveStream readerStream = new WaveFileReader(fileName);
                if (readerStream.WaveFormat.Encoding != WaveFormatEncoding.Pcm && readerStream.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
                {
                    readerStream = WaveFormatConversionStream.CreatePcmStream(readerStream);
                    readerStream = new BlockAlignReductionStream(readerStream);
                }
                return readerStream;

            }
            else if (Path.GetExtension(fileName) == ".mp3")
            {
                Mp3FileReader readerStream = new Mp3FileReader(fileName);

                return new Mp3FileReader(fileName);
            }
            else if (Path.GetExtension(fileName) == ".aiff")
            {
                return new AiffFileReader(fileName);

            }
            else
            {
                return null;
            }
        }

    }



}

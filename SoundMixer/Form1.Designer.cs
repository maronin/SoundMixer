using System;
using System.Windows.Forms;

namespace SoundMixer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Make the window draggable without a border.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbInputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.trackBarVolumeDAC = new System.Windows.Forms.TrackBar();
            this.trackBarDefaultVolume = new System.Windows.Forms.TrackBar();
            this.trackFileLocation = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYoutubeAddURL = new System.Windows.Forms.TextBox();
            this.lblErrorMessageYoutubeLInk = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.loadingIcon = new System.Windows.Forms.PictureBox();
            this.picYouTubePicture = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.playList = new System.Windows.Forms.ListView();
            this.songNumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songDurationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarYoutube = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.muteMic = new System.Windows.Forms.CheckBox();
            this.pnlDevices = new System.Windows.Forms.Panel();
            this.InputOutputMixerBox = new System.Windows.Forms.GroupBox();
            this.cbOutputDevices = new System.Windows.Forms.ComboBox();
            this.MixedOutputBox = new System.Windows.Forms.GroupBox();
            this.cbMusicOutput = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playlistPanel = new System.Windows.Forms.Panel();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.whatYouHearVolumeGroupBox = new System.Windows.Forms.GroupBox();
            this.whatOthersHearVolumeGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumeDAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDefaultVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFileLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouTubePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            this.pnlDevices.SuspendLayout();
            this.InputOutputMixerBox.SuspendLayout();
            this.MixedOutputBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.playlistPanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.whatYouHearVolumeGroupBox.SuspendLayout();
            this.whatOthersHearVolumeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInputDevices
            // 
            this.cbInputDevices.BackColor = System.Drawing.Color.GreenYellow;
            this.cbInputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInputDevices.FormattingEnabled = true;
            this.cbInputDevices.Location = new System.Drawing.Point(6, 19);
            this.cbInputDevices.Name = "cbInputDevices";
            this.cbInputDevices.Size = new System.Drawing.Size(153, 21);
            this.cbInputDevices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.Black;
            this.waveformPainter1.ForeColor = System.Drawing.Color.White;
            this.waveformPainter1.Location = new System.Drawing.Point(261, 170);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(563, 168);
            this.waveformPainter1.TabIndex = 9;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.BackColor = System.Drawing.Color.BlueViolet;
            this.volumeMeter1.ForeColor = System.Drawing.Color.White;
            this.volumeMeter1.Location = new System.Drawing.Point(1190, 21);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(28, 317);
            this.volumeMeter1.TabIndex = 8;
            this.volumeMeter1.Text = "volumeMeter1";
            this.volumeMeter1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(261, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 57);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(288, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(38, 56);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(165, 7);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(54, 46);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(279, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(58, 46);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Location = new System.Drawing.Point(235, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 56);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 0;
            this.btnStop.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(343, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 46);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            // 
            // trackBarVolumeDAC
            // 
            this.trackBarVolumeDAC.Location = new System.Drawing.Point(2, 19);
            this.trackBarVolumeDAC.Maximum = 100;
            this.trackBarVolumeDAC.Name = "trackBarVolumeDAC";
            this.trackBarVolumeDAC.Size = new System.Drawing.Size(214, 45);
            this.trackBarVolumeDAC.TabIndex = 14;
            this.trackBarVolumeDAC.TickFrequency = 5;
            this.trackBarVolumeDAC.Value = 25;
            this.trackBarVolumeDAC.Scroll += new System.EventHandler(this.trackBarVolumeDAC_Scroll);
            // 
            // trackBarDefaultVolume
            // 
            this.trackBarDefaultVolume.BackColor = System.Drawing.Color.Black;
            this.trackBarDefaultVolume.Location = new System.Drawing.Point(3, 19);
            this.trackBarDefaultVolume.Maximum = 100;
            this.trackBarDefaultVolume.Name = "trackBarDefaultVolume";
            this.trackBarDefaultVolume.Size = new System.Drawing.Size(213, 45);
            this.trackBarDefaultVolume.TabIndex = 14;
            this.trackBarDefaultVolume.TickFrequency = 5;
            this.trackBarDefaultVolume.Value = 25;
            this.trackBarDefaultVolume.Scroll += new System.EventHandler(this.trackBarDefaultVolume_Scroll);
            // 
            // trackFileLocation
            // 
            this.trackFileLocation.Location = new System.Drawing.Point(45, 9);
            this.trackFileLocation.Maximum = 10000;
            this.trackFileLocation.Name = "trackFileLocation";
            this.trackFileLocation.Size = new System.Drawing.Size(415, 45);
            this.trackFileLocation.TabIndex = 14;
            this.trackFileLocation.TickFrequency = 1000;
            this.trackFileLocation.Scroll += new System.EventHandler(this.trackFileLocation_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Youtube URL: ";
            // 
            // tbYoutubeAddURL
            // 
            this.tbYoutubeAddURL.Location = new System.Drawing.Point(55, 30);
            this.tbYoutubeAddURL.Name = "tbYoutubeAddURL";
            this.tbYoutubeAddURL.Size = new System.Drawing.Size(259, 20);
            this.tbYoutubeAddURL.TabIndex = 15;
            // 
            // lblErrorMessageYoutubeLInk
            // 
            this.lblErrorMessageYoutubeLInk.AutoSize = true;
            this.lblErrorMessageYoutubeLInk.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessageYoutubeLInk.Location = new System.Drawing.Point(398, 250);
            this.lblErrorMessageYoutubeLInk.Name = "lblErrorMessageYoutubeLInk";
            this.lblErrorMessageYoutubeLInk.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessageYoutubeLInk.TabIndex = 18;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(507, 14);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(34, 13);
            this.lblTotalTime.TabIndex = 20;
            this.lblTotalTime.Text = "00:00";
            this.lblTotalTime.Click += new System.EventHandler(this.lblTotalTime_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(467, 14);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.lblCurrentTime.TabIndex = 21;
            this.lblCurrentTime.Text = "00:00";
            this.lblCurrentTime.Click += new System.EventHandler(this.lblCurrentTime_Click);
            // 
            // loadingIcon
            // 
            this.loadingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingIcon.InitialImage = null;
            this.loadingIcon.Location = new System.Drawing.Point(42, 36);
            this.loadingIcon.Name = "loadingIcon";
            this.loadingIcon.Size = new System.Drawing.Size(57, 57);
            this.loadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingIcon.TabIndex = 22;
            this.loadingIcon.TabStop = false;
            this.loadingIcon.Visible = false;
            // 
            // picYouTubePicture
            // 
            this.picYouTubePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picYouTubePicture.ImageLocation = "";
            this.picYouTubePicture.Location = new System.Drawing.Point(22, 18);
            this.picYouTubePicture.Name = "picYouTubePicture";
            this.picYouTubePicture.Size = new System.Drawing.Size(101, 95);
            this.picYouTubePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYouTubePicture.TabIndex = 19;
            this.picYouTubePicture.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.Location = new System.Drawing.Point(21, 30);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(28, 20);
            this.btnOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Interval = 250;
            this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
            // 
            // playList
            // 
            this.playList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songNumberCol,
            this.songNameCol,
            this.songDurationCol});
            this.playList.FullRowSelect = true;
            this.playList.Location = new System.Drawing.Point(21, 58);
            this.playList.Margin = new System.Windows.Forms.Padding(5);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(293, 259);
            this.playList.TabIndex = 25;
            this.playList.UseCompatibleStateImageBehavior = false;
            this.playList.View = System.Windows.Forms.View.Details;
            // 
            // songNumberCol
            // 
            this.songNumberCol.Text = "#";
            this.songNumberCol.Width = 25;
            // 
            // songNameCol
            // 
            this.songNameCol.Text = "Name";
            this.songNameCol.Width = 143;
            // 
            // songDurationCol
            // 
            this.songDurationCol.Text = "Duration";
            // 
            // progressBarYoutube
            // 
            this.progressBarYoutube.Location = new System.Drawing.Point(23, 47);
            this.progressBarYoutube.Name = "progressBarYoutube";
            this.progressBarYoutube.Size = new System.Drawing.Size(100, 25);
            this.progressBarYoutube.TabIndex = 26;
            this.progressBarYoutube.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(45, 96);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 27;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // muteMic
            // 
            this.muteMic.AutoSize = true;
            this.muteMic.ForeColor = System.Drawing.Color.White;
            this.muteMic.Location = new System.Drawing.Point(166, 21);
            this.muteMic.Name = "muteMic";
            this.muteMic.Size = new System.Drawing.Size(50, 17);
            this.muteMic.TabIndex = 28;
            this.muteMic.Text = "Mute";
            this.muteMic.UseVisualStyleBackColor = true;
            this.muteMic.CheckedChanged += new System.EventHandler(this.muteMic_CheckedChanged);
            // 
            // pnlDevices
            // 
            this.pnlDevices.Controls.Add(this.whatOthersHearVolumeGroupBox);
            this.pnlDevices.Controls.Add(this.whatYouHearVolumeGroupBox);
            this.pnlDevices.Controls.Add(this.InputOutputMixerBox);
            this.pnlDevices.Controls.Add(this.MixedOutputBox);
            this.pnlDevices.Location = new System.Drawing.Point(12, 21);
            this.pnlDevices.Name = "pnlDevices";
            this.pnlDevices.Size = new System.Drawing.Size(243, 329);
            this.pnlDevices.TabIndex = 30;
            // 
            // InputOutputMixerBox
            // 
            this.InputOutputMixerBox.Controls.Add(this.cbInputDevices);
            this.InputOutputMixerBox.Controls.Add(this.cbOutputDevices);
            this.InputOutputMixerBox.Controls.Add(this.muteMic);
            this.InputOutputMixerBox.ForeColor = System.Drawing.Color.White;
            this.InputOutputMixerBox.Location = new System.Drawing.Point(9, 9);
            this.InputOutputMixerBox.Name = "InputOutputMixerBox";
            this.InputOutputMixerBox.Size = new System.Drawing.Size(219, 76);
            this.InputOutputMixerBox.TabIndex = 30;
            this.InputOutputMixerBox.TabStop = false;
            this.InputOutputMixerBox.Text = "Input/Output";
            // 
            // cbOutputDevices
            // 
            this.cbOutputDevices.BackColor = System.Drawing.Color.GreenYellow;
            this.cbOutputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOutputDevices.FormattingEnabled = true;
            this.cbOutputDevices.Location = new System.Drawing.Point(6, 46);
            this.cbOutputDevices.Name = "cbOutputDevices";
            this.cbOutputDevices.Size = new System.Drawing.Size(153, 21);
            this.cbOutputDevices.TabIndex = 1;
            // 
            // MixedOutputBox
            // 
            this.MixedOutputBox.Controls.Add(this.cbMusicOutput);
            this.MixedOutputBox.ForeColor = System.Drawing.Color.White;
            this.MixedOutputBox.Location = new System.Drawing.Point(9, 101);
            this.MixedOutputBox.Name = "MixedOutputBox";
            this.MixedOutputBox.Size = new System.Drawing.Size(219, 51);
            this.MixedOutputBox.TabIndex = 30;
            this.MixedOutputBox.TabStop = false;
            this.MixedOutputBox.Text = "Music Output";
            this.MixedOutputBox.Enter += new System.EventHandler(this.MixedOutputBox_Enter);
            // 
            // cbMusicOutput
            // 
            this.cbMusicOutput.BackColor = System.Drawing.Color.GreenYellow;
            this.cbMusicOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMusicOutput.FormattingEnabled = true;
            this.cbMusicOutput.Location = new System.Drawing.Point(6, 19);
            this.cbMusicOutput.Name = "cbMusicOutput";
            this.cbMusicOutput.Size = new System.Drawing.Size(153, 21);
            this.cbMusicOutput.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLoading);
            this.panel2.Controls.Add(this.loadingIcon);
            this.panel2.Controls.Add(this.picYouTubePicture);
            this.panel2.Controls.Add(this.progressBarYoutube);
            this.panel2.Location = new System.Drawing.Point(421, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 128);
            this.panel2.TabIndex = 31;
            // 
            // playlistPanel
            // 
            this.playlistPanel.Controls.Add(this.label2);
            this.playlistPanel.Controls.Add(this.btnOpenFile);
            this.playlistPanel.Controls.Add(this.tbYoutubeAddURL);
            this.playlistPanel.Controls.Add(this.playList);
            this.playlistPanel.Location = new System.Drawing.Point(844, 21);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(335, 329);
            this.playlistPanel.TabIndex = 32;
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.panel2);
            this.playerPanel.Controls.Add(this.trackFileLocation);
            this.playerPanel.Controls.Add(this.lblCurrentTime);
            this.playerPanel.Controls.Add(this.lblTotalTime);
            this.playerPanel.Location = new System.Drawing.Point(261, 47);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(563, 50);
            this.playerPanel.TabIndex = 33;
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.White;
            this.volumeSlider.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.volumeSlider.ForeColor = System.Drawing.Color.White;
            this.volumeSlider.Location = new System.Drawing.Point(682, 310);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(125, 23);
            this.volumeSlider.TabIndex = 34;
            this.volumeSlider.Visible = false;
            this.volumeSlider.Volume = 0F;
            // 
            // whatYouHearVolumeGroupBox
            // 
            this.whatYouHearVolumeGroupBox.Controls.Add(this.trackBarDefaultVolume);
            this.whatYouHearVolumeGroupBox.ForeColor = System.Drawing.Color.White;
            this.whatYouHearVolumeGroupBox.Location = new System.Drawing.Point(9, 173);
            this.whatYouHearVolumeGroupBox.Name = "whatYouHearVolumeGroupBox";
            this.whatYouHearVolumeGroupBox.Size = new System.Drawing.Size(219, 69);
            this.whatYouHearVolumeGroupBox.TabIndex = 31;
            this.whatYouHearVolumeGroupBox.TabStop = false;
            this.whatYouHearVolumeGroupBox.Text = "What You Hear Volume";
            // 
            // whatOthersHearVolumeGroupBox
            // 
            this.whatOthersHearVolumeGroupBox.Controls.Add(this.trackBarVolumeDAC);
            this.whatOthersHearVolumeGroupBox.ForeColor = System.Drawing.Color.White;
            this.whatOthersHearVolumeGroupBox.Location = new System.Drawing.Point(9, 248);
            this.whatOthersHearVolumeGroupBox.Name = "whatOthersHearVolumeGroupBox";
            this.whatOthersHearVolumeGroupBox.Size = new System.Drawing.Size(219, 69);
            this.whatOthersHearVolumeGroupBox.TabIndex = 32;
            this.whatOthersHearVolumeGroupBox.TabStop = false;
            this.whatOthersHearVolumeGroupBox.Text = "What Others Hear Volume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1230, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.playlistPanel);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.pnlDevices);
            this.Controls.Add(this.lblErrorMessageYoutubeLInk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skype Mixer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumeDAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDefaultVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFileLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouTubePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            this.pnlDevices.ResumeLayout(false);
            this.InputOutputMixerBox.ResumeLayout(false);
            this.InputOutputMixerBox.PerformLayout();
            this.MixedOutputBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.playlistPanel.ResumeLayout(false);
            this.playlistPanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.whatYouHearVolumeGroupBox.ResumeLayout(false);
            this.whatYouHearVolumeGroupBox.PerformLayout();
            this.whatOthersHearVolumeGroupBox.ResumeLayout(false);
            this.whatOthersHearVolumeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox btnOpenFile;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private System.Windows.Forms.ComboBox cbInputDevices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.TrackBar trackFileLocation;
        private System.Windows.Forms.TrackBar trackBarDefaultVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYoutubeAddURL;
        private System.Windows.Forms.Label lblErrorMessageYoutubeLInk;
        private System.Windows.Forms.PictureBox loadingIcon;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.PictureBox picYouTubePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.ListView playList;
        private System.Windows.Forms.ColumnHeader songNameCol;
        private System.Windows.Forms.ColumnHeader songDurationCol;
        private System.Windows.Forms.ColumnHeader songNumberCol;
        private System.Windows.Forms.TrackBar trackBarVolumeDAC;
        private System.Windows.Forms.ProgressBar progressBarYoutube;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.CheckBox muteMic;
        private System.Windows.Forms.Panel pnlDevices;
        private System.Windows.Forms.ComboBox cbOutputDevices;
        private System.Windows.Forms.GroupBox MixedOutputBox;
        private System.Windows.Forms.ComboBox cbMusicOutput;
        private System.Windows.Forms.GroupBox InputOutputMixerBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel playlistPanel;
        private Panel playerPanel;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private GroupBox whatYouHearVolumeGroupBox;
        private GroupBox whatOthersHearVolumeGroupBox;
    }
}


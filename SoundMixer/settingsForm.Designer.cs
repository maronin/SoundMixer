namespace SoundMixer
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbInputDevices = new System.Windows.Forms.ComboBox();
            this.cbOutputDevices = new System.Windows.Forms.ComboBox();
            this.InputOutputMixerBox = new System.Windows.Forms.GroupBox();
            this.MixedOutputBox = new System.Windows.Forms.GroupBox();
            this.cbMusicOutput = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blankLbl = new System.Windows.Forms.Label();
            this.InputOutputMixerBox.SuspendLayout();
            this.MixedOutputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInputDevices
            // 
            this.cbInputDevices.BackColor = System.Drawing.Color.GreenYellow;
            this.cbInputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInputDevices.FormattingEnabled = true;
            this.cbInputDevices.Location = new System.Drawing.Point(6, 22);
            this.cbInputDevices.Name = "cbInputDevices";
            this.cbInputDevices.Size = new System.Drawing.Size(153, 21);
            this.cbInputDevices.TabIndex = 2;
            this.cbInputDevices.DropDownClosed += new System.EventHandler(this.dropDownClosed);
            // 
            // cbOutputDevices
            // 
            this.cbOutputDevices.BackColor = System.Drawing.Color.GreenYellow;
            this.cbOutputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOutputDevices.FormattingEnabled = true;
            this.cbOutputDevices.Location = new System.Drawing.Point(6, 49);
            this.cbOutputDevices.Name = "cbOutputDevices";
            this.cbOutputDevices.Size = new System.Drawing.Size(153, 21);
            this.cbOutputDevices.TabIndex = 3;
            this.cbOutputDevices.DropDownClosed += new System.EventHandler(this.dropDownClosed);
            // 
            // InputOutputMixerBox
            // 
            this.InputOutputMixerBox.Controls.Add(this.cbInputDevices);
            this.InputOutputMixerBox.Controls.Add(this.cbOutputDevices);
            this.InputOutputMixerBox.ForeColor = System.Drawing.Color.White;
            this.InputOutputMixerBox.Location = new System.Drawing.Point(24, 39);
            this.InputOutputMixerBox.Name = "InputOutputMixerBox";
            this.InputOutputMixerBox.Size = new System.Drawing.Size(219, 76);
            this.InputOutputMixerBox.TabIndex = 31;
            this.InputOutputMixerBox.TabStop = false;
            this.InputOutputMixerBox.Text = "Input/Output";
            // 
            // MixedOutputBox
            // 
            this.MixedOutputBox.Controls.Add(this.cbMusicOutput);
            this.MixedOutputBox.ForeColor = System.Drawing.Color.White;
            this.MixedOutputBox.Location = new System.Drawing.Point(24, 131);
            this.MixedOutputBox.Name = "MixedOutputBox";
            this.MixedOutputBox.Size = new System.Drawing.Size(219, 51);
            this.MixedOutputBox.TabIndex = 34;
            this.MixedOutputBox.TabStop = false;
            this.MixedOutputBox.Text = "Music Output";
            // 
            // cbMusicOutput
            // 
            this.cbMusicOutput.BackColor = System.Drawing.Color.DarkKhaki;
            this.cbMusicOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusicOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMusicOutput.FormattingEnabled = true;
            this.cbMusicOutput.Location = new System.Drawing.Point(6, 19);
            this.cbMusicOutput.Name = "cbMusicOutput";
            this.cbMusicOutput.Size = new System.Drawing.Size(153, 21);
            this.cbMusicOutput.TabIndex = 1;
            this.cbMusicOutput.DropDownClosed += new System.EventHandler(this.dropDownClosed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SoundMixer.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(258, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // blankLbl
            // 
            this.blankLbl.AutoSize = true;
            this.blankLbl.Location = new System.Drawing.Point(217, 15);
            this.blankLbl.Name = "blankLbl";
            this.blankLbl.Size = new System.Drawing.Size(0, 13);
            this.blankLbl.TabIndex = 39;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.blankLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MixedOutputBox);
            this.Controls.Add(this.InputOutputMixerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "settingsForm";
            this.InputOutputMixerBox.ResumeLayout(false);
            this.MixedOutputBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInputDevices;
        private System.Windows.Forms.ComboBox cbOutputDevices;
        private System.Windows.Forms.GroupBox InputOutputMixerBox;
        private System.Windows.Forms.GroupBox MixedOutputBox;
        private System.Windows.Forms.ComboBox cbMusicOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label blankLbl;
    }
}
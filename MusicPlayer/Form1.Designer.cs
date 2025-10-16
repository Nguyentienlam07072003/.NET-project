namespace MusicPlayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.endbtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.ListMusic = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(181, 41);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(75, 23);
            this.playbtn.TabIndex = 1;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(68, 149);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(31, 23);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "<<";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.Location = new System.Drawing.Point(122, 149);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(31, 23);
            this.previousbtn.TabIndex = 7;
            this.previousbtn.Text = "<";
            this.previousbtn.UseVisualStyleBackColor = true;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(172, 149);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(30, 23);
            this.nextbtn.TabIndex = 8;
            this.nextbtn.Text = ">";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // endbtn
            // 
            this.endbtn.Location = new System.Drawing.Point(225, 149);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(31, 23);
            this.endbtn.TabIndex = 9;
            this.endbtn.Text = ">>";
            this.endbtn.UseVisualStyleBackColor = true;
            this.endbtn.Click += new System.EventHandler(this.endbtn_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(43, 191);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(30, 13);
            this.Timer.TabIndex = 10;
            this.Timer.Text = "Time";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(79, 191);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(34, 13);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "00:00";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(191, 191);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(47, 13);
            this.lbl_duration.TabIndex = 12;
            this.lbl_duration.Text = "Duration";
            this.lbl_duration.Click += new System.EventHandler(this.lbl_duration_Click);
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Location = new System.Drawing.Point(244, 191);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(34, 13);
            this.lblduration.TabIndex = 13;
            this.lblduration.Text = "00:00";
            this.lblduration.Click += new System.EventHandler(this.lblduration_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(68, 41);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 19;
            this.addbtn.Text = "Add File";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // ListMusic
            // 
            this.ListMusic.FormattingEnabled = true;
            this.ListMusic.Location = new System.Drawing.Point(284, 12);
            this.ListMusic.Name = "ListMusic";
            this.ListMusic.Size = new System.Drawing.Size(291, 290);
            this.ListMusic.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(42, 88);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(235, 45);
            this.Player.TabIndex = 0;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 315);
            this.Controls.Add(this.ListMusic);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox ListMusic;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
    }
}


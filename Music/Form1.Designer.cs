namespace Music
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
            this.gb_music = new System.Windows.Forms.GroupBox();
            this.lbl_volume2 = new System.Windows.Forms.Label();
            this.lb_Track_List = new System.Windows.Forms.ListBox();
            this.lbl_Track_Time_End = new System.Windows.Forms.Label();
            this.lbl_Track_Time_Start = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.tb_Volume = new System.Windows.Forms.TrackBar();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pb_Music = new System.Windows.Forms.ProgressBar();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.bt_Play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.gb_music.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_music
            // 
            this.gb_music.Controls.Add(this.lbl_volume2);
            this.gb_music.Controls.Add(this.lb_Track_List);
            this.gb_music.Controls.Add(this.lbl_Track_Time_End);
            this.gb_music.Controls.Add(this.lbl_Track_Time_Start);
            this.gb_music.Controls.Add(this.lbl_Volume);
            this.gb_music.Controls.Add(this.tb_Volume);
            this.gb_music.Controls.Add(this.pb_Image);
            this.gb_music.Controls.Add(this.btn_Open);
            this.gb_music.Controls.Add(this.btn_Previous);
            this.gb_music.Controls.Add(this.btn_Next);
            this.gb_music.Controls.Add(this.pb_Music);
            this.gb_music.Controls.Add(this.btn_Stop);
            this.gb_music.Controls.Add(this.btn_Pause);
            this.gb_music.Controls.Add(this.bt_Play);
            this.gb_music.Controls.Add(this.player);
            this.gb_music.Location = new System.Drawing.Point(42, 22);
            this.gb_music.Margin = new System.Windows.Forms.Padding(2);
            this.gb_music.Name = "gb_music";
            this.gb_music.Padding = new System.Windows.Forms.Padding(2);
            this.gb_music.Size = new System.Drawing.Size(549, 346);
            this.gb_music.TabIndex = 0;
            this.gb_music.TabStop = false;
            // 
            // lbl_volume2
            // 
            this.lbl_volume2.AutoSize = true;
            this.lbl_volume2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume2.ForeColor = System.Drawing.Color.Coral;
            this.lbl_volume2.Location = new System.Drawing.Point(493, 69);
            this.lbl_volume2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_volume2.Name = "lbl_volume2";
            this.lbl_volume2.Size = new System.Drawing.Size(52, 18);
            this.lbl_volume2.TabIndex = 15;
            this.lbl_volume2.Text = "100%";
            // 
            // lb_Track_List
            // 
            this.lb_Track_List.AllowDrop = true;
            this.lb_Track_List.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_Track_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Track_List.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_Track_List.FormattingEnabled = true;
            this.lb_Track_List.Location = new System.Drawing.Point(158, 89);
            this.lb_Track_List.Margin = new System.Windows.Forms.Padding(2);
            this.lb_Track_List.MinimumSize = new System.Drawing.Size(257, 132);
            this.lb_Track_List.Name = "lb_Track_List";
            this.lb_Track_List.Size = new System.Drawing.Size(335, 156);
            this.lb_Track_List.TabIndex = 14;
            this.lb_Track_List.SelectedIndexChanged += new System.EventHandler(this.lb_Track_List_SelectedIndexChanged);
            // 
            // lbl_Track_Time_End
            // 
            this.lbl_Track_Time_End.AutoSize = true;
            this.lbl_Track_Time_End.Font = new System.Drawing.Font("DigifaceWide", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Track_Time_End.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Track_Time_End.Location = new System.Drawing.Point(368, 15);
            this.lbl_Track_Time_End.Name = "lbl_Track_Time_End";
            this.lbl_Track_Time_End.Size = new System.Drawing.Size(125, 39);
            this.lbl_Track_Time_End.TabIndex = 13;
            this.lbl_Track_Time_End.Text = "00:00";
            this.lbl_Track_Time_End.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Track_Time_Start
            // 
            this.lbl_Track_Time_Start.AutoSize = true;
            this.lbl_Track_Time_Start.Font = new System.Drawing.Font("DigifaceWide", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Track_Time_Start.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Track_Time_Start.Location = new System.Drawing.Point(1, 15);
            this.lbl_Track_Time_Start.Name = "lbl_Track_Time_Start";
            this.lbl_Track_Time_Start.Size = new System.Drawing.Size(125, 39);
            this.lbl_Track_Time_Start.TabIndex = 12;
            this.lbl_Track_Time_Start.Text = "00:00";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volume.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Volume.Location = new System.Drawing.Point(497, 254);
            this.lbl_Volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(38, 18);
            this.lbl_Volume.TabIndex = 11;
            this.lbl_Volume.Text = "Ses";
            // 
            // tb_Volume
            // 
            this.tb_Volume.BackColor = System.Drawing.Color.Coral;
            this.tb_Volume.Location = new System.Drawing.Point(496, 89);
            this.tb_Volume.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Volume.Maximum = 100;
            this.tb_Volume.Name = "tb_Volume";
            this.tb_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_Volume.Size = new System.Drawing.Size(45, 163);
            this.tb_Volume.TabIndex = 10;
            this.tb_Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_Volume.Scroll += new System.EventHandler(this.tb_Volume_Scroll);
            // 
            // btn_Open
            // 
            this.btn_Open.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Open.Location = new System.Drawing.Point(349, 276);
            this.btn_Open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(144, 24);
            this.btn_Open.TabIndex = 6;
            this.btn_Open.Text = "Aç";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Previous.Location = new System.Drawing.Point(211, 276);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(65, 24);
            this.btn_Previous.TabIndex = 5;
            this.btn_Previous.Text = "Önceki";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Next.Location = new System.Drawing.Point(280, 276);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(65, 24);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Sonraki";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pb_Music
            // 
            this.pb_Music.Location = new System.Drawing.Point(8, 249);
            this.pb_Music.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Music.Name = "pb_Music";
            this.pb_Music.Size = new System.Drawing.Size(459, 19);
            this.pb_Music.TabIndex = 3;
            this.pb_Music.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Music_MouseDown);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Stop.Location = new System.Drawing.Point(145, 276);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(65, 24);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Durdur";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Pause.Location = new System.Drawing.Point(76, 276);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(65, 24);
            this.btn_Pause.TabIndex = 1;
            this.btn_Pause.Text = "Duraklat";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // bt_Play
            // 
            this.bt_Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Play.Location = new System.Drawing.Point(8, 276);
            this.bt_Play.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Play.Name = "bt_Play";
            this.bt_Play.Size = new System.Drawing.Size(65, 24);
            this.bt_Play.TabIndex = 0;
            this.bt_Play.Text = "Başlat";
            this.bt_Play.UseVisualStyleBackColor = true;
            this.bt_Play.Click += new System.EventHandler(this.bt_Play_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(339, 30);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(128, 39);
            this.player.TabIndex = 9;
            this.player.Visible = false;
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pb_Image.Image = global::Music.Properties.Resources._23;
            this.pb_Image.Location = new System.Drawing.Point(8, 111);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Image.MaximumSize = new System.Drawing.Size(146, 134);
            this.pb_Image.MinimumSize = new System.Drawing.Size(146, 134);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(146, 134);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 8;
            this.pb_Image.TabStop = false;
            this.pb_Image.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(602, 379);
            this.Controls.Add(this.gb_music);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gb_music.ResumeLayout(false);
            this.gb_music.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_music;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.ProgressBar pb_Music;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button bt_Play;
        private System.Windows.Forms.PictureBox pb_Image;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar tb_Volume;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.Label lbl_Track_Time_Start;
        private System.Windows.Forms.Label lbl_Track_Time_End;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lb_Track_List;
        private System.Windows.Forms.Label lbl_volume2;
    }
}


namespace UnoGameFinal
{
    partial class UnoLauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnoLauncherForm));
            this.b_Options = new System.Windows.Forms.Button();
            this.b_Back = new System.Windows.Forms.Button();
            this.b_Play = new System.Windows.Forms.Button();
            this.b_MusicToggle = new System.Windows.Forms.Button();
            this.b_Exit = new System.Windows.Forms.Button();
            this.l_Options = new System.Windows.Forms.Label();
            this.l_Play = new System.Windows.Forms.Label();
            this.l_Exit = new System.Windows.Forms.Label();
            this.l_MusicToggle = new System.Windows.Forms.Label();
            this.PB_Loading = new System.Windows.Forms.PictureBox();
            this.l_GameStartTimer = new System.Windows.Forms.Label();
            this.t_StartTimer = new System.Windows.Forms.Timer(this.components);
            this.PB_Wild1 = new System.Windows.Forms.PictureBox();
            this.PB_Wild2 = new System.Windows.Forms.PictureBox();
            this.lb_Music = new System.Windows.Forms.ListBox();
            this.b_AboutUs = new System.Windows.Forms.Button();
            this.l_MusicSelection = new System.Windows.Forms.Label();
            this.b_ShowWinners = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Wild1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Wild2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Options
            // 
            this.b_Options.BackColor = System.Drawing.Color.Transparent;
            this.b_Options.FlatAppearance.BorderSize = 0;
            this.b_Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Options.ForeColor = System.Drawing.Color.Transparent;
            this.b_Options.Image = global::UnoGameFinal.Properties.Resources.settings;
            this.b_Options.Location = new System.Drawing.Point(12, 12);
            this.b_Options.Name = "b_Options";
            this.b_Options.Size = new System.Drawing.Size(47, 42);
            this.b_Options.TabIndex = 0;
            this.b_Options.UseVisualStyleBackColor = false;
            this.b_Options.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_Options_MouseClick);
            this.b_Options.MouseLeave += new System.EventHandler(this.b_Options_MouseLeave);
            this.b_Options.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_Options_MouseMove);
            // 
            // b_Back
            // 
            this.b_Back.BackColor = System.Drawing.Color.Transparent;
            this.b_Back.FlatAppearance.BorderSize = 0;
            this.b_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Back.Image = global::UnoGameFinal.Properties.Resources.Back_removebg_preview1;
            this.b_Back.Location = new System.Drawing.Point(48, 12);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(49, 48);
            this.b_Back.TabIndex = 0;
            this.b_Back.UseVisualStyleBackColor = false;
            this.b_Back.Click += new System.EventHandler(this.b_Back_Click);
            this.b_Back.MouseLeave += new System.EventHandler(this.b_Back_MouseLeave);
            this.b_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_Back_MouseMove);
            // 
            // b_Play
            // 
            this.b_Play.BackColor = System.Drawing.Color.Transparent;
            this.b_Play.FlatAppearance.BorderSize = 0;
            this.b_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Play.Image = global::UnoGameFinal.Properties.Resources.G_Controller;
            this.b_Play.Location = new System.Drawing.Point(531, 248);
            this.b_Play.Name = "b_Play";
            this.b_Play.Size = new System.Drawing.Size(113, 43);
            this.b_Play.TabIndex = 0;
            this.b_Play.UseVisualStyleBackColor = false;
            this.b_Play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_Play_MouseClick);
            this.b_Play.MouseLeave += new System.EventHandler(this.b_Play_MouseLeave);
            this.b_Play.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_Play_MouseMove);
            // 
            // b_MusicToggle
            // 
            this.b_MusicToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_MusicToggle.BackColor = System.Drawing.Color.Transparent;
            this.b_MusicToggle.FlatAppearance.BorderSize = 0;
            this.b_MusicToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_MusicToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_MusicToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_MusicToggle.Image = global::UnoGameFinal.Properties.Resources.Music;
            this.b_MusicToggle.Location = new System.Drawing.Point(1113, 12);
            this.b_MusicToggle.Name = "b_MusicToggle";
            this.b_MusicToggle.Size = new System.Drawing.Size(75, 59);
            this.b_MusicToggle.TabIndex = 0;
            this.b_MusicToggle.UseVisualStyleBackColor = false;
            this.b_MusicToggle.Click += new System.EventHandler(this.b_MusicToggle_Click);
            this.b_MusicToggle.MouseLeave += new System.EventHandler(this.b_MusicToggle_MouseLeave);
            this.b_MusicToggle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_MusicToggle_MouseMove);
            // 
            // b_Exit
            // 
            this.b_Exit.BackColor = System.Drawing.Color.Transparent;
            this.b_Exit.FlatAppearance.BorderSize = 0;
            this.b_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Exit.Image = global::UnoGameFinal.Properties.Resources.Door;
            this.b_Exit.Location = new System.Drawing.Point(1113, 473);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(75, 60);
            this.b_Exit.TabIndex = 0;
            this.b_Exit.UseVisualStyleBackColor = false;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            this.b_Exit.MouseLeave += new System.EventHandler(this.b_Exit_MouseLeave);
            this.b_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_Exit_MouseMove);
            // 
            // l_Options
            // 
            this.l_Options.AutoSize = true;
            this.l_Options.BackColor = System.Drawing.Color.Transparent;
            this.l_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Options.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Options.Location = new System.Drawing.Point(16, 57);
            this.l_Options.Name = "l_Options";
            this.l_Options.Size = new System.Drawing.Size(50, 13);
            this.l_Options.TabIndex = 1;
            this.l_Options.Text = "Options";
            // 
            // l_Play
            // 
            this.l_Play.AutoSize = true;
            this.l_Play.BackColor = System.Drawing.Color.Transparent;
            this.l_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Play.Location = new System.Drawing.Point(566, 294);
            this.l_Play.Name = "l_Play";
            this.l_Play.Size = new System.Drawing.Size(42, 20);
            this.l_Play.TabIndex = 1;
            this.l_Play.Text = "Play";
            // 
            // l_Exit
            // 
            this.l_Exit.AutoSize = true;
            this.l_Exit.BackColor = System.Drawing.Color.Transparent;
            this.l_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_Exit.Location = new System.Drawing.Point(1119, 447);
            this.l_Exit.Name = "l_Exit";
            this.l_Exit.Size = new System.Drawing.Size(28, 13);
            this.l_Exit.TabIndex = 1;
            this.l_Exit.Text = "Exit";
            // 
            // l_MusicToggle
            // 
            this.l_MusicToggle.AutoSize = true;
            this.l_MusicToggle.BackColor = System.Drawing.Color.Transparent;
            this.l_MusicToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MusicToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_MusicToggle.Location = new System.Drawing.Point(1130, 74);
            this.l_MusicToggle.Name = "l_MusicToggle";
            this.l_MusicToggle.Size = new System.Drawing.Size(40, 13);
            this.l_MusicToggle.TabIndex = 1;
            this.l_MusicToggle.Text = "Music";
            // 
            // PB_Loading
            // 
            this.PB_Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Loading.Image = global::UnoGameFinal.Properties.Resources.Darkened_Uno_no_items_bg_high_resol;
            this.PB_Loading.Location = new System.Drawing.Point(0, 0);
            this.PB_Loading.Name = "PB_Loading";
            this.PB_Loading.Size = new System.Drawing.Size(1200, 545);
            this.PB_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Loading.TabIndex = 2;
            this.PB_Loading.TabStop = false;
            // 
            // l_GameStartTimer
            // 
            this.l_GameStartTimer.AutoSize = true;
            this.l_GameStartTimer.BackColor = System.Drawing.Color.Transparent;
            this.l_GameStartTimer.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_GameStartTimer.ForeColor = System.Drawing.Color.Transparent;
            this.l_GameStartTimer.Location = new System.Drawing.Point(580, 253);
            this.l_GameStartTimer.Name = "l_GameStartTimer";
            this.l_GameStartTimer.Size = new System.Drawing.Size(28, 26);
            this.l_GameStartTimer.TabIndex = 3;
            this.l_GameStartTimer.Text = "3";
            // 
            // t_StartTimer
            // 
            this.t_StartTimer.Interval = 1000;
            this.t_StartTimer.Tick += new System.EventHandler(this.t_StartTimer_Tick);
            // 
            // PB_Wild1
            // 
            this.PB_Wild1.BackColor = System.Drawing.Color.Transparent;
            this.PB_Wild1.Image = global::UnoGameFinal.Properties.Resources.Uno_Loading;
            this.PB_Wild1.Location = new System.Drawing.Point(170, 85);
            this.PB_Wild1.Name = "PB_Wild1";
            this.PB_Wild1.Size = new System.Drawing.Size(60, 63);
            this.PB_Wild1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Wild1.TabIndex = 4;
            this.PB_Wild1.TabStop = false;
            this.PB_Wild1.Visible = false;
            // 
            // PB_Wild2
            // 
            this.PB_Wild2.BackColor = System.Drawing.Color.Transparent;
            this.PB_Wild2.Image = global::UnoGameFinal.Properties.Resources.Uno_Loading;
            this.PB_Wild2.Location = new System.Drawing.Point(236, 85);
            this.PB_Wild2.Name = "PB_Wild2";
            this.PB_Wild2.Size = new System.Drawing.Size(60, 63);
            this.PB_Wild2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Wild2.TabIndex = 4;
            this.PB_Wild2.TabStop = false;
            this.PB_Wild2.Visible = false;
            // 
            // lb_Music
            // 
            this.lb_Music.BackColor = System.Drawing.Color.LightSalmon;
            this.lb_Music.ForeColor = System.Drawing.Color.Black;
            this.lb_Music.FormattingEnabled = true;
            this.lb_Music.Items.AddRange(new object[] {
            "Dreamer",
            "Journey"});
            this.lb_Music.Location = new System.Drawing.Point(541, 220);
            this.lb_Music.Name = "lb_Music";
            this.lb_Music.Size = new System.Drawing.Size(113, 30);
            this.lb_Music.TabIndex = 5;
            this.lb_Music.Visible = false;
            this.lb_Music.SelectedIndexChanged += new System.EventHandler(this.lb_Music_SelectedIndexChanged);
            // 
            // b_AboutUs
            // 
            this.b_AboutUs.BackColor = System.Drawing.Color.DarkSalmon;
            this.b_AboutUs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_AboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.b_AboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.b_AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_AboutUs.Location = new System.Drawing.Point(541, 282);
            this.b_AboutUs.Name = "b_AboutUs";
            this.b_AboutUs.Size = new System.Drawing.Size(113, 23);
            this.b_AboutUs.TabIndex = 6;
            this.b_AboutUs.Text = "AboutUs";
            this.b_AboutUs.UseVisualStyleBackColor = false;
            this.b_AboutUs.Visible = false;
            this.b_AboutUs.Click += new System.EventHandler(this.b_AboutUs_Click);
            this.b_AboutUs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_AboutUs_MouseMove);
            // 
            // l_MusicSelection
            // 
            this.l_MusicSelection.AutoSize = true;
            this.l_MusicSelection.BackColor = System.Drawing.Color.Transparent;
            this.l_MusicSelection.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MusicSelection.Location = new System.Drawing.Point(516, 182);
            this.l_MusicSelection.Name = "l_MusicSelection";
            this.l_MusicSelection.Size = new System.Drawing.Size(170, 22);
            this.l_MusicSelection.TabIndex = 7;
            this.l_MusicSelection.Text = "Select Music :)";
            this.l_MusicSelection.Visible = false;
            // 
            // b_ShowWinners
            // 
            this.b_ShowWinners.BackColor = System.Drawing.Color.DarkSalmon;
            this.b_ShowWinners.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_ShowWinners.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.b_ShowWinners.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.b_ShowWinners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ShowWinners.Location = new System.Drawing.Point(541, 333);
            this.b_ShowWinners.Name = "b_ShowWinners";
            this.b_ShowWinners.Size = new System.Drawing.Size(113, 23);
            this.b_ShowWinners.TabIndex = 6;
            this.b_ShowWinners.Text = "Show Winners";
            this.b_ShowWinners.UseVisualStyleBackColor = false;
            this.b_ShowWinners.Visible = false;
            this.b_ShowWinners.Click += new System.EventHandler(this.b_ShowWinners_Click);
            this.b_ShowWinners.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_ShowWinners_MouseMove);
            // 
            // UnoLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnoGameFinal.Properties.Resources.Darkened_Uno_no_items_bg_high_resol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 545);
            this.ControlBox = false;
            this.Controls.Add(this.l_MusicSelection);
            this.Controls.Add(this.b_ShowWinners);
            this.Controls.Add(this.b_AboutUs);
            this.Controls.Add(this.lb_Music);
            this.Controls.Add(this.l_GameStartTimer);
            this.Controls.Add(this.PB_Loading);
            this.Controls.Add(this.l_MusicToggle);
            this.Controls.Add(this.l_Exit);
            this.Controls.Add(this.l_Play);
            this.Controls.Add(this.l_Options);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.b_MusicToggle);
            this.Controls.Add(this.b_Play);
            this.Controls.Add(this.b_Back);
            this.Controls.Add(this.b_Options);
            this.Controls.Add(this.PB_Wild2);
            this.Controls.Add(this.PB_Wild1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnoLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uno Launcher";
            this.Load += new System.EventHandler(this.UNO_MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Wild1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Wild2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Options;
        private System.Windows.Forms.Button b_Back;
        private System.Windows.Forms.Button b_Play;
        private System.Windows.Forms.Button b_MusicToggle;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.Label l_Options;
        private System.Windows.Forms.Label l_Play;
        private System.Windows.Forms.Label l_Exit;
        private System.Windows.Forms.Label l_MusicToggle;
        private System.Windows.Forms.PictureBox PB_Loading;
        private System.Windows.Forms.Label l_GameStartTimer;
        private System.Windows.Forms.Timer t_StartTimer;
        private System.Windows.Forms.PictureBox PB_Wild1;
        private System.Windows.Forms.PictureBox PB_Wild2;
        private System.Windows.Forms.ListBox lb_Music;
        private System.Windows.Forms.Button b_AboutUs;
        private System.Windows.Forms.Label l_MusicSelection;
        private System.Windows.Forms.Button b_ShowWinners;
    }
}


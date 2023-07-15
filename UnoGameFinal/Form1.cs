using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using WMPLib;

namespace UnoGameFinal
{
    public partial class UnoLauncherForm : Form
    {
        bool ToggleMusicCheck = true;
        SoundPlayer SP = new SoundPlayer();

       
        WindowsMediaPlayer WP = new WindowsMediaPlayer();
        WindowsMediaPlayer WP2 = new WindowsMediaPlayer();
        public UnoLauncherForm()
        {
            InitializeComponent();
            t_StartTimer.Start();
        }

        private void UNO_MainForm_Load(object sender, EventArgs e)
        {
            SP.SoundLocation = @"F:\Mohammad\BUI 6\VP\UNO\Music\Dreamer.wav";
            SP.PlayLooping();

            b_Back.Visible = false;
            l_Options.Visible = false;
            l_Exit.Visible = false;
            l_Play.Visible = false;
            l_MusicToggle.Visible = false;

            Button btn_NormalMode = new Button();
            btn_NormalMode.Name = "b_Normal";
            btn_NormalMode.Text = "Normal Mode";
            btn_NormalMode.Font = new Font("Showcard Gothic", 12, FontStyle.Bold);
            btn_NormalMode.Size = new Size(270, 50);
            btn_NormalMode.Location = new Point(440, 170);
            btn_NormalMode.ForeColor = Color.Black;
            btn_NormalMode.BackColor = Color.FromArgb(0, 64, 64);
            btn_NormalMode.Click += new EventHandler(b_Normal_Click);
            btn_NormalMode.FlatAppearance.BorderSize = 0;
            btn_NormalMode.BackColor = Color.Transparent;
            btn_NormalMode.FlatStyle = FlatStyle.Flat;
            btn_NormalMode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_NormalMode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_NormalMode.MouseHover += new EventHandler(b_SimpleNormal_MouseHover);
            btn_NormalMode.MouseLeave += new EventHandler(b_SimpleNormal_MouseLeave);
            this.Controls.Add(btn_NormalMode);

            Button btn_SpecialMode = new Button();
            btn_SpecialMode.Name = "b_Special";
            btn_SpecialMode.Text = "Special Mode";
            btn_SpecialMode.Font = new Font("Showcard Gothic", 12, FontStyle.Bold);
            btn_SpecialMode.Size = new Size(270, 50);
            btn_SpecialMode.Location = new Point(440, 322);
            btn_SpecialMode.ForeColor = Color.Black;
            btn_SpecialMode.Click += new EventHandler(b_Special_Click);
            btn_SpecialMode.FlatAppearance.BorderSize = 0;
            btn_SpecialMode.BackColor = Color.Transparent;
            btn_SpecialMode.FlatStyle = FlatStyle.Flat;
            btn_SpecialMode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_SpecialMode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_SpecialMode.MouseHover += new EventHandler(b_SimpleSpecial_MouseHover);
            btn_SpecialMode.MouseLeave += new EventHandler(b_SimpleSpecial_MouseLeave);
            this.Controls.Add(btn_SpecialMode);

            Label lbl_ModeScreen = new Label();
            lbl_ModeScreen.Name = "l_Mode";
            lbl_ModeScreen.Text = "Select Mode";
            lbl_ModeScreen.Location = new Point(100, 10);
            lbl_ModeScreen.Font = new Font("Showcard Gothic", 36, FontStyle.Bold);
            lbl_ModeScreen.ForeColor = SystemColors.HighlightText;
            lbl_ModeScreen.BackColor = Color.Transparent;
            lbl_ModeScreen.Size = new Size(360, 90);
            this.Controls.Add(lbl_ModeScreen);



            Label lbl_ExitScreen = new Label();
            lbl_ExitScreen.Name = "l_ExitScreen";
            lbl_ExitScreen.Text = "Are you sure you want to Exit?";
            lbl_ExitScreen.Location = new Point(170, 10);
            lbl_ExitScreen.Font = new Font("Showcard Gothic", 24, FontStyle.Bold);
            lbl_ExitScreen.ForeColor = SystemColors.HighlightText;
            lbl_ExitScreen.BackColor = Color.Transparent;
            lbl_ExitScreen.Size = new Size(600, 90);
            this.Controls.Add(lbl_ExitScreen);

            Button btn_ExitYes = new Button();
            btn_ExitYes.Name = "b_ExitYes";
            btn_ExitYes.Text = "Yes";
            btn_ExitYes.Font = new Font("Showcard Gothic", 12, FontStyle.Bold);
            btn_ExitYes.Size = new Size(345, 65);
            btn_ExitYes.Location = new Point(400, 200);
            btn_ExitYes.ForeColor = SystemColors.HighlightText;
            btn_ExitYes.BackColor = Color.FromArgb(0, 64, 64);
            btn_ExitYes.Click += new EventHandler(b_ExitYes_Click);
            btn_ExitYes.FlatAppearance.BorderSize = 0;
            btn_ExitYes.BackColor = Color.Transparent;
            btn_ExitYes.FlatStyle = FlatStyle.Flat;
            btn_ExitYes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_ExitYes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_ExitYes.MouseHover += new EventHandler(b_ExitYes_MouseHover);
            btn_ExitYes.MouseLeave += new EventHandler(b_ExitYes_MouseLeave);
            this.Controls.Add(btn_ExitYes);

            Button btn_ExitNo = new Button();
            btn_ExitNo.Name = "b_ExitNo";
            btn_ExitNo.Text = "No";
            btn_ExitNo.Font = new Font("Showcard Gothic", 12, FontStyle.Bold);
            btn_ExitNo.Size = new Size(345, 65);
            btn_ExitNo.Location = new Point(200, 200);
            btn_ExitNo.ForeColor = SystemColors.HighlightText;
            btn_ExitNo.Click += new EventHandler(b_ExitNo_Click);
            btn_ExitNo.FlatAppearance.BorderSize = 0;
            btn_ExitNo.BackColor = Color.Transparent;
            btn_ExitNo.FlatStyle = FlatStyle.Flat;
            btn_ExitNo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_ExitNo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_ExitNo.MouseHover += new EventHandler(b_ExitNo_MouseHover);
            btn_ExitNo.MouseLeave += new EventHandler(b_ExitNo_MouseLeave);
            this.Controls.Add(btn_ExitNo);


            btn_NormalMode.Visible = false;
            btn_SpecialMode.Visible = false;
            lbl_ModeScreen.Visible = false;
            lbl_ExitScreen.Visible = false;
            btn_ExitNo.Visible = false;
            btn_ExitYes.Visible = false;
        }

        private void HideScreen(string S)
        {
            if (S == "Play")
            {
                b_Play.Visible = false;
                b_Options.Visible = false;
                b_Exit.Visible = false;

                this.Controls["b_Normal"].Visible = true;
                this.Controls["b_Special"].Visible = true;
                this.Controls["l_Mode"].Visible = true;
                b_Back.Visible = true;
            }
            else if (S == "Normal Mode" || S == "Special Mode")
            {
                this.Controls["b_Back"].Visible = false;
                this.Controls["b_Normal"].Visible = false;
                this.Controls["b_Special"].Visible = false;
                this.Controls["l_Mode"].Visible = false;
            }
            else if (S == "Back")
            {
                b_Back.Visible = false;
                this.Controls["b_Normal"].Visible = false;
                this.Controls["b_Special"].Visible = false;
                this.Controls["l_Mode"].Visible = false;
                lb_Music.Visible = false;
                b_AboutUs.Visible = false;
                b_ShowWinners.Visible = false;
                l_MusicSelection.Visible = false;

                b_Play.Visible = true;
                b_Options.Visible = true;
                b_Exit.Visible = true;
            }
            else if (S == "Exit No")
            {
                b_Play.Visible = true;
                b_Options.Visible = true;
                b_Exit.Visible = true;
                this.Controls["b_ExitYes"].Visible = false;
                this.Controls["b_ExitNo"].Visible = false;
                this.Controls["l_ExitScreen"].Visible = false;
            }
            else if (S == "Exit")
            {
                b_Play.Visible = false;
                b_Options.Visible = false;
                b_Exit.Visible = false;

                this.Controls["l_ExitScreen"].Visible = true;
                this.Controls["b_ExitYes"].Visible = true;
                this.Controls["b_ExitNo"].Visible = true;
            }
            else if(S == "Options")
            {
                b_Play.Visible = false;
                b_Options.Visible = false;
                b_Exit.Visible = false;

                b_Back.Visible = true;
                lb_Music.Visible = true;
                b_AboutUs.Visible = true;
                b_ShowWinners.Visible = true;
                l_MusicSelection.Visible = true;
            }
        }

        private void b_Options_MouseLeave(object sender, EventArgs e)
        {
            l_Options.Visible = false;
            b_Options.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\settings.png");
        }

        private void b_Play_MouseLeave(object sender, EventArgs e)
        {
            b_Play.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\G_Controller.png");
            l_Play.Visible = false;
        }

        private void b_Exit_MouseLeave(object sender, EventArgs e)
        {
            l_Exit.Visible = false;
            b_Exit.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Door.png");
        }

        private void b_SimpleNormal_MouseHover(object sender, EventArgs e)
        {
            Play_ArcadeEffectSound();
            this.Controls["b_Normal"].ForeColor = Color.BlueViolet;
            this.Controls["b_Normal"].Font = new Font("Showcard Gothic", 24, FontStyle.Bold);

            Button btn = (Button)sender;
            PB_Wild1.Location = new Point(btn.Location.X - 60, btn.Location.Y);
            PB_Wild2.Location = new Point(btn.Location.X + btn.Size.Width , btn.Location.Y);
            PB_Wild1.Visible = true;
            PB_Wild2.Visible = true;
        }

        private void b_SimpleSpecial_MouseHover(object sender, EventArgs e)
        {
            Play_ArcadeEffectSound();
            this.Controls["b_Special"].ForeColor = Color.BlueViolet;
            this.Controls["b_Special"].Font = new Font("Showcard Gothic", 24, FontStyle.Bold);

            Button btn = (Button)sender;
            PB_Wild1.Location = new Point(btn.Location.X - 60, btn.Location.Y);
            PB_Wild2.Location = new Point(btn.Location.X + btn.Size.Width, btn.Location.Y);
            PB_Wild1.Visible = true;
            PB_Wild2.Visible = true;
        }

        private void b_SimpleNormal_MouseLeave(object sender, EventArgs e)
        {
            this.Controls["b_Normal"].ForeColor = Color.Black;
            this.Controls["b_Normal"].Font = new Font("Showcard Gothic", 12, FontStyle.Bold);

            PB_Wild1.Visible = false;
            PB_Wild2.Visible = false;
        }

        private void b_SimpleSpecial_MouseLeave(object sender, EventArgs e)
        {
            this.Controls["b_Special"].ForeColor = Color.Black;
            this.Controls["b_Special"].Font = new Font("Showcard Gothic", 12, FontStyle.Bold);

            PB_Wild1.Visible = false;
            PB_Wild2.Visible = false;
        }

        private void b_Back_MouseLeave(object sender, EventArgs e)
        {
            b_Back.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Back-removebg-preview.png");
        }

        private void b_MusicToggle_Click(object sender, EventArgs e)
        {
            if (ToggleMusicCheck)
            {
                SP.Stop();
                ToggleMusicCheck = false;
                Play_SciFiWaterSound();
                b_MusicToggle.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Music_Crossed.png");
            }
            else
            {
                SP.PlayLooping();
                ToggleMusicCheck = true;
                Play_SciFiWaterSound();
                b_MusicToggle.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Music.png");
            }
        }

        private void b_ExitYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ExitNo_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            this.BackgroundImage = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BG\Darkened Uno no items bg high resol.jpg");
            HideScreen("Exit No");
        }

        private void b_ExitYes_MouseHover(object sender, EventArgs e)
        {
            Play_ArcadeEffectSound();
            this.Controls["b_ExitYes"].ForeColor = Color.BlueViolet;
            this.Controls["b_ExitYes"].Font = new Font("Showcard Gothic", 24, FontStyle.Bold);
        }

        private void b_ExitYes_MouseLeave(object sender, EventArgs e)
        {
            this.Controls["b_ExitYes"].ForeColor = SystemColors.HighlightText;
            this.Controls["b_ExitYes"].Font = new Font("Showcard Gothic", 12, FontStyle.Bold);
        }

        private void b_ExitNo_MouseHover(object sender, EventArgs e)
        {
            Play_ArcadeEffectSound();
            this.Controls["b_ExitNo"].ForeColor = Color.BlueViolet;
            this.Controls["b_ExitNo"].Font = new Font("Showcard Gothic", 24, FontStyle.Bold);
        }

        private void b_ExitNo_MouseLeave(object sender, EventArgs e)
        {
            this.Controls["b_ExitNo"].ForeColor = SystemColors.HighlightText;
            this.Controls["b_ExitNo"].Font = new Font("Showcard Gothic", 12, FontStyle.Bold);
        }

        private void b_Special_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            UnoWindow U_W = new UnoWindow(this, "Special");
            U_W.Show();
            this.Hide();
        }

        private void b_Normal_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            UnoWindow U_W = new UnoWindow(this, "Normal");
            U_W.Show();
            this.Hide();

            //HideScreen(this.Controls["b_Normal"].Text);
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            this.BackgroundImage = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BG\Darkened Uno no items bg high resol.jpg");
            HideScreen("Back");
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            this.BackgroundImage = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BG\203484.jpg");
            HideScreen("Exit");
        }

        private void Play_SciFiWaterSound()
        {
            WP2.URL = @"F:\Mohammad\BUI 6\VP\UNO\Sound Effects\mixkit-water-sci-fi-bleep-902.wav";
            WP2.controls.play();
        }

        private void Play_ArcadeEffectSound()
        {
            WP.URL = @"F:\Mohammad\BUI 6\VP\UNO\Sound Effects\mixkit-arcade-game-jump-coin-216.wav";
            WP.controls.play();
        }

        private void b_MusicToggle_MouseLeave(object sender, EventArgs e)
        {
            if (ToggleMusicCheck)
            {
                b_MusicToggle.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Music.png");
                l_MusicToggle.Visible = false;
            }
            else
            {
                b_MusicToggle.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Music_Crossed.png");
            }
            l_MusicToggle.Visible = false;
        }

        private void b_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            l_Exit.Visible = true;
            b_Exit.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Door_Lightened.png");
        }

        private void b_Play_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            b_Play.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\G_Controller Ligthened.png");
            l_Play.Visible = true;
        }

        private void b_Options_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            l_Options.Visible = true;
            b_Options.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Setting_Lightened.png");
        }

        private void b_Options_MouseClick(object sender, MouseEventArgs e)
        {
            Play_SciFiWaterSound();
            HideScreen("Options");
        }

        private void b_Play_MouseClick(object sender, MouseEventArgs e)
        {
            Play_SciFiWaterSound();
            HideScreen("Play");
            this.BackgroundImage = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BG\Uno with items bg high resol.jpg");
        }

        private void b_MusicToggle_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            l_MusicToggle.Visible = true;
            if (ToggleMusicCheck)
            {
                b_MusicToggle.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Music_Lightened.png");
            }
            else
            {
                b_MusicToggle.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Music_Crossed_Lightened.png");
            }
        }

        private void b_Back_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            b_Back.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\imageedit_15_5479235880.png");
        }

        private void t_StartTimer_Tick(object sender, EventArgs e)
        {
            if (l_GameStartTimer.Text == "3" || l_GameStartTimer.Text == "2")
            {
                l_GameStartTimer.Text = (Convert.ToInt32(l_GameStartTimer.Text) - 1).ToString();
            }
            else if (l_GameStartTimer.Text == "Let's Start !!!")
            {
                t_StartTimer.Stop();
                PB_Loading.Visible = false;
                l_GameStartTimer.Visible = false;
                this.BackgroundImage = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BG\Darkened Uno no items bg high resol.jpg");
            }
            else
            {
                l_GameStartTimer.Location = new Point(l_GameStartTimer.Location.X - 60, l_GameStartTimer.Location.Y);
                l_GameStartTimer.Font = new Font(l_GameStartTimer.Font.FontFamily, 12, l_GameStartTimer.Font.Style);
                l_GameStartTimer.Text = "Let's Start !!!";
            }
        }

        private void lb_Music_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = lb_Music.SelectedItem.ToString();
            SP.SoundLocation = @"F:\Mohammad\BUI 6\VP\UNO\Music\" + s + ".wav";
            if(ToggleMusicCheck)
                SP.PlayLooping();    
        }

        private void b_AboutUs_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            MessageBox.Show("Uno game made by:\n1.Mian Mohammad Shah\n2.Danyal Abbas\n3.Muhammad Harris Imran\n4.Muhammad Ullah Baig\nMade for VP Project");
        }

        private void b_ShowWinners_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            WinnerShower WS = new WinnerShower(this);
            WS.Show();
            this.Hide();
        }

        private void b_AboutUs_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
        }

        private void b_ShowWinners_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
        }
    }
}

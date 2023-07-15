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
    public partial class WinnerShower : Form
    {
        WindowsMediaPlayer WP = new WindowsMediaPlayer();
        WindowsMediaPlayer WP2 = new WindowsMediaPlayer();

        Form Parent = new Form();
        public WinnerShower(Form P)
        {
            Parent = P;
            InitializeComponent();
        }

        private void WinnerShower_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universDataSet.Winners' table. You can move, or remove it, as needed.
            this.winnersTableAdapter1.Fill(this.universDataSet.Winners);
        }

        private void WinnerShower_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show();
        }

        private void b_ExitThisForm_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            b_ExitThisForm.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Door_Lightened.png");
        }

        private void b_ExitThisForm_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            this.Close();
        }

        private void b_ExitThisForm_MouseLeave(object sender, EventArgs e)
        {
            b_ExitThisForm.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Door.png");
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

        private void DGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

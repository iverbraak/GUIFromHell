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
namespace GUIFromHell
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer bobMusic = new System.Media.SoundPlayer();
        List<Color> colorList;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            bobMusic.SoundLocation = "BobRoss.wav";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bobMusic.PlayLooping();

            colorList = new List<Color>();
            colorList.Add(Color.Aqua);
            colorList.Add(Color.Coral);
            colorList.Add(Color.Fuchsia);
            colorList.Add(Color.Green);
            colorList.Add(Color.Lime);
            colorList.Add(Color.Red);
            colorList.Add(Color.White);
            colorList.Add(Color.Yellow);

            int colorCreated = rand.Next(0, colorList.Count);
            BackColor = colorList[colorCreated];
            menuStrip1.BackColor = BackColor; 
        }

        //makes it so that the user can't check no
        private void noCheck_MouseClick(object sender, MouseEventArgs e)
        {
            noCheck.Checked = false;
            yesCheck.Checked = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void letsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}

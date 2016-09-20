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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //when ok is clicked, adds a form 3
            Form3 anotherForm = new Form3();
            anotherForm.Show();
        }

        /// <summary>
        ///every time the user moves their mouse, another form will pop up 
        /// </summary>
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Form2 annoyingForms = new Form2();
            annoyingForms.Show();
        }
    }
}

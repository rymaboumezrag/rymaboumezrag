using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            DialogResult rep = MessageBox.Show("dernier button Cliquez :OK", "nformation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            DialogResult rep = MessageBox.Show("bonjour...!", "salutation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

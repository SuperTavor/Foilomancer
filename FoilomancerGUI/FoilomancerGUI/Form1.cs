using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoilomancerGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadModToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadmodmenuButton_Click(object sender, EventArgs e)
        {
            
        }

        private void packModMenuBtn_Click(object sender, EventArgs e)
        {
            packForm packForm = new packForm();
            packForm.ShowDialog();
        }

        private void packModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            packForm packForm = new packForm();
            packForm.ShowDialog();
        }
    }
}

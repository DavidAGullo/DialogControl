using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "docx files (*.docx)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.ShowDialog();
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.Items.Add(openFileDialog1.FileName);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Exit", "Are you sure", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            

        }
    }
}

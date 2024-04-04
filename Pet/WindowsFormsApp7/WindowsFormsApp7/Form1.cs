using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void пройтиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 GOAT = new Form2();
            GOAT.Show();
            Hide();
        }

        private void результатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Result = new Form8();
            Result.Show();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

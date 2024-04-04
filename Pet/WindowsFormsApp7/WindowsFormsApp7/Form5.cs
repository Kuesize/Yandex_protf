using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 Fourth = new Form6();
            Fourth.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Никем")
            {
                Class1.k = Class1.k + 1;
            }
            else
                Class1.k = Class1.k + 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

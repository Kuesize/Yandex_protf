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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 Результат = new Form8();
            Результат.Show();
            Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Class1.k = Class1.k + 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Class1.k = Class1.k + 0;
        }
    }
}

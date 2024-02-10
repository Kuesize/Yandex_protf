using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fromX = int.Parse(X1.Text);
            int toX = int.Parse(X2.Text);
            int fromY = int.Parse(Y1.Text);
            int toY = int.Parse(Y2.Text);

            if (fromX > toX)
            {
                MessageBox.Show("интервал должен быть от меньшего к большему");
                X1.Text = "";
                X2.Text = "";
            }


            for (int x = fromX; x <= toX; x++)
            {
                for (int y = fromY; y <= toY; y++)
                {
                    listBox1.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                if (listBox1.SelectedItem == "ЭПЛ_ДЖЕК")
                {
                    textBox1.BackColor = System.Drawing.Color.Orange;
                }
                else if (listBox1.SelectedItem == "РЭИНБОУ_ДЭШ") 
                {
                    textBox1.BackColor = System.Drawing.Color.Blue;
                }
                else if (listBox1.SelectedItem == "ПИНКИ_ПАЙ")
                {
                    textBox1.BackColor = System.Drawing.Color.Pink;
                }
                else if (listBox1.SelectedItem == "ИСКОРКА")
                {
                    textBox1.BackColor = System.Drawing.Color.Purple;
                }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ЭПЛ_ДЖЕК");
            listBox1.Items.Add("РЭИНБОУ_ДЭШ");
            listBox1.Items.Add("ПИНКИ_ПАЙ");
            listBox1.Items.Add("ИСКОРКА");
        }
    }
}

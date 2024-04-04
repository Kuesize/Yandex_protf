using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp7
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            label2.Text = Properties.Settings.Default.Savesq;
            label3.Text = Properties.Settings.Default.Savesq;

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label2.Text = Form2.passingText;
            label3.Text = Convert.ToString(Class1.k);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Savesq = label2.Text;
            Properties.Settings.Default.Savesq = label3.Text;
            Properties.Settings.Default.Save();
            Form1 Start = new Form1();
            Start.Show();
            Hide();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtsave = label2.Text + Environment.NewLine + label1.Text + label3.Text;
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Filter = "Блокнот|*.txt";
            if (sfd1.ShowDialog() == DialogResult.OK) 
            {
                using (StreamWriter q = new StreamWriter(sfd1.FileName)) 
                {
                    q.Write(txtsave);
                }
            }
            MessageBox.Show("Ваш результат сохранен");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
 }

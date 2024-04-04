using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp7
{
    
        public partial class Form6 : Form
    {
        string[] el = { "Смотритель", "Смотритель", "Смотритель", "Смотритель", "Смотритель", "Смотритель", "Смотритель" };
        public Form6()
        {
            InitializeComponent();
            foreach (string s in el) 
            {
                listBox1.Items.Add(s);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("Вопрос №4: Кто, без сомнения, самый важный человек в Убежище 101? Кто защищает нас от суровой атомной пустоши, кому мы обязаны всем, что имеем, даже нашими жизнями?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 Пятый = new Form7();
            Пятый.Show();
            Close();
            if (el.Length > 0 && el[0] == "Смотритель") 
            {
                Class1.k += 1;
            }
            else
                Class1.k += 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count + 1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex < el.Length + 1)
                {
                    string temp = el[selectedIndex];
                    el[selectedIndex] = el[selectedIndex - 1];
                    el[selectedIndex - 1] = temp;

                    string tempListBox = listBox1.Items[selectedIndex].ToString();
                    listBox1.Items[selectedIndex] = listBox1.Items[selectedIndex - 1];
                    listBox1.Items[selectedIndex - 1] = tempListBox;

                    listBox1.SelectedIndex = selectedIndex - 1;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex < el.Length - 1)
                {
                    string temp = el[selectedIndex];
                    el[selectedIndex] = el[selectedIndex + 1];
                    el[selectedIndex + 1] = temp;

                    string tempListBox = listBox1.Items[selectedIndex].ToString();
                    listBox1.Items[selectedIndex] = listBox1.Items[selectedIndex + 1];
                    listBox1.Items[selectedIndex + 1] = tempListBox;

                    listBox1.SelectedIndex = selectedIndex + 1;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

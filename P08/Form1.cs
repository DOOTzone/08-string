using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Split();
            if (checkBox1.Checked)
            {
                label1.Text = text.Length.ToString();
            }
            if (checkBox2.Checked) {
                string max_slovo = text[0];
                foreach(string s in text)
                {
                    if (s.Length > max_slovo.Length)
                    {
                        max_slovo = s;
                    }
                }
                label2.Text = max_slovo;
            }
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Black;
            }
            else
                textBox1.ForeColor = Color.Red;
            if (radioButton4.Checked)
            {
                textBox1.Font = new Font( textBox1.Font.Name,12);
            }
            else
                textBox1.Font = new Font(textBox1.Font.Name, 20);
        }
    }
}

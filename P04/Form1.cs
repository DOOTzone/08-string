using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string text;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            text = textBox1.Text;
            while(i<text.Length)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    text = text.Remove(i, 1);
                }
                else
                    i++;
            }
            textBox2.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = text.Replace("*", "");
            textBox2.Text = text;
        }
    }
}

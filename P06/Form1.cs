using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char je_ = text[0];
            int x = 1;
            while(x<text.Length)
            {
                if (text[x] == ' '&&je_==' ')
                {
                       text = text.Remove(x, 1);
                }
                else {
                    je_ = text[x];
                    x++;
                     }
            }
            textBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            textBox1.Text = text;
        }
    }
}

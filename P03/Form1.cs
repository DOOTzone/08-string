using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k=0;
            bool kex = false;
            string text = textBox1.Text;
            foreach (char p in textBox1.Text)
            {
                if (p >= '0' && p <= '9')
                {
                    k = Convert.ToInt32(p-48);
                    kex = true;
                    break;
                }
            
            }
            label1.Text = k.ToString();
            if (kex)
            {
                
                
                    if (k < text.Length)
                    {
                        text = text.Remove(text.Length - k);
                    }
                    else
                        text = "";
                
            }
            if (kex)
                textBox2.Text = text;
            else
                textBox2.Text = "V zadaném stringu neexistuje číslo";
        }
    }
}

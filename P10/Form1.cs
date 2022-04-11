using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
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
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            string[] slova = text.Split(' ');
            for(int v = 0; v < slova.Length; v++)
            {
                foreach(char c in slova[v])
                {
                    if (c >= '0' && c <= '9')
                    {
                        listBox1.Items.Add(slova[v]);
                        break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            string[] slova = text.Split(' ');
            label2.Text = Convert.ToString(slova.Length);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int pocet = 0;
            text = text.Trim();
            string[] slova = text.Split(' ');
            for (int i = 0; i < slova.Length; i++)
            {
                if (slova[i] != "")
                    pocet++;
            }
            label2.Text = pocet.ToString();
        }
    }
}

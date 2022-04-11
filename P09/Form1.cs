using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vety = textBox1.Lines.ToArray();
            string novaVeta="";
            for(int i =0;i<textBox1.Lines.Length;i++)
            {
                if (checkBox1.Checked)
                {
                    char pismeno = vety[i][0];
                    string veta_s = vety[i].Substring(1,vety[i].Length-1);
                    pismeno = char.ToUpper(pismeno);
                    label1.Text = pismeno.ToString();
                    novaVeta += pismeno+veta_s;
                }
                    if (checkBox2.Checked)
                {
                    char dot = (novaVeta[novaVeta.Length - 1]);
                    if (dot != '.')
                        novaVeta += ".";
                }
                    if(i+1!=textBox1.Lines.Length)
                novaVeta+=Environment.NewLine;
                MessageBox.Show(novaVeta, "nova veta");
            }
            textBox1.Text = novaVeta;
        }
    }
}

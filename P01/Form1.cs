using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůý"; 
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            int pocet_sa = 0;
            int pocet_so = 0;
            int nepismeno = 0;
            string text = textBox1.Text;
            foreach(char pismeno in text)
            {
                if (samohlasky.Contains(pismeno))
                {
                    pocet_sa++;
                }
                else
                {
                    if (souhlasky.Contains(pismeno))
                    {
                        pocet_so++;
                    }
                }
            }
            nepismeno = text.Length - (pocet_sa + pocet_so);
            label4.Text = pocet_sa.ToString();
            label5.Text = pocet_so.ToString();
            label6.Text = nepismeno.ToString();
        }
    }
}

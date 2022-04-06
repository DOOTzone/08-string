using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            string morse_text = "";
            foreach(char c in text)
            {
                if (c != ' ')
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (c == alphabet[i])
                        {
                            morse_text += morse[i] + " ";
                            break;
                        }
                    }
                }
                else
                    morse_text += " / ";
            }
            textBox1.Text = morse_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "";
            string[] morse_text = (textBox1.Text).Split();
            foreach (string c in morse_text)
            {
                if (c != "/")
                {
                    for (int i = 0; i < morse.Length; i++)
                    {
                        if (c == morse[i])
                        {
                            text += alphabet[i];
                            break;
                        }
                    }
                }
                else
                    text += " ";
            }
            
            textBox2.Text = text;
        }
    }
}

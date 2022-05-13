using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP0513_5_cal_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string x1 = "";
            string x2 = "";
            int R = 0;
            for(int i = 0; i < IsOperator(textBox1.Text); i++)
            {
                x1 = x1 + textBox1.Text[i];
            }
            for(int i = IsOperator(textBox1.Text)+1; i < textBox1.Text.Length;i++ )
            {
                x2 = x2 + textBox1.Text[i];
            }
            switch (textBox1.Text[IsOperator(textBox1.Text)].ToString())
            {
                case "+":
                    R = int.Parse(x1) + int.Parse(x2);
                    break;
                case "-":
                    R = int.Parse(x1) - int.Parse(x2);
                    break;
                case "*":
                    R = int.Parse(x1) * int.Parse(x2);
                    break;
                case "/":
                    R = int.Parse(x1) / int.Parse(x2);
                    break;
                default:
                    break;
            }
            textBox1.Clear();
            textBox1.Text = textBox1.Text + R;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        public int IsOperator(string s)
        {
            int x = 0;
            for(int i =0; i < s.Length; i++)
            {
                if (s[i].ToString() == "+" || (s[i].ToString() == "-" || (s[i].ToString() == "*" || (s[i].ToString() == "/"))))
                    x = i;
            }
            return x;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            textBox1.TextAlign = HorizontalAlignment.Right;
            
        }
    }
}

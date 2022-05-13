using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP0511_3_calculator
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "/";
            count++;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int iDigit1, iDigit2;
            iDigit1=int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox2.Text);

            textBox3.Text=(iDigit1 + iDigit2).ToString();
            label4.Text = "+";*/
            label4.Text = "+";
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "*";
            count++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "?";
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label4.Text = "?";
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            count = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count>0)
                textBox4.Text = textBox4.Text + 1;
            else textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(count > 0)
                textBox4.Text = textBox4.Text + 2;
            else textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 3;
            else textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 4;
            else textBox1.Text = textBox1.Text + 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 5;
            else textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 6;
            else textBox1.Text = textBox1.Text + 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 7;
            else textBox1.Text = textBox1.Text + 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 8;
            else textBox1.Text = textBox1.Text + 8;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 9;
            else textBox1.Text = textBox1.Text + 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (count > 0)
                textBox4.Text = textBox4.Text + 0;
            else textBox1.Text = textBox1.Text + 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int iDigit1, iDigit2;
            iDigit1=int.Parse(textBox1.Text);
            iDigit2 = int.Parse(textBox4.Text);

            if(label4.Text=="+")
                textBox3.Text=(iDigit1 + iDigit2).ToString();
            else if(label4.Text=="-")
                textBox3.Text = (iDigit1 - iDigit2).ToString();
            else if (label4.Text == "*")
                textBox3.Text = (iDigit1 * iDigit2).ToString();
            else if (label4.Text == "/")
                textBox3.Text = (iDigit1 / iDigit2).ToString();
            
            

        }
        /*public int IsOperator (string s)
        {
            int x = 0;
            if (s == "+")
                x = 1;
            else if (s == "-")
                x = 2;
            else if (s == "*")
                x = 3;
            else if (s == "/")
                x = 4;
            else

                return 1;
        }*/

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            int x = int.Parse(textBox1.Text);
            int nsum = 0;
            for(int i =0;i<x+1;i++)
            {
                nsum += i;
            }
            textBox3.Text = textBox3.Text + nsum;
        }
    }
}

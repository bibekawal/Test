using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_calculator
{
    public partial class Form1 : Form
    {
        private String first = "";
        private String first1 = "";
        double Result = 0;
       


        // private String opused= "";
        char opused;
        String opr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            

            first = textBox1.Text;
            textBox1.ResetText();
            opused = '+';// Convert.ToChar(btnadd.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            first = textBox1.Text;
            textBox1.ResetText();
            opused = '-';
        }

        private void button13_Click(object sender, EventArgs e)
        {
        
            first = textBox1.Text;
           textBox1.ResetText();
            opused = '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            first = textBox1.Text;
            textBox1.ResetText();
            opused = '/';
    }

    private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double result = 0;
            double result1 = 0;

            //  txtbox.Text = opused.ToString();
            switch (opused)
            {
                case '+':
                    result = float.Parse(first) + float.Parse(textBox1.Text);
                    //  txtbox.ResetText();
                    //txtbox.Text = result.ToString();
                    break;
                case '-':
                    result = float.Parse(first) - float.Parse(textBox1.Text);

                    break;
                case '*':
                    result = float.Parse(first) * float.Parse(textBox1.Text);
                    break;
                case '/':
                    result = float.Parse(first) / float.Parse(textBox1.Text);
                    break;

                case 's':
                {
                        double val = Convert.ToDouble(first1);
                        result = (3.14 / 180) * (Math.Sin(val));




                    }
                    break;
                case 'c':
                    {
                        double val = double.Parse(first);
                        result = (3.14 / 180) * (Math.Cos(val));


                    }
                    break;

                case 't':
                    {


                        double val = double.Parse(first);
                        result = (3.14 / 180) * (Math.Tan(val));


                    }
                    break;
                case '%':
                    result = float.Parse(first) % float.Parse(textBox1.Text);
                    break;
            }

            //  txtbox.ResetText();
            textBox1.Text = result.ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Sin";
           first1 = textBox1.Text;
            textBox1.ResetText();
            opused = 's';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "cos";
            first = textBox1.Text;
            textBox1.ResetText();
            opused = 'c';

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tan";
            first= textBox1.Text;
            textBox1.ResetText();
            opused = 't';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3.14";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.ResetText();
            opused = '%';
        }
    }
    }


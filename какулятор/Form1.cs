using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace какулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Zero zero = new Zero();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void buttonNumPress(string a)
        {
            if (zero.Num1 != "" && zero.Action == "")
            {

            }
            else
            {
                if (zero.Num != "0" && a == "0")
                {
                    zero.Num += "0";
                }
                else if (zero.Num == "0")
                {
                    zero.Num = a;
                }
                else
                {
                    zero.Num += a;
                }
            }
            textBox1.Text = zero.Num;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void button_number1_Click(object sender, EventArgs e)
        {
            buttonNumPress("1");
        }

        private void button_number2_Click(object sender, EventArgs e)
        {
            buttonNumPress("2");
        }

        private void button_number3_Click(object sender, EventArgs e)
        {
            buttonNumPress("3");
        }

        private void button_number4_Click(object sender, EventArgs e)
        {
            buttonNumPress("4");
        }

        private void button_number5_Click(object sender, EventArgs e)
        {
            buttonNumPress("5");
        }

        private void button_number6_Click(object sender, EventArgs e)
        {
            buttonNumPress("6");
        }

        private void button_number7_Click(object sender, EventArgs e)
        {
            buttonNumPress("7");
        }

        private void button_number8_Click(object sender, EventArgs e)
        {
            buttonNumPress("8");
        }

        private void button_number9_Click(object sender, EventArgs e)
        {
            buttonNumPress("9");
        }

        private void button_number0_Click(object sender, EventArgs e)
        {
            buttonNumPress("0");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (zero.Num1 == "" && zero.Num == "")
            {

            }
            else if (zero.Num1 == "" && zero.Num != "")
            {
                zero.Num1 = zero.Num;
                zero.Num = "";
                zero.Action = "+";
                textBox1.Text = zero.Num;
            }
            else if (zero.Num == "")
            {
                zero.Action = "+";
                textBox1.Text = zero.Num1 + zero.Action;
            }
            else
            {
                zero.Result();
                if (Convert.ToInt32(zero.Num1) > 999999999 || Convert.ToInt32(zero.Num1) < -999999999)
                {
                    zero.Action = "";
                    zero.Num1 = "";
                    textBox1.Text = "Ошибка";
                }
                else
                {
                    textBox1.Text = zero.Num1;
                }
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (zero.Num1 == "" && zero.Num == "")
            {

            }
            else if (zero.Num1 == "" && zero.Num != "")
            {
                zero.Num1 = zero.Num;
                zero.Num = "";
                zero.Action = "-";
                textBox1.Text = zero.Num;
            }
            else if (zero.Num == "")
            {
                zero.Action = "-";
                textBox1.Text = zero.Num1 + zero.Action;
            }
            else
            {
                zero.Result();
                if (Convert.ToInt32(zero.Num1) > 999999999 || Convert.ToInt32(zero.Num1) < -999999999)
                {
                    zero.Action = "";
                    zero.Num1 = "";
                    textBox1.Text = "Ошибка";
                }
                else
                {
                    textBox1.Text = zero.Num1;
                }
            }
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            if (zero.Num1 == "" && zero.Num == "")
            {

            }
            else if (zero.Num1 == "" && zero.Num != "")
            {
                zero.Num1 = zero.Num;
                zero.Num = "";
                zero.Action = "*";
                textBox1.Text = zero.Num;
            }
            else if (zero.Num == "")
            {
                zero.Action = "*";
                textBox1.Text = zero.Num1 + zero.Action;
            }
            else
            {
                zero.Result();
                if (Convert.ToInt32(zero.Num1) > 999999999 || Convert.ToInt32(zero.Num1) < -999999999)
                {
                    zero.Action = "";
                    zero.Num1 = "";
                    textBox1.Text = "Ошибка";
                }
                else
                {
                    textBox1.Text = zero.Num1;
                }
            }
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            if (zero.Num1 == "" && zero.Num == "")
            {

            }
            else if (zero.Num1 == "" && zero.Num != "")
            {
                zero.Num1 = zero.Num;
                zero.Num = "";
                zero.Action = "/";
                textBox1.Text = zero.Num;
            }
            else if (zero.Num == "")
            {
                zero.Action = "/";
                textBox1.Text = zero.Num1 + zero.Action;
            }
            else
            {
                zero.Result();
                if (zero.Exception != "")
                {
                    textBox1.Text = zero.Exception;
                    zero.Exception = "";
                }
                else if (Convert.ToInt32(zero.Num1) > 999999999 || Convert.ToInt32(zero.Num1) < -999999999)
                {
                    zero.Action = "";
                    zero.Num1 = "";
                    textBox1.Text = "Ошибка";
                }
                else
                {
                    textBox1.Text = zero.Num1;
                }
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (zero.Num1 != "" && zero.Num != "")
            {
                zero.Result();
                zero.Action = "";
                if (zero.Exception != "")
                {
                    textBox1.Text = zero.Exception;
                    zero.Exception = "";
                }
                else if (Convert.ToInt32(zero.Num1) > 999999999 || Convert.ToInt32(zero.Num1) < -999999999)
                {
                    zero.Num1 = "";
                    textBox1.Text = "Ошибка";
                }
                else
                {
                    textBox1.Text = zero.Num1;
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            zero.Num = "";
            zero.Num1 = "";
            zero.Action = "";
            textBox1.Text = zero.Num;
        }

        private void button_plus_minus_Click(object sender, EventArgs e)
        {
            if (zero.Num != "" && zero.Num != "0")
            {
                if (zero.Num.Substring(0, 1) == "-")
                {
                    zero.Num = zero.Num.Substring(1, zero.Num.Length - 1);
                }
                else
                {
                    zero.Num = zero.Num.Insert(0, "-");
                }
                textBox1.Text = zero.Num;
            }
        }
    }
}

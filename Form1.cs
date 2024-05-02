using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        static private string display, op = "";
        static private double v1, v2, ans, k;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display += "0";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display += "1";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display += "2";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display += "3";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display += "4";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display += "5";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display += "6";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display += "7";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display += "8";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display += "9";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                k = 0;
                v1 = double.Parse(txtDisplay.Text);
                display = "";
                txtDisplay.Text = display;
                op = "+";
            }
            else { op = "+"; }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                k = 0;
                v1 = double.Parse(txtDisplay.Text);
                display = "";
                txtDisplay.Text = display;
                op = "-";
            }
            else { op = "-"; }
        }

        private void btnvezes_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                k = 0;
                v1 = double.Parse(txtDisplay.Text);
                display = "";
                txtDisplay.Text = display;
                op = "*";
            }
            else { op = "*"; }
        }

        private void btnbarra_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                k = 0;
                v1 = double.Parse(txtDisplay.Text);
                display = "";
                txtDisplay.Text = display;
                op = "/";
            }
            else { op = "/"; }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (k==1)
            {
                switch (op)
                {
                    case "+":
                        ans += v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                    case "-":
                        ans -= v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                    case "*":
                        ans *= v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                    case "/":
                        ans /= v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                }
                return;
            }
            if (txtDisplay.Text != "")
            {
                k = 1;
                v2 = double.Parse(txtDisplay.Text);
                switch (op)
                {
                    case "+":
                        ans = v1 + v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                    case "-":
                        ans = v1 - v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                    case "*":
                        ans = v1 * v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                    case "/":
                        ans = v1 / v2;
                        txtDisplay.Text = Convert.ToString(ans);
                        display = Convert.ToString(ans);
                        break;
                }
            }
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            display += ",";
            txtDisplay.Text = display;
            btnC.Text = "C";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                k = 0;
                op = "";
                display = display.Substring(0, display.Length - 1);
                txtDisplay.Text = display;
                if (txtDisplay.Text == "") 
                { 
                    btnC.Text = "CE";
                }

            }
 
        }

      
    }
}

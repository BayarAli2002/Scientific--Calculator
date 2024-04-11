using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvnaceCalculator
{
    public partial class Form1 : Form
    {
        double enterFirtsValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if(textBox1.Text =="0")
                textBox1.Text = "";
            {
                

            if (num.Text ==".")
                {
                    if(!textBox1.Text.Contains("."))
                    {
                        textBox1.Text = textBox1.Text + num.Text;
                    }
                }

            else
                {
                    textBox1.Text = textBox1.Text + num.Text;
                }
             
            }
        }

        private void numberOperator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirtsValue = Convert.ToDouble(textBox1.Text);
            op = num.Text;
            textBox1.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(textBox1.Text);
            switch(op)
            {
                case "+":
                textBox1.Text  = (enterFirtsValue + enterSecondValue).ToString();
                break;
                case "-":
                textBox1.Text = (enterFirtsValue - enterSecondValue).ToString();
                break;
                case "*":
                textBox1.Text = (enterFirtsValue * enterSecondValue).ToString();
                break;
                case "/":
                 textBox1.Text = (enterFirtsValue / enterSecondValue).ToString();
                 break;
                case "Mod":
                textBox1.Text = (enterFirtsValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                double i = Convert.ToDouble(textBox1.Text);
                 double j;
                 j = enterSecondValue;
                 textBox1.Text = Math.Exp(i*Math.Log(j*4)).ToString();
                  break;

                default: 
         
                break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            String first, second;
            first = Convert.ToString(enterFirtsValue);
            second = Convert.ToString(enterFirtsValue);
            first = "";
            second = " ";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1*q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300; // the original size 816
            textBox1.Width = 250; //the original size 330

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300; // the original size 816
            textBox1.Width = 250; //the original size 330
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 600; // the original size 816
            textBox1.Width = 550; //the original size 330
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit","Scientific Calculator",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(textBox1.Text);
            logg = Math.Log10(logg);
            textBox1.Text = Convert.ToString(logg);
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(textBox1.Text);
            sq = Math.Sqrt(sq);
            textBox1.Text = Convert.ToString(sq);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x2;
            x2 = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(x2);

        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x3;
            x3 = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)* Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(x3);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(textBox1.Text);
            sh = Math.Sinh(sh);
            textBox1.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox1.Text);
            s = Math.Sin(s);
            textBox1.Text = Convert.ToString(s);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox1.Text);
            s = Math.Cos(s);
            textBox1.Text = Convert.ToString(s);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox1.Text);
            s = Math.Cosh(s);
            textBox1.Text = Convert.ToString(s);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double T = Convert.ToDouble(textBox1.Text);
            T = Math.Tan(T);
            textBox1.Text = Convert.ToString(T);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double Th = Convert.ToDouble(textBox1.Text);
            Th = Math.Tanh(Th);
            textBox1.Text = Convert.ToString(Th);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a= Convert.ToDouble(1.0/ Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(a);
        }

        private void btnlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(textBox1.Text);
            lnx = Math.Log(lnx);
            textBox1.Text = Convert.ToString(lnx);
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = Convert.ToString(a);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec  = Convert.ToDouble(textBox1.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;

            textBox1.Text = Convert.ToString(i2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a,2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 8);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

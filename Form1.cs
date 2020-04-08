using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectcalculator;

namespace projectcalculator
{
    public partial class Form1 : Form

    {
        ICalc Calc;
        double tmp1;
        double tmp2;
        bool zapyataya = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "";
            }
            Addtotextbox("1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmp1 = 0;
            tmp2 = 0;
            Calc = null;
            Textbox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("2");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("3");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("4");

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "";
            }
            Addtotextbox("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0" )
            {
                Textbox.Text = "";
            }
            Addtotextbox("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "";
            }
            Addtotextbox("0");
            
        }
        public  void Addtotextbox(string a)
        {
            Textbox.Text += a;
        }

        private void add_click(object sender, EventArgs e)
        {
            if(Textbox.Text!= "" )
            {
                if(Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1,Convert.ToDouble(Textbox.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(Textbox.Text);
                }
                Textbox.Text = "";
                Calc = new Adder();

                zapyataya = false;
            }

        }

        private void subtract_click(object sender, EventArgs e)
        {
            if (Textbox.Text != "" )

            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(Textbox.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(Textbox.Text);
                }
                Textbox.Text = "";
                Calc = new Subtract();
                zapyataya = false;
            }
         
        }

        private void multiplication_click(object sender, EventArgs e)
        {
                if (Textbox.Text != "" )
                {

                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(Textbox.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(Textbox.Text);
                }
                
                      Textbox.Text = "";
                    Calc = new Multiplication();
                zapyataya = false;
            }
            
        }

        private void division_click(object sender, EventArgs e)
        {      
            
                if (Textbox.Text != "" )
                {
                      if (Calc != null)
                      {                    
                        tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(Textbox.Text));
                     
                      }
                       else 
                       {
                       tmp1 = Convert.ToDouble(Textbox.Text);
                       

                       }
                }
                Textbox.Text = "";
                Calc = new Division();
               zapyataya = false;


        }
          


        private void solution_click(object sender, EventArgs e)
        {
            if (Textbox.Text != "" && Calc != null)
            {
            tmp2 = Convert.ToDouble(Textbox.Text);
            Textbox.Text = Calc.DoMath(tmp1, tmp2)+"";

            }
            zapyataya = false;
        }

        private void negative_click(object sender, EventArgs e)
        {
            if (Textbox.Text == "" )                          
            {
              
                Textbox.Text = "-";    
            }

            else
            {
            double current = Convert.ToDouble(Textbox.Text);
            Textbox.Text = current * (-1) + "";
            }

        }

        private void pointforfloat_click(object sender, EventArgs e)
        {

            if (!zapyataya)
            {
                if (Textbox.Text == "" && Calc == null)
            {
                Textbox.Text = "0,";
            }
            else 
            {
                Addtotextbox(",");


                    
            }

                zapyataya = true;
            }
        }
    }
}

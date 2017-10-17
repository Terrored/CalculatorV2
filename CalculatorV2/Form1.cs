using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }





        private void addNumber(object sender, EventArgs e)
        {

            Button x = (Button)sender;

           
            
                if ((resultText.Text == "0" && x.Text != ",") || operation_pressed)
                    resultText.Clear();

                operation_pressed = false;
                
                if (x.Text == ",")
                {
                    if (!resultText.Text.Contains(","))

                        resultText.Text += x.Text;


                }
                else
                    resultText.Text += x.Text;
            

        }

        

        private void operation_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;

            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = x.Text;
                equation.Text = resultText.Text + x.Text;
            }
            else
            {
                operation = x.Text;
                value = Math.Round(Double.Parse(resultText.Text), 3);
                equation.Text = resultText.Text + x.Text;
                resultText.Text = value.ToString();

                operation_pressed = true;
            }


        }

        private void button18_Click(object sender, EventArgs e) // equal button
        {
            switch (operation)
            {


                case "+":
                    resultText.Text = (Math.Round(value + Double.Parse(resultText.Text), 3)).ToString();
                    break;
                case "-":
                    resultText.Text = (Math.Round(value - Double.Parse(resultText.Text), 3)).ToString();
                    break;
                case "*":
                    resultText.Text = (Math.Round(value * Double.Parse(resultText.Text),3)).ToString();
                    break;
                case "/" :
                    if (Double.Parse(resultText.Text) == 0)
                    {
                        resultText.Text = "0";
                        MessageBox.Show("Nie dziel przez zero !");
                        
                        
                    }
                    else
                        resultText.Text = (Math.Round(value / Double.Parse(resultText.Text), 3)).ToString();
                    break;
                default:
                    break;

            }
            equation.Text = "";
            operation_pressed = false;

            operation = "";
            value = Double.Parse(resultText.Text);
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            resultText.Text = "0";
            value = 0;
            equation.Text = "";
        }
        private void ceButton_Click(object sender, EventArgs e)
        {
            resultText.Text = "0";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "+":
                    sum.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    multi.PerformClick();
                    break;
                case ",":
                    point.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                
                default:
                    break;
                    



            }
        }
    }
}

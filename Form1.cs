using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        double result = 0;
        string operationperformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, MouseEventArgs e)
        {
            //παιρνει τα νουμερα απο τα κουμπια.
            if ((textBox1.Text == "0")||(isoperationperformed))
            { textBox1.Clear(); }
            isoperationperformed = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if(!textBox1.Text.Contains(","))
                { textBox1.Text += button.Text; }
            }
            else
            textBox1.Text += button.Text;
        }

        private void Operator_Click(object sender, MouseEventArgs e)
        {
            //παιρνει τα (+,-,*,/) απο τα κουμπια.
            Button button = (Button)sender;
            if (result != 0)
            {
                button15.PerformClick();
                operationperformed = button.Text;
                label1.Text += operationperformed;
                isoperationperformed = true;
            }
            else
            {

                operationperformed = button.Text;
                label1.Text += operationperformed;
                result = double.Parse(textBox1.Text);
                isoperationperformed = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    label1.Text = textBox1.Text;
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    label1.Text = textBox1.Text;
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    label1.Text = textBox1.Text;
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    label1.Text = textBox1.Text;
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox1.Text);
        }
    }
}

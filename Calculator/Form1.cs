using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Text = "0";
            comboBox1.Text = "Basic (Current)";
        }
        
        public void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (success)
            {
                textBox1.Clear();
                success = false;
            }
            string s = (sender as Button).Text;
            textBox1.AppendText(s);
            if ((sender as Button).Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.AppendText(s);
                }
            }
        }
        
        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "Standard";
        }
        string operation = "";
        double resultval = 0;
        bool success = false;
        public void operation_performed(object sender, EventArgs e)
        {
            try
            {
                string s1 = (sender as Button).Text;
                operation = s1;
                if (operation == "%")
                {
                    textBox1.Text = (Double.Parse(textBox1.Text) / 100).ToString();
                    success = true;
                }
                else
                {
                    resultval = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = resultval + s1;
                }
            }
            catch (NullReferenceException)
            {
                //Do nothing here
            }
            
        }
        public void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (resultval + Double.Parse(textBox1.Text)).ToString();
                    resultval = 0;
                    break;
                case "-":
                    textBox1.Text = (resultval - Double.Parse(textBox1.Text)).ToString();
                    resultval = 0;
                    break;
                case "*":
                    textBox1.Text = (resultval * Double.Parse(textBox1.Text)).ToString();
                    resultval = 0;
                    break;
                case "/":
                    textBox1.Text = (resultval / Double.Parse(textBox1.Text)).ToString();
                    resultval = 0;
                    break;
                case "^":
                    textBox1.Text = "Currently unavailible";
                    break;
            }
            label1.Text = "Standard";
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = "Cannot divide by zero you dumbass, you could have pay more attention in the math class";
            }
            if (textBox1.Text == "∞")
            {
                textBox1.Clear();
                textBox1.Text = "Result is undefined";
            }
            success = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Convert")
            {
                this.Hide();
                Form frm = new Form2();
                frm.ShowDialog();
                
            }
        }
    }
}
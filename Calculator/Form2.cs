using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Text = "Convert (Current)";
            textBox1.Text = "0";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Basic")
            {
                this.Hide();
                Form frm = new Form1();
                frm.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Area":
                    comboBox3.Text = "-Please select-";
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("Acres (ac)");
                    comboBox3.Items.Add("Ares (a)");
                    comboBox3.Items.Add("Hectares (ha)");
                    comboBox3.Items.Add("Square centimeters (cm2)");
                    comboBox3.Items.Add("Square feet (ft2)");
                    comboBox3.Items.Add("Square inches (in2)");
                    comboBox3.Items.Add("Square meters (m2)");
                    comboBox4.Text = "-Please select-";
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("Acres (ac)");
                    comboBox4.Items.Add("Ares (a)");
                    comboBox4.Items.Add("Hectares (ha)");
                    comboBox4.Items.Add("Square centimeters (cm2)");
                    comboBox4.Items.Add("Square feet (ft2)");
                    comboBox4.Items.Add("Square inches (in2)");
                    comboBox4.Items.Add("Square meters (m2)");
                    break;
                case "Length":
                    comboBox3.Text = "-Please select-";
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("Millimeters (mm)");
                    comboBox3.Items.Add("Centimeters (cm)");
                    comboBox3.Items.Add("Meters (m)");
                    comboBox3.Items.Add("Kilometers (km)");
                    comboBox3.Items.Add("Inches (in)");
                    comboBox3.Items.Add("Feet (ft)");
                    comboBox3.Items.Add("Yards");
                    comboBox3.Items.Add("Miles (mi)");
                    comboBox3.Items.Add("Nautical miles (NM)");
                    comboBox3.Items.Add("Mils (mil)");
                    comboBox4.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("Millimeters (mm)");
                    comboBox4.Items.Add("Centimeters (cm)");
                    comboBox4.Items.Add("Meters (m)");
                    comboBox4.Items.Add("Kilometers (km)");
                    comboBox4.Items.Add("Inches (in)");
                    comboBox4.Items.Add("Feet (ft)");
                    comboBox4.Items.Add("Yards");
                    comboBox4.Items.Add("Miles (mi)");
                    comboBox4.Items.Add("Nautical miles (NM)");
                    comboBox4.Items.Add("Mils (mil)");
                    break;
                case "Temperature":
                    comboBox3.Text = "-Please select-";
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("Celcius (C)");
                    comboBox3.Items.Add("Farenheit (F)");
                    comboBox3.Items.Add("Kelvin (K)");
                    comboBox4.Items.Clear();
                    comboBox4.Text = "-Please select-";
                    comboBox4.Items.Add("Celcius (C)");
                    comboBox4.Items.Add("Farenheit (F)");
                    comboBox4.Items.Add("Kelvin(K)");
                    break;


            }
        }
    }
}

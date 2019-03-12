using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varner_OOP
{
    public partial class HV_Form_2019_03_05 : Form
    {
        public HV_Form_2019_03_05()
        {
            InitializeComponent();
        }

        private void HV_btn_0_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "0";
        }

        private void HV_btn_1_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "1";
        }

        private void HV_btn_2_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "2";
        }

        private void HV_btn_3_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "3";
        }

        private void HV_btn_4_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "4";
        }

        private void HV_btn_5_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "5";
        }

        private void HV_btn_6_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "6";
        }

        private void HV_btn_7_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "7";
        }

        private void HV_btn_8_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "8";
        }

        private void HV_btn_9_Click(object sender, EventArgs e)
        {
            if (HV_Display.Text == "0")
            {
                HV_Display.Text = "";
            }

            HV_Display.Text += "9";
        }

        private void HV_btn_PlusMinus_Click(object sender, EventArgs e)
        {
            string text = HV_Display.Text;
            if (text[0] == '-')
            {
                text = text.Substring(1);
            }

            else if (text != "0")
            {
                text = "-" + text;
            }

            HV_Display.Text = text;
        }

        private void HV_btn_Comma_Click(object sender, EventArgs e)
        {
            if (!HV_Display.Text.Contains(','))
            {
                HV_Display.Text += ",";
            }
           
        }

        private void HV_btn_CE_Click(object sender, EventArgs e)
        {
            HV_Display.Text = "0";
        }

        private void HV_btn_C_Click(object sender, EventArgs e)
        {
            HV_Display.Text = "0";
        }

        private void HV_btn_Back_Click(object sender, EventArgs e)
        {
            string text = HV_Display.Text;
            text = text.Substring(0, text.Length - 1);

            if (text == "")
            {
                text = "0";
            }

            HV_Display.Text = text; 
        }

        private void HV_btn_Divide_Click(object sender, EventArgs e)
        {
            
        }

        private void HV_btn_Multiply_Click(object sender, EventArgs e)
        {

        }

        private void HV_btn_Substract_Click(object sender, EventArgs e)
        {

        }

        private void HV_btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void HV_btn_Compute_Click(object sender, EventArgs e)
        {

        }

        private double ToDouble(string str)
        {
            return double.Parse(str.Replace(",", "."));
        }
    }
}

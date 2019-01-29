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
    public partial class HV_Form_2019_01_29 : Form
    {
        public HV_Form_2019_01_29()
        {
            InitializeComponent();
        }

        private void HV_txt_1_TextChanged(object sender, EventArgs e)
        {
            if (HV_rb_1.Checked)
            {
                HV_lbl_1.Text = HV_txt_1.Text;
            }
            else if (HV_rb_2.Checked)
            {
                HV_lbl_1.Text = Reverse(HV_txt_1.Text);
            }
            else if (HV_rb_3.Checked)
            {
                HV_lbl_1.Text = HV_txt_1.Text.ToUpper();
            }
            else if (HV_rb_4.Checked)
            {
                HV_lbl_1.Text = AddSpaces(HV_txt_1.Text);
            }
        }

        private void HV_rb_1_CheckedChanged(object sender, EventArgs e)
        {
            HV_lbl_1.Text = HV_txt_1.Text;
        }

        private void HV_rb_2_CheckedChanged(object sender, EventArgs e)
        {
            HV_lbl_1.Text = Reverse(HV_txt_1.Text);
        }

        private void HV_rb_3_CheckedChanged(object sender, EventArgs e)
        {
            HV_lbl_1.Text = HV_txt_1.Text.ToUpper();
        }

        private void HV_rb_4_CheckedChanged(object sender, EventArgs e)
        {
            HV_lbl_1.Text = AddSpaces(HV_txt_1.Text);
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string AddSpaces(string s)
        {
            char[] charArray = s.ToCharArray();
            string newString = string.Join(" ", charArray);
            return newString;
        }
    }
}

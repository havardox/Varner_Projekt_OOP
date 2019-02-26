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
    public partial class HV_Form_2019_02_19 : Form
    {
        public HV_Form_2019_02_19()
        {
            InitializeComponent();
        }

        private void HV_btn_1_Click(object sender, EventArgs e)
        {
            HV_open.Filter = "Tekstifailid|*.txt;*;*log;*.cs|RTF failid|*.RTF|Suvalised failid|*.*";
            HV_open.FileName = "";
            HV_open.ShowDialog();
            string fileName = HV_open.FileName;
            HV_lbl_3.Text = fileName;
            if (fileName == "")
            {
                return;
            }
            string extension = fileName.Substring(fileName.Length - 4).ToLower();
            if (extension == ".rtf")
            {
                HV_rich_txt_1.Rtf = System.IO.File.ReadAllText(fileName);
                HV_txt_1.Text = HV_rich_txt_1.Text;
            }
            else
            {
                HV_txt_1.Text = System.IO.File.ReadAllText(fileName);
                HV_rich_txt_1.Text = HV_txt_1.Text;
            }
        }

        private void HV_btn_2_Click(object sender, EventArgs e)
        {

            if (HV_rich_txt_1.SelectionLength > 0)
            {
                HV_font_dialog.Font = HV_rich_txt_1.SelectionFont;
                DialogResult v = HV_font_dialog.ShowDialog();
                if (v == DialogResult.OK)
                {
                    HV_rich_txt_1.SelectionFont = HV_font_dialog.Font;
                }
            }
            else
            {
                HV_rich_txt_1.SelectionStart = 0;
                HV_rich_txt_1.SelectionLength = 1;
                HV_font_dialog.Font = HV_rich_txt_1.SelectionFont;
                DialogResult v = HV_font_dialog.ShowDialog();
                if (v == DialogResult.OK)
                {
                    HV_rich_txt_1.SelectAll();
                    HV_rich_txt_1.SelectionFont = HV_font_dialog.Font;
                }
            }
            HV_rich_txt_1.SelectionStart = 0;
            HV_rich_txt_1.SelectionLength = 0;
        }

        private void HV_btn_3_Click(object sender, EventArgs e)
        {
            HV_color_dialog.ShowDialog();
            if (HV_rich_txt_1.SelectionLength > 0)
            {
                HV_rich_txt_1.SelectionColor = HV_color_dialog.Color;
            }
            else
            {
                HV_rich_txt_1.ForeColor = HV_color_dialog.Color;
            }

            HV_rich_txt_1.SelectionStart = 0;
            HV_rich_txt_1.SelectionLength = 0;
        }
    }
}
 
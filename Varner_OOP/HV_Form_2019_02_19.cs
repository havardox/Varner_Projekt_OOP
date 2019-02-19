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
            HV_open.Filter = "Tekstifailid*.txt;*;*.rtf;*";
            HV_open.FileName = "";
            HV_open.ShowDialog();
            string fileName = 
        }
    }
}
 
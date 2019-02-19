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
    public partial class HV_Form_Main : Form
    {
        Form F1 = new HV_Form_2019_01_15();
        Form F2 = new HV_Form_2019_01_29();
        Form F3 = new HV_Form_2019_02_05();
        Form F4 = new HV_Form_2019_02_19();

        public HV_Form_Main()
        {
            InitializeComponent();
        }

        private void HV_Form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void HV_btn_2019_01_15_Click(object sender, EventArgs e)
        {
            if (F1.Visible == false)
            {
                F1 = new HV_Form_2019_01_15();
            }

            F1.Visible = true;
            F1.Activate();
        }

        private void HV_btn_2019_01_29_Click(object sender, EventArgs e)
        {
            if (F2.Visible == false)
            {
                F2 = new HV_Form_2019_01_29();
            }

            F2.Visible = true;
            F2.Activate();
        }

        private void HV_btn_2019_02_05_Click_1(object sender, EventArgs e)
        {
            if (F3.Visible == false)
            {
                F3 = new HV_Form_2019_02_05();
            }

            F3.Visible = true;
            F3.Activate();
        }

        private void HV_btn_2019_02_19_Click(object sender, EventArgs e)
        {
            if (F4.Visible == false)
            {
                F4 = new HV_Form_2019_02_19();
            }

            F4.Visible = true;
            F4.Activate();
        }
    }
}

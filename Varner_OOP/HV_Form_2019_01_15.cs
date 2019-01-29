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
    public partial class HV_Form_2019_01_15 : Form
    {
        public HV_Form_2019_01_15()
        {
            InitializeComponent();
        }

        private void HV_timer1_Tick(object sender, EventArgs e)
        {
            HV_lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void HV_btn_Timer_Click(object sender, EventArgs e)
        {
            if(HV_timer1.Enabled)
            {
                HV_timer1.Enabled = false;
                HV_btn_Timer.Text = "Start";
                HV_lbl_Time.Text = "";
            }
            else
            {
                HV_timer1.Enabled = true;
                HV_btn_Timer.Text = "Stop";
            }
        }

        private void HV_Form_2019_01_15_Load(object sender, EventArgs e)
        {

        }
    }
}

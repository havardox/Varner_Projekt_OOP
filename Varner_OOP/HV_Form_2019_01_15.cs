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
    }
}

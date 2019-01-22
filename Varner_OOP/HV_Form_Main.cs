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
    }
}

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
    public partial class HV_Form_2019_02_05 : Form
    {
        public HV_Form_2019_02_05()
        {
            InitializeComponent();
        }

        private void HV_btn_1_Click(object sender, EventArgs e)
        {
            int choice = HV_list_1.SelectedIndex;
            if (choice < 0)
            {
                HV_list_1.Items.Add(HV_txt_1.Text);
            }
            else
            {
                HV_list_1.Items.Insert(choice, HV_txt_1.Text);
            }

            HV_list_1.SelectedIndex = -1;
            HV_txt_1.Text = "";
            HV_txt_1.Focus();
        }

        private void HV_Sorting_CheckedChanged(object sender, EventArgs e)
        {
            HV_list_1.Sorted = HV_Sorting.Checked;
        }

        private void HV_btn_2_Click(object sender, EventArgs e)
        {
            int choice = HV_list_1.SelectedIndex;
            if (choice < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            string t = "Soovite kustutada:" + (char)(13) + (char)(13) + HV_list_1.Items[choice];
            DialogResult answer = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                HV_list_1.Items.RemoveAt(choice);
            }
            else
            {
                HV_list_1.SelectedIndex = -1;
            }
        }

        private void HV_btn_3_Click(object sender, EventArgs e)
        {
            int choice = HV_list_1.SelectedIndex;
            if (choice < 0)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            HV_list_1.Items.RemoveAt(choice);
            HV_list_1.Items.Insert(choice, HV_txt_1.Text);
            HV_list_1.SelectedIndex = -1;
            HV_txt_1.Text = "";
            HV_txt_1.Focus();
        }

        private void HV_list_1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

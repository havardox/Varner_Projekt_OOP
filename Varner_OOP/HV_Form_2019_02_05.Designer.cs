namespace Varner_OOP
{
    partial class HV_Form_2019_02_05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HV_txt_1 = new System.Windows.Forms.TextBox();
            this.HV_list_1 = new System.Windows.Forms.ListBox();
            this.HV_btn_1 = new System.Windows.Forms.Button();
            this.HV_Sorting = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HV_txt_1
            // 
            this.HV_txt_1.Location = new System.Drawing.Point(15, 15);
            this.HV_txt_1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HV_txt_1.Name = "HV_txt_1";
            this.HV_txt_1.Size = new System.Drawing.Size(536, 29);
            this.HV_txt_1.TabIndex = 0;
            // 
            // HV_list_1
            // 
            this.HV_list_1.FormattingEnabled = true;
            this.HV_list_1.ItemHeight = 22;
            this.HV_list_1.Location = new System.Drawing.Point(725, 15);
            this.HV_list_1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HV_list_1.Name = "HV_list_1";
            this.HV_list_1.Size = new System.Drawing.Size(563, 532);
            this.HV_list_1.TabIndex = 1;
            // 
            // HV_btn_1
            // 
            this.HV_btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HV_btn_1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HV_btn_1.Location = new System.Drawing.Point(563, 15);
            this.HV_btn_1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.HV_btn_1.Name = "HV_btn_1";
            this.HV_btn_1.Size = new System.Drawing.Size(110, 30);
            this.HV_btn_1.TabIndex = 2;
            this.HV_btn_1.Text = "--->";
            this.HV_btn_1.UseVisualStyleBackColor = false;
            this.HV_btn_1.Click += new System.EventHandler(this.HV_btn_1_Click);
            // 
            // HV_Sorting
            // 
            this.HV_Sorting.AutoSize = true;
            this.HV_Sorting.Location = new System.Drawing.Point(15, 71);
            this.HV_Sorting.Name = "HV_Sorting";
            this.HV_Sorting.Size = new System.Drawing.Size(95, 26);
            this.HV_Sorting.TabIndex = 3;
            this.HV_Sorting.Text = "Sorted";
            this.HV_Sorting.UseVisualStyleBackColor = true;
            this.HV_Sorting.CheckedChanged += new System.EventHandler(this.HV_Sorting_CheckedChanged);
            // 
            // HV_Form_2019_02_05
            // 
            this.AcceptButton = this.HV_btn_1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.HV_btn_1;
            this.ClientSize = new System.Drawing.Size(1303, 762);
            this.Controls.Add(this.HV_Sorting);
            this.Controls.Add(this.HV_btn_1);
            this.Controls.Add(this.HV_list_1);
            this.Controls.Add(this.HV_txt_1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HV_Form_2019_02_05";
            this.Text = "HV_Form_2019_02_05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HV_txt_1;
        private System.Windows.Forms.ListBox HV_list_1;
        private System.Windows.Forms.Button HV_btn_1;
        private System.Windows.Forms.CheckBox HV_Sorting;
    }
}
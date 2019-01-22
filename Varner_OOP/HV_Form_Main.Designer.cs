namespace Varner_OOP
{
    partial class HV_Form_Main
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
            this.HV_btn_2019_01_15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HV_btn_2019_01_15
            // 
            this.HV_btn_2019_01_15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HV_btn_2019_01_15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.HV_btn_2019_01_15.Location = new System.Drawing.Point(66, 88);
            this.HV_btn_2019_01_15.Name = "HV_btn_2019_01_15";
            this.HV_btn_2019_01_15.Size = new System.Drawing.Size(187, 59);
            this.HV_btn_2019_01_15.TabIndex = 0;
            this.HV_btn_2019_01_15.Text = "15.01.2019";
            this.HV_btn_2019_01_15.UseVisualStyleBackColor = false;
            this.HV_btn_2019_01_15.Click += new System.EventHandler(this.HV_btn_2019_01_15_Click);
            // 
            // HV_Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 692);
            this.Controls.Add(this.HV_btn_2019_01_15);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "HV_Form_Main";
            this.Text = "TA-18E Main";
            this.Load += new System.EventHandler(this.HV_Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HV_btn_2019_01_15;
    }
}


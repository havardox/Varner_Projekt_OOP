namespace Varner_OOP
{
    partial class HV_Form_2019_01_15
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
            this.components = new System.ComponentModel.Container();
            this.HV_lbl_Time = new System.Windows.Forms.Label();
            this.HV_timer1 = new System.Windows.Forms.Timer(this.components);
            this.HV_btn_Timer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HV_lbl_Time
            // 
            this.HV_lbl_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HV_lbl_Time.ForeColor = System.Drawing.Color.Red;
            this.HV_lbl_Time.Location = new System.Drawing.Point(386, 119);
            this.HV_lbl_Time.Name = "HV_lbl_Time";
            this.HV_lbl_Time.Size = new System.Drawing.Size(294, 55);
            this.HV_lbl_Time.TabIndex = 0;
            this.HV_lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HV_timer1
            // 
            this.HV_timer1.Interval = 1000;
            this.HV_timer1.Tick += new System.EventHandler(this.HV_timer1_Tick);
            // 
            // HV_btn_Timer
            // 
            this.HV_btn_Timer.Location = new System.Drawing.Point(477, 207);
            this.HV_btn_Timer.Name = "HV_btn_Timer";
            this.HV_btn_Timer.Size = new System.Drawing.Size(140, 44);
            this.HV_btn_Timer.TabIndex = 1;
            this.HV_btn_Timer.Text = "Start";
            this.HV_btn_Timer.UseVisualStyleBackColor = true;
            // 
            // HV_Form_2019_01_15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 554);
            this.Controls.Add(this.HV_btn_Timer);
            this.Controls.Add(this.HV_lbl_Time);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "HV_Form_2019_01_15";
            this.Text = "HV_Form_2019_01_15";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HV_lbl_Time;
        private System.Windows.Forms.Timer HV_timer1;
        private System.Windows.Forms.Button HV_btn_Timer;
    }
}
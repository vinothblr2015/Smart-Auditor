namespace Auditor.Views.Management
{
    partial class FrmSystemSettings
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
            this.label42 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DatePeriodStart = new System.Windows.Forms.DateTimePicker();
            this.DatePeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(447, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 32);
            this.label42.TabIndex = 93;
            this.label42.Text = "من";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(153, 189);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 33);
            this.BtnSave.TabIndex = 95;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(200, 121);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(187, 29);
            this.TxtDocNo.TabIndex = 94;
            this.TxtDocNo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatePeriodEnd);
            this.groupBox1.Controls.Add(this.DatePeriodStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 91);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الفترة المالية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(217, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 94;
            this.label1.Text = "إلى";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(280, 189);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 97;
            this.BtnClose.Text = "خــروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DatePeriodStart
            // 
            this.DatePeriodStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePeriodStart.Location = new System.Drawing.Point(254, 35);
            this.DatePeriodStart.Name = "DatePeriodStart";
            this.DatePeriodStart.RightToLeftLayout = true;
            this.DatePeriodStart.Size = new System.Drawing.Size(187, 29);
            this.DatePeriodStart.TabIndex = 98;
            // 
            // DatePeriodEnd
            // 
            this.DatePeriodEnd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePeriodEnd.Location = new System.Drawing.Point(27, 35);
            this.DatePeriodEnd.Name = "DatePeriodEnd";
            this.DatePeriodEnd.RightToLeftLayout = true;
            this.DatePeriodEnd.Size = new System.Drawing.Size(187, 29);
            this.DatePeriodEnd.TabIndex = 99;
            // 
            // FrmSystemSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 246);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDocNo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "FrmSystemSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات البرنامج";
            this.Load += new System.EventHandler(this.FrmSystemSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DateTimePicker DatePeriodEnd;
        private System.Windows.Forms.DateTimePicker DatePeriodStart;
    }
}
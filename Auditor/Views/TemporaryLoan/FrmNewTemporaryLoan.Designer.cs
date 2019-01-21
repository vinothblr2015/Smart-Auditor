namespace Auditor.Views.TemporaryLoan
{
    partial class FrmNewTemporaryLoan
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
            this.DatePayDate = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            this.TxtPeriod = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePayDate
            // 
            this.DatePayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePayDate.Location = new System.Drawing.Point(140, 46);
            this.DatePayDate.Name = "DatePayDate";
            this.DatePayDate.RightToLeftLayout = true;
            this.DatePayDate.Size = new System.Drawing.Size(187, 29);
            this.DatePayDate.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(32, 45);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 65;
            this.label45.Text = "تاريخ الصرف";
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(140, 12);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(187, 29);
            this.TxtDocNo.TabIndex = 0;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(32, 11);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 64;
            this.label42.Text = "رقم المستند";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(477, 12);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(226, 30);
            this.ComboLocation.TabIndex = 2;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.auditorDataSet;
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(351, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 71;
            this.label1.Text = "الجهة التابع لها";
            // 
            // ComboEmployee
            // 
            this.ComboEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboEmployee.DataSource = this.employeeBindingSource;
            this.ComboEmployee.DisplayMember = "EmployeeName";
            this.ComboEmployee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEmployee.FormattingEnabled = true;
            this.ComboEmployee.Location = new System.Drawing.Point(477, 47);
            this.ComboEmployee.Name = "ComboEmployee";
            this.ComboEmployee.Size = new System.Drawing.Size(226, 30);
            this.ComboEmployee.TabIndex = 3;
            this.ComboEmployee.ValueMember = "EmployeeID";
            this.ComboEmployee.TextChanged += new System.EventHandler(this.ComboEmployee_TextChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.auditorDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(351, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 76;
            this.label5.Text = "مسئول السلفة";
            // 
            // TxtTotalAmount
            // 
            this.TxtTotalAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalAmount.Location = new System.Drawing.Point(140, 81);
            this.TxtTotalAmount.Name = "TxtTotalAmount";
            this.TxtTotalAmount.Size = new System.Drawing.Size(140, 29);
            this.TxtTotalAmount.TabIndex = 4;
            this.TxtTotalAmount.Text = "0";
            this.TxtTotalAmount.TextChanged += new System.EventHandler(this.TxtTotalAmount_TextChanged);
            this.TxtTotalAmount.Leave += new System.EventHandler(this.TxtTotalAmount_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(32, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 78;
            this.label4.Text = "مبلغ السلفة";
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // TxtPeriod
            // 
            this.TxtPeriod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPeriod.Location = new System.Drawing.Point(477, 81);
            this.TxtPeriod.Name = "TxtPeriod";
            this.TxtPeriod.Size = new System.Drawing.Size(187, 29);
            this.TxtPeriod.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.Location = new System.Drawing.Point(351, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 32);
            this.label22.TabIndex = 178;
            this.label22.Text = "التسوية خلال";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.Location = new System.Drawing.Point(662, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 32);
            this.label23.TabIndex = 179;
            this.label23.Text = "يوم";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(381, 257);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.Location = new System.Drawing.Point(256, 257);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 33);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "إضافة";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(140, 182);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(563, 55);
            this.TxtNotes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(32, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 189;
            this.label3.Text = "ملاحظات";
            // 
            // TxtReason
            // 
            this.TxtReason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtReason.Location = new System.Drawing.Point(140, 118);
            this.TxtReason.Multiline = true;
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtReason.Size = new System.Drawing.Size(563, 57);
            this.TxtReason.TabIndex = 6;
            this.TxtReason.TextChanged += new System.EventHandler(this.TxtReason_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(32, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 32);
            this.label8.TabIndex = 190;
            this.label8.Text = "البيان";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(286, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 194;
            this.label9.Text = "جنيه";
            // 
            // FrmNewTemporaryLoan
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(734, 314);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TxtPeriod);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TxtTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePayDate);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNewTemporaryLoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة بيانات سلفة مؤقتة";
            this.Load += new System.EventHandler(this.FrmNewTemporaryLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePayDate;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalAmount;
        private System.Windows.Forms.Label label4;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox TxtPeriod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
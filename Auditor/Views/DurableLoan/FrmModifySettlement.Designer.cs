namespace Auditor
{
    partial class FrmModifySettlement
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
            this.TxtSettlementNo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSettlement = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboSetNo = new System.Windows.Forms.ComboBox();
            this.settlementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settlementsTableAdapter = new Auditor.AuditorDataSetTableAdapters.SettlementsTableAdapter();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSettlementNo
            // 
            this.TxtSettlementNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSettlementNo.Location = new System.Drawing.Point(158, 47);
            this.TxtSettlementNo.Name = "TxtSettlementNo";
            this.TxtSettlementNo.Size = new System.Drawing.Size(187, 29);
            this.TxtSettlementNo.TabIndex = 217;
            this.TxtSettlementNo.TextChanged += new System.EventHandler(this.TxtSettlementNo_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label28.Location = new System.Drawing.Point(32, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 32);
            this.label28.TabIndex = 231;
            this.label28.Text = "رقم التسوية";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(623, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 230;
            this.label9.Text = "جنيه";
            // 
            // TxtReason
            // 
            this.TxtReason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtReason.Location = new System.Drawing.Point(140, 121);
            this.TxtReason.Multiline = true;
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtReason.Size = new System.Drawing.Size(563, 57);
            this.TxtReason.TabIndex = 221;
            this.TxtReason.TextChanged += new System.EventHandler(this.TxtReason_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(32, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 32);
            this.label8.TabIndex = 229;
            this.label8.Text = "البيان";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(140, 185);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(563, 55);
            this.TxtNotes.TabIndex = 222;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(32, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 228;
            this.label3.Text = "ملاحظات";
            // 
            // TxtTotalAmount
            // 
            this.TxtTotalAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalAmount.Location = new System.Drawing.Point(477, 86);
            this.TxtTotalAmount.Name = "TxtTotalAmount";
            this.TxtTotalAmount.Size = new System.Drawing.Size(140, 29);
            this.TxtTotalAmount.TabIndex = 220;
            this.TxtTotalAmount.Text = "0.00";
            this.TxtTotalAmount.TextChanged += new System.EventHandler(this.TxtTotalAmount_TextChanged);
            this.TxtTotalAmount.Leave += new System.EventHandler(this.TxtTotalAmount_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(351, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 227;
            this.label4.Text = "قيمة التسوية";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(477, 47);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(226, 30);
            this.ComboLocation.TabIndex = 219;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.auditorDataSetBindingSource;
            // 
            // auditorDataSetBindingSource
            // 
            this.auditorDataSetBindingSource.DataSource = this.auditorDataSet;
            this.auditorDataSetBindingSource.Position = 0;
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
            this.label1.Location = new System.Drawing.Point(351, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 226;
            this.label1.Text = "الجهة التابع لها";
            // 
            // DateSettlement
            // 
            this.DateSettlement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSettlement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateSettlement.Location = new System.Drawing.Point(158, 84);
            this.DateSettlement.Name = "DateSettlement";
            this.DateSettlement.RightToLeftLayout = true;
            this.DateSettlement.Size = new System.Drawing.Size(187, 29);
            this.DateSettlement.TabIndex = 218;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(32, 85);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(93, 32);
            this.label45.TabIndex = 225;
            this.label45.Text = "تاريخ التسوية";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(310, 263);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 233;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(469, 263);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 234;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(151, 263);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 232;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 235;
            this.label2.Text = "رقم التسوية";
            // 
            // ComboSetNo
            // 
            this.ComboSetNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboSetNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboSetNo.DataSource = this.settlementsBindingSource;
            this.ComboSetNo.DisplayMember = "SetNo";
            this.ComboSetNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSetNo.FormattingEnabled = true;
            this.ComboSetNo.Location = new System.Drawing.Point(158, 9);
            this.ComboSetNo.Name = "ComboSetNo";
            this.ComboSetNo.Size = new System.Drawing.Size(187, 30);
            this.ComboSetNo.TabIndex = 236;
            this.ComboSetNo.ValueMember = "SetNo";
            this.ComboSetNo.TextChanged += new System.EventHandler(this.ComboSetNo_TextChanged);
            // 
            // settlementsBindingSource
            // 
            this.settlementsBindingSource.DataMember = "Settlements";
            this.settlementsBindingSource.DataSource = this.auditorDataSet;
            // 
            // settlementsTableAdapter
            // 
            this.settlementsTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModifySettlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 316);
            this.Controls.Add(this.ComboSetNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtSettlementNo);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateSettlement);
            this.Controls.Add(this.label45);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmModifySettlement";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات مستند تسوية";
            this.Load += new System.EventHandler(this.FrmModifySettlement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSettlementNo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateSettlement;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboSetNo;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource settlementsBindingSource;
        private AuditorDataSetTableAdapters.SettlementsTableAdapter settlementsTableAdapter;
        private System.Windows.Forms.BindingSource auditorDataSetBindingSource;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
    }
}
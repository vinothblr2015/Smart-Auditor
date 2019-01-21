namespace Auditor
{
    partial class FrmModifyTelNo
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
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboTelNo = new System.Windows.Forms.ComboBox();
            this.telNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtTelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telNoTableAdapter = new Auditor.AuditorDataSetTableAdapters.TelNoTableAdapter();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telNoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(130, 86);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(234, 30);
            this.ComboLocation.TabIndex = 3;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.SelectedIndexChanged += new System.EventHandler(this.ComboLocation_SelectedIndexChanged);
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
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(130, 124);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(405, 81);
            this.TxtNotes.TabIndex = 4;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(33, 123);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 71;
            this.label41.Text = "ملاحظات";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(33, 85);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 32);
            this.label42.TabIndex = 70;
            this.label42.Text = "اسم الجهة";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(353, 231);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(81, 231);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 73;
            this.label2.Text = "رقم التليفون";
            // 
            // ComboTelNo
            // 
            this.ComboTelNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboTelNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboTelNo.DataSource = this.telNoBindingSource;
            this.ComboTelNo.DisplayMember = "TelNo";
            this.ComboTelNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTelNo.FormattingEnabled = true;
            this.ComboTelNo.Location = new System.Drawing.Point(130, 15);
            this.ComboTelNo.Name = "ComboTelNo";
            this.ComboTelNo.Size = new System.Drawing.Size(234, 30);
            this.ComboTelNo.TabIndex = 0;
            this.ComboTelNo.ValueMember = "ID";
            this.ComboTelNo.SelectedIndexChanged += new System.EventHandler(this.ComboTelNo_SelectedIndexChanged);
            // 
            // telNoBindingSource
            // 
            this.telNoBindingSource.DataMember = "TelNo";
            this.telNoBindingSource.DataSource = this.auditorDataSet;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(217, 231);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtTelNo
            // 
            this.TxtTelNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTelNo.Location = new System.Drawing.Point(130, 51);
            this.TxtTelNo.Name = "TxtTelNo";
            this.TxtTelNo.Size = new System.Drawing.Size(234, 29);
            this.TxtTelNo.TabIndex = 74;
            this.TxtTelNo.TextChanged += new System.EventHandler(this.TxtTelNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 75;
            this.label1.Text = "رقم التليفون";
            // 
            // telNoTableAdapter
            // 
            this.telNoTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModifyTelNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(549, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTelNo);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.ComboTelNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmModifyTelNo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات رقم تليفون";
            this.Load += new System.EventHandler(this.FrmModifyTelNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telNoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboTelNo;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtTelNo;
        private System.Windows.Forms.Label label1;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource telNoBindingSource;
        private AuditorDataSetTableAdapters.TelNoTableAdapter telNoTableAdapter;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
    }
}
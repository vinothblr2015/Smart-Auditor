namespace Auditor.Views.Locations
{
    partial class FrmNewLocation
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboSectors = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.sectorsTableAdapter = new Auditor.AuditorDataSetTableAdapters.SectorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(262, 199);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(101, 199);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(114, 33);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "حــفــظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Location = new System.Drawing.Point(101, 10);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(275, 29);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(4, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 32);
            this.label42.TabIndex = 51;
            this.label42.Text = "اسم الجهة";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(101, 83);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(275, 81);
            this.TxtNotes.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(4, 82);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 53;
            this.label41.Text = "ملاحظات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "القطاع";
            // 
            // ComboSectors
            // 
            this.ComboSectors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboSectors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboSectors.DataSource = this.sectorsBindingSource;
            this.ComboSectors.DisplayMember = "SectorName";
            this.ComboSectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSectors.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSectors.FormattingEnabled = true;
            this.ComboSectors.Location = new System.Drawing.Point(101, 45);
            this.ComboSectors.Name = "ComboSectors";
            this.ComboSectors.Size = new System.Drawing.Size(275, 30);
            this.ComboSectors.TabIndex = 56;
            this.ComboSectors.ValueMember = "ID";
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.auditorDataSet;
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNewLocation
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(387, 244);
            this.Controls.Add(this.ComboSectors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmNewLocation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة جهة عمل";
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboSectors;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private AuditorDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
    }
}
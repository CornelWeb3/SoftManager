namespace SoftManager
{
    partial class frmImportProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportProduse));
            this.chkBifeazaTot = new System.Windows.Forms.CheckBox();
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.cCHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCaleFisier = new System.Windows.Forms.Label();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.btnImportProduse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBifeazaTot
            // 
            this.chkBifeazaTot.AutoSize = true;
            this.chkBifeazaTot.BackColor = System.Drawing.Color.Transparent;
            this.chkBifeazaTot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBifeazaTot.Location = new System.Drawing.Point(12, 101);
            this.chkBifeazaTot.Name = "chkBifeazaTot";
            this.chkBifeazaTot.Size = new System.Drawing.Size(73, 17);
            this.chkBifeazaTot.TabIndex = 26;
            this.chkBifeazaTot.Text = "Bifeaza tot";
            this.chkBifeazaTot.UseVisualStyleBackColor = false;
            this.chkBifeazaTot.CheckedChanged += new System.EventHandler(this.chkBifeazaTot_CheckedChanged);
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCHK});
            this.dgImport.Location = new System.Drawing.Point(2, 133);
            this.dgImport.Name = "dgImport";
            this.dgImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgImport.Size = new System.Drawing.Size(893, 189);
            this.dgImport.TabIndex = 27;
            // 
            // cCHK
            // 
            this.cCHK.FalseValue = "nu";
            this.cCHK.HeaderText = "";
            this.cCHK.Name = "cCHK";
            this.cCHK.TrueValue = "da";
            this.cCHK.Width = 50;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.lblCaleFisier);
            this.GroupBox1.Controls.Add(this.btnIncarca);
            this.GroupBox1.Location = new System.Drawing.Point(12, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(909, 56);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Incarca fisier";
            // 
            // lblCaleFisier
            // 
            this.lblCaleFisier.AutoSize = true;
            this.lblCaleFisier.Location = new System.Drawing.Point(100, 25);
            this.lblCaleFisier.Name = "lblCaleFisier";
            this.lblCaleFisier.Size = new System.Drawing.Size(52, 13);
            this.lblCaleFisier.TabIndex = 1;
            this.lblCaleFisier.Text = "Cale fisier";
            // 
            // btnIncarca
            // 
            this.btnIncarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncarca.Location = new System.Drawing.Point(7, 20);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(75, 23);
            this.btnIncarca.TabIndex = 0;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // btnImportProduse
            // 
            this.btnImportProduse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportProduse.BackColor = System.Drawing.Color.Transparent;
            this.btnImportProduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportProduse.Image = global::SoftManager.Properties.Resources.database_add;
            this.btnImportProduse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportProduse.Location = new System.Drawing.Point(659, 358);
            this.btnImportProduse.Name = "btnImportProduse";
            this.btnImportProduse.Size = new System.Drawing.Size(107, 23);
            this.btnImportProduse.TabIndex = 36;
            this.btnImportProduse.Text = "Import produse";
            this.btnImportProduse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportProduse.UseVisualStyleBackColor = false;
            this.btnImportProduse.Click += new System.EventHandler(this.btnImportProduse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SoftManager.Properties.Resources.stop;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(801, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "I&nchide";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
            this.btnExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToExcel.Location = new System.Drawing.Point(12, 355);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(28, 28);
            this.btnExportToExcel.TabIndex = 34;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            // 
            // frmImportProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 393);
            this.Controls.Add(this.btnImportProduse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.chkBifeazaTot);
            this.Controls.Add(this.dgImport);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportProduse";
            this.Text = "frmImportProduse";
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkBifeazaTot;
        internal System.Windows.Forms.DataGridView dgImport;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn cCHK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblCaleFisier;
        internal System.Windows.Forms.Button btnIncarca;
        internal System.Windows.Forms.Button btnImportProduse;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnExportToExcel;
    }
}
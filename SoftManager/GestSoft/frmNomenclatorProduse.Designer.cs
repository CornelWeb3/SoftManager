namespace SoftManager
{
    partial class frmNomenclatorProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomenclatorProduse));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNomenclatorProduse = new System.Windows.Forms.ComboBox();
            this.rbNomenclatorCod = new System.Windows.Forms.RadioButton();
            this.rbNomenclatorDenumire = new System.Windows.Forms.RadioButton();
            this.dgNomenclator = new System.Windows.Forms.DataGridView();
            this.produsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNomenclator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNomenclatorProduse);
            this.groupBox1.Controls.Add(this.rbNomenclatorCod);
            this.groupBox1.Controls.Add(this.rbNomenclatorDenumire);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cautare produs";
            // 
            // cmbNomenclatorProduse
            // 
            this.cmbNomenclatorProduse.FormattingEnabled = true;
            this.cmbNomenclatorProduse.Location = new System.Drawing.Point(106, 29);
            this.cmbNomenclatorProduse.Name = "cmbNomenclatorProduse";
            this.cmbNomenclatorProduse.Size = new System.Drawing.Size(306, 21);
            this.cmbNomenclatorProduse.TabIndex = 2;
            this.cmbNomenclatorProduse.SelectedIndexChanged += new System.EventHandler(this.cmbNomenclatorProduse_SelectedIndexChanged);
            // 
            // rbNomenclatorCod
            // 
            this.rbNomenclatorCod.AutoSize = true;
            this.rbNomenclatorCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomenclatorCod.Location = new System.Drawing.Point(18, 61);
            this.rbNomenclatorCod.Name = "rbNomenclatorCod";
            this.rbNomenclatorCod.Size = new System.Drawing.Size(47, 17);
            this.rbNomenclatorCod.TabIndex = 1;
            this.rbNomenclatorCod.Text = "Cod:";
            this.rbNomenclatorCod.UseVisualStyleBackColor = true;
            this.rbNomenclatorCod.CheckedChanged += new System.EventHandler(this.rbNomenclatorCod_CheckedChanged);
            // 
            // rbNomenclatorDenumire
            // 
            this.rbNomenclatorDenumire.AutoSize = true;
            this.rbNomenclatorDenumire.Checked = true;
            this.rbNomenclatorDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomenclatorDenumire.Location = new System.Drawing.Point(18, 29);
            this.rbNomenclatorDenumire.Name = "rbNomenclatorDenumire";
            this.rbNomenclatorDenumire.Size = new System.Drawing.Size(73, 17);
            this.rbNomenclatorDenumire.TabIndex = 0;
            this.rbNomenclatorDenumire.TabStop = true;
            this.rbNomenclatorDenumire.Text = "Denumire:";
            this.rbNomenclatorDenumire.UseVisualStyleBackColor = true;
            this.rbNomenclatorDenumire.Click += new System.EventHandler(this.rbNomenclatorDenumire_Click);
            // 
            // dgNomenclator
            // 
            this.dgNomenclator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNomenclator.Location = new System.Drawing.Point(14, 134);
            this.dgNomenclator.Name = "dgNomenclator";
            this.dgNomenclator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNomenclator.Size = new System.Drawing.Size(853, 147);
            this.dgNomenclator.TabIndex = 1;
            this.dgNomenclator.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgNomenclator_RowPostPaint);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalveaza.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalveaza.Location = new System.Drawing.Point(388, 287);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(169, 30);
            this.btnSalveaza.TabIndex = 2;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // frmNomenclatorProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 329);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.dgNomenclator);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNomenclatorProduse";
            this.Text = "Nomenclator Produse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNomenclator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNomenclatorProduse;
        private System.Windows.Forms.RadioButton rbNomenclatorCod;
        private System.Windows.Forms.DataGridView dgNomenclator;
        private System.Windows.Forms.BindingSource produsBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.RadioButton rbNomenclatorDenumire;
        private System.Windows.Forms.Button btnSalveaza;
    }
}
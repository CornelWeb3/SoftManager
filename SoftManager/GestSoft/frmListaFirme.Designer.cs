namespace SoftManager
{
    partial class frmListaFirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFirme));
            this.btnAdaugaFirma = new System.Windows.Forms.Button();
            this.btnModificaFirma = new System.Windows.Forms.Button();
            this.btnStergeFirma = new System.Windows.Forms.Button();
            this.btnSelecteazaFirma = new System.Windows.Forms.Button();
            this.dgListaFirma = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugaFirma
            // 
            this.btnAdaugaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdaugaFirma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdaugaFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaFirma.Location = new System.Drawing.Point(18, 216);
            this.btnAdaugaFirma.Name = "btnAdaugaFirma";
            this.btnAdaugaFirma.Size = new System.Drawing.Size(109, 23);
            this.btnAdaugaFirma.TabIndex = 1;
            this.btnAdaugaFirma.Text = "Adauga firma";
            this.btnAdaugaFirma.UseVisualStyleBackColor = false;
            this.btnAdaugaFirma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificaFirma
            // 
            this.btnModificaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaFirma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnModificaFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaFirma.Location = new System.Drawing.Point(147, 216);
            this.btnModificaFirma.Name = "btnModificaFirma";
            this.btnModificaFirma.Size = new System.Drawing.Size(121, 23);
            this.btnModificaFirma.TabIndex = 2;
            this.btnModificaFirma.Text = "Modifica firma";
            this.btnModificaFirma.UseVisualStyleBackColor = false;
            this.btnModificaFirma.Click += new System.EventHandler(this.btnModificaFirma_Click);
            // 
            // btnStergeFirma
            // 
            this.btnStergeFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStergeFirma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStergeFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeFirma.Location = new System.Drawing.Point(288, 216);
            this.btnStergeFirma.Name = "btnStergeFirma";
            this.btnStergeFirma.Size = new System.Drawing.Size(126, 23);
            this.btnStergeFirma.TabIndex = 3;
            this.btnStergeFirma.Text = "Sterge firma";
            this.btnStergeFirma.UseVisualStyleBackColor = false;
            this.btnStergeFirma.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSelecteazaFirma
            // 
            this.btnSelecteazaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecteazaFirma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSelecteazaFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecteazaFirma.Location = new System.Drawing.Point(434, 216);
            this.btnSelecteazaFirma.Name = "btnSelecteazaFirma";
            this.btnSelecteazaFirma.Size = new System.Drawing.Size(146, 23);
            this.btnSelecteazaFirma.TabIndex = 4;
            this.btnSelecteazaFirma.Text = "Selecteaza firma curenta";
            this.btnSelecteazaFirma.UseVisualStyleBackColor = false;
            this.btnSelecteazaFirma.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgListaFirma
            // 
            this.dgListaFirma.AllowUserToAddRows = false;
            this.dgListaFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaFirma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaFirma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgListaFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFirma.Location = new System.Drawing.Point(18, 13);
            this.dgListaFirma.Name = "dgListaFirma";
            this.dgListaFirma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaFirma.Size = new System.Drawing.Size(705, 197);
            this.dgListaFirma.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(604, 216);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmListaFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 255);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgListaFirma);
            this.Controls.Add(this.btnSelecteazaFirma);
            this.Controls.Add(this.btnStergeFirma);
            this.Controls.Add(this.btnModificaFirma);
            this.Controls.Add(this.btnAdaugaFirma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaFirme";
            this.Text = "Listă Firme";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaFirma;
        private System.Windows.Forms.Button btnModificaFirma;
        private System.Windows.Forms.Button btnStergeFirma;
        private System.Windows.Forms.Button btnSelecteazaFirma;
        private System.Windows.Forms.DataGridView dgListaFirma;
        private System.Windows.Forms.Button btnRefresh;
    }
}
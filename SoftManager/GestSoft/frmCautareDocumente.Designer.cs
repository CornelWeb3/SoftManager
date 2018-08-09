namespace SoftManager
{
    partial class frmCautareDocumente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautareDocumente));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoProduse = new System.Windows.Forms.RadioButton();
            this.rdoFacturi = new System.Windows.Forms.RadioButton();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblCautaDupa = new System.Windows.Forms.Label();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.rdoCUI = new System.Windows.Forms.RadioButton();
            this.rdoDenumireClient = new System.Windows.Forms.RadioButton();
            this.rdoIdFactura = new System.Windows.Forms.RadioButton();
            this.rdoIdProdus = new System.Windows.Forms.RadioButton();
            this.rdoDenumire = new System.Windows.Forms.RadioButton();
            this.eroare = new System.Windows.Forms.ErrorProvider(this.components);
            this.rdoFirma = new System.Windows.Forms.RadioButton();
            this.rdoClienti = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroare)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.rdoClienti);
            this.GroupBox1.Controls.Add(this.rdoFirma);
            this.GroupBox1.Controls.Add(this.rdoProduse);
            this.GroupBox1.Controls.Add(this.rdoFacturi);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Location = new System.Drawing.Point(21, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(106, 137);
            this.GroupBox1.TabIndex = 44;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cauta";
            // 
            // rdoProduse
            // 
            this.rdoProduse.AutoSize = true;
            this.rdoProduse.Checked = true;
            this.rdoProduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoProduse.Location = new System.Drawing.Point(16, 17);
            this.rdoProduse.Name = "rdoProduse";
            this.rdoProduse.Size = new System.Drawing.Size(63, 17);
            this.rdoProduse.TabIndex = 0;
            this.rdoProduse.TabStop = true;
            this.rdoProduse.Text = "Produse";
            this.rdoProduse.UseVisualStyleBackColor = true;
            this.rdoProduse.Click += new System.EventHandler(this.rdoProduse_Click);
            // 
            // rdoFacturi
            // 
            this.rdoFacturi.AutoSize = true;
            this.rdoFacturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFacturi.Location = new System.Drawing.Point(16, 40);
            this.rdoFacturi.Name = "rdoFacturi";
            this.rdoFacturi.Size = new System.Drawing.Size(56, 17);
            this.rdoFacturi.TabIndex = 1;
            this.rdoFacturi.Text = "Facturi";
            this.rdoFacturi.UseVisualStyleBackColor = true;
            this.rdoFacturi.Click += new System.EventHandler(this.rdoFacturi_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauta.BackColor = System.Drawing.Color.Silver;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauta.Location = new System.Drawing.Point(294, 79);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(70, 23);
            this.btnCauta.TabIndex = 49;
            this.btnCauta.Text = "&Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblCautaDupa
            // 
            this.lblCautaDupa.AutoSize = true;
            this.lblCautaDupa.BackColor = System.Drawing.Color.Transparent;
            this.lblCautaDupa.Location = new System.Drawing.Point(315, 12);
            this.lblCautaDupa.Name = "lblCautaDupa";
            this.lblCautaDupa.Size = new System.Drawing.Size(55, 13);
            this.lblCautaDupa.TabIndex = 47;
            this.lblCautaDupa.Text = "Denumire:";
            // 
            // txtCauta
            // 
            this.txtCauta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauta.Location = new System.Drawing.Point(309, 33);
            this.txtCauta.MaxLength = 30;
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(55, 20);
            this.txtCauta.TabIndex = 48;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.GridColor = System.Drawing.Color.SteelBlue;
            this.dg.Location = new System.Drawing.Point(12, 155);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(721, 187);
            this.dg.TabIndex = 50;
            // 
            // grpMain
            // 
            this.grpMain.BackColor = System.Drawing.Color.Transparent;
            this.grpMain.Controls.Add(this.rdoCUI);
            this.grpMain.Controls.Add(this.rdoDenumireClient);
            this.grpMain.Controls.Add(this.rdoIdFactura);
            this.grpMain.Controls.Add(this.rdoIdProdus);
            this.grpMain.Controls.Add(this.rdoDenumire);
            this.grpMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMain.Location = new System.Drawing.Point(142, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(134, 137);
            this.grpMain.TabIndex = 45;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Cauta dupa:";
            // 
            // rdoCUI
            // 
            this.rdoCUI.AutoSize = true;
            this.rdoCUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoCUI.Location = new System.Drawing.Point(11, 87);
            this.rdoCUI.Name = "rdoCUI";
            this.rdoCUI.Size = new System.Drawing.Size(42, 17);
            this.rdoCUI.TabIndex = 10;
            this.rdoCUI.Text = "CUI";
            this.rdoCUI.UseVisualStyleBackColor = true;
            // 
            // rdoDenumireClient
            // 
            this.rdoDenumireClient.AutoSize = true;
            this.rdoDenumireClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDenumireClient.Location = new System.Drawing.Point(11, 110);
            this.rdoDenumireClient.Name = "rdoDenumireClient";
            this.rdoDenumireClient.Size = new System.Drawing.Size(98, 17);
            this.rdoDenumireClient.TabIndex = 9;
            this.rdoDenumireClient.Text = "Denumire Client";
            this.rdoDenumireClient.UseVisualStyleBackColor = true;
            // 
            // rdoIdFactura
            // 
            this.rdoIdFactura.AutoSize = true;
            this.rdoIdFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoIdFactura.Location = new System.Drawing.Point(11, 67);
            this.rdoIdFactura.Name = "rdoIdFactura";
            this.rdoIdFactura.Size = new System.Drawing.Size(69, 17);
            this.rdoIdFactura.TabIndex = 2;
            this.rdoIdFactura.Text = "IdFactura";
            this.rdoIdFactura.UseVisualStyleBackColor = true;
            // 
            // rdoIdProdus
            // 
            this.rdoIdProdus.AutoSize = true;
            this.rdoIdProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoIdProdus.Location = new System.Drawing.Point(11, 44);
            this.rdoIdProdus.Name = "rdoIdProdus";
            this.rdoIdProdus.Size = new System.Drawing.Size(66, 17);
            this.rdoIdProdus.TabIndex = 1;
            this.rdoIdProdus.Text = "IdProdus";
            this.rdoIdProdus.UseVisualStyleBackColor = true;
            this.rdoIdProdus.Click += new System.EventHandler(this.rdoIdProdus_Click);
            // 
            // rdoDenumire
            // 
            this.rdoDenumire.AutoSize = true;
            this.rdoDenumire.Checked = true;
            this.rdoDenumire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDenumire.Location = new System.Drawing.Point(11, 21);
            this.rdoDenumire.Name = "rdoDenumire";
            this.rdoDenumire.Size = new System.Drawing.Size(69, 17);
            this.rdoDenumire.TabIndex = 0;
            this.rdoDenumire.TabStop = true;
            this.rdoDenumire.Text = "Denumire";
            this.rdoDenumire.UseVisualStyleBackColor = true;
            this.rdoDenumire.Click += new System.EventHandler(this.rdoDenumire_Click);
            // 
            // eroare
            // 
            this.eroare.ContainerControl = this;
            // 
            // rdoFirma
            // 
            this.rdoFirma.AutoSize = true;
            this.rdoFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFirma.Location = new System.Drawing.Point(16, 63);
            this.rdoFirma.Name = "rdoFirma";
            this.rdoFirma.Size = new System.Drawing.Size(49, 17);
            this.rdoFirma.TabIndex = 2;
            this.rdoFirma.Text = "Firma";
            this.rdoFirma.UseVisualStyleBackColor = true;
            this.rdoFirma.Click += new System.EventHandler(this.rdoFirma_Click);
            // 
            // rdoClienti
            // 
            this.rdoClienti.AutoSize = true;
            this.rdoClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoClienti.Location = new System.Drawing.Point(16, 87);
            this.rdoClienti.Name = "rdoClienti";
            this.rdoClienti.Size = new System.Drawing.Size(52, 17);
            this.rdoClienti.TabIndex = 3;
            this.rdoClienti.Text = "Clienti";
            this.rdoClienti.UseVisualStyleBackColor = true;
            this.rdoClienti.Click += new System.EventHandler(this.rdoClienti_Click);
            // 
            // frmCautareDocumente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 350);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblCautaDupa);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.grpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCautareDocumente";
            this.Text = "Cautare Documente";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rdoProduse;
        internal System.Windows.Forms.RadioButton rdoFacturi;
        internal System.Windows.Forms.Button btnCauta;
        internal System.Windows.Forms.Label lblCautaDupa;
        internal System.Windows.Forms.TextBox txtCauta;
        internal System.Windows.Forms.DataGridView dg;
        internal System.Windows.Forms.GroupBox grpMain;
        internal System.Windows.Forms.RadioButton rdoCUI;
        internal System.Windows.Forms.RadioButton rdoDenumireClient;
        internal System.Windows.Forms.RadioButton rdoIdFactura;
        internal System.Windows.Forms.RadioButton rdoIdProdus;
        internal System.Windows.Forms.RadioButton rdoDenumire;
        internal System.Windows.Forms.ErrorProvider eroare;
        internal System.Windows.Forms.RadioButton rdoClienti;
        internal System.Windows.Forms.RadioButton rdoFirma;

    }
}
namespace SoftManager
{
    partial class frmCautareCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCautareCont));
            this.dg = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoUtilizator = new System.Windows.Forms.RadioButton();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.lblCautaDupa = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.eroare = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroare)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg.GridColor = System.Drawing.Color.SteelBlue;
            this.dg.Location = new System.Drawing.Point(12, 108);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(752, 141);
            this.dg.TabIndex = 51;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.rdoUtilizator);
            this.GroupBox1.Controls.Add(this.rdoEmail);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(114, 75);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cauta dupa";
            // 
            // rdoUtilizator
            // 
            this.rdoUtilizator.AutoSize = true;
            this.rdoUtilizator.Checked = true;
            this.rdoUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoUtilizator.Location = new System.Drawing.Point(16, 17);
            this.rdoUtilizator.Name = "rdoUtilizator";
            this.rdoUtilizator.Size = new System.Drawing.Size(64, 17);
            this.rdoUtilizator.TabIndex = 0;
            this.rdoUtilizator.TabStop = true;
            this.rdoUtilizator.Text = "Utilizator";
            this.rdoUtilizator.UseVisualStyleBackColor = true;
            this.rdoUtilizator.Click += new System.EventHandler(this.rdoUtilizator_Click);
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmail.Location = new System.Drawing.Point(16, 40);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(49, 17);
            this.rdoEmail.TabIndex = 1;
            this.rdoEmail.Text = "Email";
            this.rdoEmail.UseVisualStyleBackColor = true;
            this.rdoEmail.Click += new System.EventHandler(this.rdoChitante_Click);
            // 
            // txtCauta
            // 
            this.txtCauta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauta.Location = new System.Drawing.Point(257, 27);
            this.txtCauta.MaxLength = 30;
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(96, 20);
            this.txtCauta.TabIndex = 53;
            // 
            // lblCautaDupa
            // 
            this.lblCautaDupa.AutoSize = true;
            this.lblCautaDupa.BackColor = System.Drawing.Color.Transparent;
            this.lblCautaDupa.Location = new System.Drawing.Point(146, 29);
            this.lblCautaDupa.Name = "lblCautaDupa";
            this.lblCautaDupa.Size = new System.Drawing.Size(79, 13);
            this.lblCautaDupa.TabIndex = 54;
            this.lblCautaDupa.Text = "Nume utilizator:";
            // 
            // btnCauta
            // 
            this.btnCauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauta.BackColor = System.Drawing.Color.Transparent;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauta.Location = new System.Drawing.Point(257, 64);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(70, 23);
            this.btnCauta.TabIndex = 55;
            this.btnCauta.Text = "&Cauta";
            this.btnCauta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // eroare
            // 
            this.eroare.ContainerControl = this;
            // 
            // frmCautareCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 261);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblCautaDupa);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCautareCont";
            this.Text = "Cautare Cont";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dg;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rdoUtilizator;
        internal System.Windows.Forms.RadioButton rdoEmail;
        internal System.Windows.Forms.TextBox txtCauta;
        internal System.Windows.Forms.Label lblCautaDupa;
        internal System.Windows.Forms.Button btnCauta;
        internal System.Windows.Forms.ErrorProvider eroare;
    }
}
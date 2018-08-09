namespace SoftManager
{
    partial class Bon_de_transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bon_de_transfer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbGestiuneDestinatie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGestiuneSursa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDataFactura = new System.Windows.Forms.DateTimePicker();
            this.tbNumarBonFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgIntroducereDocument = new System.Windows.Forms.DataGridView();
            this.CodProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCantitateDisponibila = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbPretVanzare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.tbUM = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbDenumireProdus = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntroducereDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.cmbGestiuneDestinatie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbGestiuneSursa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestiuni";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(226, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Adauga / modifica gestiune";
            // 
            // cmbGestiuneDestinatie
            // 
            this.cmbGestiuneDestinatie.FormattingEnabled = true;
            this.cmbGestiuneDestinatie.Items.AddRange(new object[] {
            "Pipera",
            "Berceni"});
            this.cmbGestiuneDestinatie.Location = new System.Drawing.Point(136, 52);
            this.cmbGestiuneDestinatie.Name = "cmbGestiuneDestinatie";
            this.cmbGestiuneDestinatie.Size = new System.Drawing.Size(242, 21);
            this.cmbGestiuneDestinatie.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gestiune destinatie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestiune sursa:";
            // 
            // cmbGestiuneSursa
            // 
            this.cmbGestiuneSursa.FormattingEnabled = true;
            this.cmbGestiuneSursa.Items.AddRange(new object[] {
            "Pipera",
            "Berceni"});
            this.cmbGestiuneSursa.Location = new System.Drawing.Point(136, 19);
            this.cmbGestiuneSursa.Name = "cmbGestiuneSursa";
            this.cmbGestiuneSursa.Size = new System.Drawing.Size(242, 21);
            this.cmbGestiuneSursa.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDataFactura);
            this.groupBox2.Controls.Add(this.tbNumarBonFiscal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestiuni";
            // 
            // tbDataFactura
            // 
            this.tbDataFactura.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataFactura.CustomFormat = "dd MMM. yyyy";
            this.tbDataFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDataFactura.Location = new System.Drawing.Point(81, 52);
            this.tbDataFactura.Margin = new System.Windows.Forms.Padding(2);
            this.tbDataFactura.Name = "tbDataFactura";
            this.tbDataFactura.Size = new System.Drawing.Size(105, 20);
            this.tbDataFactura.TabIndex = 50;
            this.tbDataFactura.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // tbNumarBonFiscal
            // 
            this.tbNumarBonFiscal.Location = new System.Drawing.Point(86, 19);
            this.tbNumarBonFiscal.Name = "tbNumarBonFiscal";
            this.tbNumarBonFiscal.Size = new System.Drawing.Size(100, 20);
            this.tbNumarBonFiscal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgIntroducereDocument);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbTotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbCantitateDisponibila);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.tbPretVanzare);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.tbCantitate);
            this.groupBox3.Controls.Add(this.tbUM);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.cmbDenumireProdus);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(791, 346);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produse stoc";
            // 
            // dgIntroducereDocument
            // 
            this.dgIntroducereDocument.AllowUserToAddRows = false;
            this.dgIntroducereDocument.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgIntroducereDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIntroducereDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProdus,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Valoare});
            this.dgIntroducereDocument.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgIntroducereDocument.Location = new System.Drawing.Point(0, 84);
            this.dgIntroducereDocument.Name = "dgIntroducereDocument";
            this.dgIntroducereDocument.Size = new System.Drawing.Size(785, 203);
            this.dgIntroducereDocument.TabIndex = 66;
            // 
            // CodProdus
            // 
            this.CodProdus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodProdus.HeaderText = "CodProdus";
            this.CodProdus.Name = "CodProdus";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "DenumireProdus";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "U/M";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantitate";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pret unitar";
            this.Column5.Name = "Column5";
            // 
            // Valoare
            // 
            this.Valoare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valoare.HeaderText = "Valoare";
            this.Valoare.Name = "Valoare";
            this.Valoare.ToolTipText = "Valoare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Total valoare transferat:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(685, 293);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "buc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Cantitate disponibila:";
            // 
            // tbCantitateDisponibila
            // 
            this.tbCantitateDisponibila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantitateDisponibila.Location = new System.Drawing.Point(495, 58);
            this.tbCantitateDisponibila.Name = "tbCantitateDisponibila";
            this.tbCantitateDisponibila.Size = new System.Drawing.Size(49, 20);
            this.tbCantitateDisponibila.TabIndex = 61;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(550, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(85, 13);
            this.label32.TabIndex = 60;
            this.label32.Text = "Pret unitar(RON)\r\n";
            // 
            // tbPretVanzare
            // 
            this.tbPretVanzare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPretVanzare.Location = new System.Drawing.Point(553, 32);
            this.tbPretVanzare.Name = "tbPretVanzare";
            this.tbPretVanzare.Size = new System.Drawing.Size(49, 20);
            this.tbPretVanzare.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 58;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(492, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 57;
            this.label30.Text = "Cantitate:";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantitate.Location = new System.Drawing.Point(495, 32);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(49, 20);
            this.tbCantitate.TabIndex = 56;
            // 
            // tbUM
            // 
            this.tbUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUM.Location = new System.Drawing.Point(440, 33);
            this.tbUM.Name = "tbUM";
            this.tbUM.Size = new System.Drawing.Size(49, 20);
            this.tbUM.TabIndex = 55;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(437, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 13);
            this.label29.TabIndex = 54;
            this.label29.Text = "U.Masura:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(236, 16);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(173, 13);
            this.linkLabel3.TabIndex = 45;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Nomenclator produse/servicii";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Denumire produs:";
            // 
            // cmbDenumireProdus
            // 
            this.cmbDenumireProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDenumireProdus.FormattingEnabled = true;
            this.cmbDenumireProdus.Location = new System.Drawing.Point(3, 32);
            this.cmbDenumireProdus.Name = "cmbDenumireProdus";
            this.cmbDenumireProdus.Size = new System.Drawing.Size(428, 21);
            this.cmbDenumireProdus.TabIndex = 43;
            this.cmbDenumireProdus.SelectedIndexChanged += new System.EventHandler(this.cmbDenumireProdus_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inregistreza bon transfer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Anuleaza modificari";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Bon_de_transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bon_de_transfer";
            this.Text = "Transfer gestiuni";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntroducereDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbGestiuneDestinatie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGestiuneSursa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNumarBonFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbDenumireProdus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.TextBox tbUM;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCantitateDisponibila;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbPretVanzare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker tbDataFactura;
        private System.Windows.Forms.DataGridView dgIntroducereDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
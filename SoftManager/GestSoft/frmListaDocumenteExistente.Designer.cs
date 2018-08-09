namespace SoftManager
{
    partial class frmListaDocumenteExistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDocumenteExistente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.rbDoarFurnizorul = new System.Windows.Forms.RadioButton();
            this.rbTotiFurnizorii = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataInitialaTM = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnDocumentNou = new System.Windows.Forms.Button();
            this.btnVizualizeaza = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dgFacturi = new System.Windows.Forms.DataGridView();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.dataFinalaTM = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbNumarDocument = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturi)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFurnizor);
            this.groupBox1.Controls.Add(this.rbDoarFurnizorul);
            this.groupBox1.Controls.Add(this.rbTotiFurnizorii);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Furnizor";
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(132, 54);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(242, 21);
            this.cmbFurnizor.TabIndex = 5;
            // 
            // rbDoarFurnizorul
            // 
            this.rbDoarFurnizorul.AutoSize = true;
            this.rbDoarFurnizorul.Location = new System.Drawing.Point(6, 54);
            this.rbDoarFurnizorul.Name = "rbDoarFurnizorul";
            this.rbDoarFurnizorul.Size = new System.Drawing.Size(108, 17);
            this.rbDoarFurnizorul.TabIndex = 3;
            this.rbDoarFurnizorul.TabStop = true;
            this.rbDoarFurnizorul.Text = "Doar furnizorul";
            this.rbDoarFurnizorul.UseVisualStyleBackColor = true;
            this.rbDoarFurnizorul.Click += new System.EventHandler(this.rbDoarFurnizorul_Click);
            // 
            // rbTotiFurnizorii
            // 
            this.rbTotiFurnizorii.AutoSize = true;
            this.rbTotiFurnizorii.Location = new System.Drawing.Point(6, 31);
            this.rbTotiFurnizorii.Name = "rbTotiFurnizorii";
            this.rbTotiFurnizorii.Size = new System.Drawing.Size(99, 17);
            this.rbTotiFurnizorii.TabIndex = 2;
            this.rbTotiFurnizorii.TabStop = true;
            this.rbTotiFurnizorii.Text = "Toti furnizorii";
            this.rbTotiFurnizorii.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataFinalaTM);
            this.groupBox2.Controls.Add(this.dataInitialaTM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(413, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataInitialaTM
            // 
            this.dataInitialaTM.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInitialaTM.CustomFormat = "dd MMM. yyyy";
            this.dataInitialaTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInitialaTM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInitialaTM.Location = new System.Drawing.Point(73, 14);
            this.dataInitialaTM.Margin = new System.Windows.Forms.Padding(2);
            this.dataInitialaTM.Name = "dataInitialaTM";
            this.dataInitialaTM.Size = new System.Drawing.Size(105, 20);
            this.dataInitialaTM.TabIndex = 18;
            this.dataInitialaTM.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data finala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data initiala:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 47);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sortare";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(207, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Valoare";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(149, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Data";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(82, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Numar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Furnizor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(422, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 47);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Documente cu NIR";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toate",
            "Doar documente cu NIR",
            "Doar documente fara NIR "});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(619, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 47);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tip document";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Toate",
            "Facturi",
            "Avize",
            "Bonuri transfer"});
            this.comboBox2.Location = new System.Drawing.Point(13, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // btnDocumentNou
            // 
            this.btnDocumentNou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocumentNou.AutoSize = true;
            this.btnDocumentNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentNou.Location = new System.Drawing.Point(18, 420);
            this.btnDocumentNou.Name = "btnDocumentNou";
            this.btnDocumentNou.Size = new System.Drawing.Size(114, 23);
            this.btnDocumentNou.TabIndex = 12;
            this.btnDocumentNou.Text = "Document nou";
            this.btnDocumentNou.UseVisualStyleBackColor = true;
            // 
            // btnVizualizeaza
            // 
            this.btnVizualizeaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVizualizeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizualizeaza.Location = new System.Drawing.Point(161, 420);
            this.btnVizualizeaza.Name = "btnVizualizeaza";
            this.btnVizualizeaza.Size = new System.Drawing.Size(113, 23);
            this.btnVizualizeaza.TabIndex = 13;
            this.btnVizualizeaza.Text = "Vizualizeaza";
            this.btnVizualizeaza.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(329, 420);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(114, 23);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnSterge
            // 
            this.btnSterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(486, 420);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(107, 23);
            this.btnSterge.TabIndex = 15;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            // 
            // dgFacturi
            // 
            this.dgFacturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturi.Location = new System.Drawing.Point(18, 218);
            this.dgFacturi.Name = "dgFacturi";
            this.dgFacturi.Size = new System.Drawing.Size(746, 199);
            this.dgFacturi.TabIndex = 17;
            // 
            // btnGenerare
            // 
            this.btnGenerare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.Location = new System.Drawing.Point(637, 420);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(127, 23);
            this.btnGenerare.TabIndex = 16;
            this.btnGenerare.Text = "Genereaza NIR";
            this.btnGenerare.UseVisualStyleBackColor = true;
            // 
            // dataFinalaTM
            // 
            this.dataFinalaTM.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinalaTM.CustomFormat = "dd MMM. yyyy";
            this.dataFinalaTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinalaTM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataFinalaTM.Location = new System.Drawing.Point(72, 54);
            this.dataFinalaTM.Margin = new System.Windows.Forms.Padding(2);
            this.dataFinalaTM.Name = "dataFinalaTM";
            this.dataFinalaTM.Size = new System.Drawing.Size(106, 20);
            this.dataFinalaTM.TabIndex = 19;
            this.dataFinalaTM.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbNumarDocument);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(619, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(145, 47);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Numar document";
            // 
            // tbNumarDocument
            // 
            this.tbNumarDocument.Location = new System.Drawing.Point(7, 20);
            this.tbNumarDocument.Name = "tbNumarDocument";
            this.tbNumarDocument.Size = new System.Drawing.Size(100, 20);
            this.tbNumarDocument.TabIndex = 0;
            // 
            // frmListaDocumenteExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 455);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dgFacturi);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnVizualizeaza);
            this.Controls.Add(this.btnDocumentNou);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaDocumenteExistente";
            this.Text = "Lista Documente Intrare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturi)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFurnizor;
        private System.Windows.Forms.RadioButton rbDoarFurnizorul;
        private System.Windows.Forms.RadioButton rbTotiFurnizorii;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDocumentNou;
        private System.Windows.Forms.Button btnVizualizeaza;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dgFacturi;
        private System.Windows.Forms.Button btnGenerare;
        private System.Windows.Forms.DateTimePicker dataInitialaTM;
        private System.Windows.Forms.DateTimePicker dataFinalaTM;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbNumarDocument;
    }
}
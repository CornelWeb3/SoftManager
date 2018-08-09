namespace SoftManager
{
    partial class frmSituatieInventar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSituatieInventar));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbGestiune = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCantitativValoric = new System.Windows.Forms.RadioButton();
            this.rbCantitativ = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCautare = new System.Windows.Forms.RadioButton();
            this.tbCautareProdus = new System.Windows.Forms.TextBox();
            this.cmbCautareProdus = new System.Windows.Forms.ComboBox();
            this.rbDenumire = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbGestiune);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 54);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestiune";
            // 
            // cmbGestiune
            // 
            this.cmbGestiune.FormattingEnabled = true;
            this.cmbGestiune.Items.AddRange(new object[] {
            "Pipera",
            "Berceni"});
            this.cmbGestiune.Location = new System.Drawing.Point(6, 19);
            this.cmbGestiune.Name = "cmbGestiune";
            this.cmbGestiune.Size = new System.Drawing.Size(145, 21);
            this.cmbGestiune.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCantitativValoric);
            this.groupBox2.Controls.Add(this.rbCantitativ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(190, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vizualizare stoc";
            // 
            // rbCantitativValoric
            // 
            this.rbCantitativValoric.AutoSize = true;
            this.rbCantitativValoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCantitativValoric.Location = new System.Drawing.Point(6, 37);
            this.rbCantitativValoric.Name = "rbCantitativValoric";
            this.rbCantitativValoric.Size = new System.Drawing.Size(103, 17);
            this.rbCantitativValoric.TabIndex = 1;
            this.rbCantitativValoric.Text = "Cantitativ-valoric";
            this.rbCantitativValoric.UseVisualStyleBackColor = true;
            // 
            // rbCantitativ
            // 
            this.rbCantitativ.AutoSize = true;
            this.rbCantitativ.Checked = true;
            this.rbCantitativ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCantitativ.Location = new System.Drawing.Point(6, 19);
            this.rbCantitativ.Name = "rbCantitativ";
            this.rbCantitativ.Size = new System.Drawing.Size(69, 17);
            this.rbCantitativ.TabIndex = 0;
            this.rbCantitativ.TabStop = true;
            this.rbCantitativ.Text = "Cantitativ";
            this.rbCantitativ.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCautare);
            this.groupBox1.Controls.Add(this.tbCautareProdus);
            this.groupBox1.Controls.Add(this.cmbCautareProdus);
            this.groupBox1.Controls.Add(this.rbDenumire);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrare produs";
            // 
            // rbCautare
            // 
            this.rbCautare.AutoSize = true;
            this.rbCautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCautare.Location = new System.Drawing.Point(6, 57);
            this.rbCautare.Name = "rbCautare";
            this.rbCautare.Size = new System.Drawing.Size(97, 17);
            this.rbCautare.TabIndex = 7;
            this.rbCautare.Text = "Cautare produs";
            this.rbCautare.UseVisualStyleBackColor = true;
            this.rbCautare.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // tbCautareProdus
            // 
            this.tbCautareProdus.Location = new System.Drawing.Point(103, 57);
            this.tbCautareProdus.Name = "tbCautareProdus";
            this.tbCautareProdus.Size = new System.Drawing.Size(252, 20);
            this.tbCautareProdus.TabIndex = 6;
            this.tbCautareProdus.Visible = false;
            // 
            // cmbCautareProdus
            // 
            this.cmbCautareProdus.FormattingEnabled = true;
            this.cmbCautareProdus.Location = new System.Drawing.Point(103, 27);
            this.cmbCautareProdus.Name = "cmbCautareProdus";
            this.cmbCautareProdus.Size = new System.Drawing.Size(252, 21);
            this.cmbCautareProdus.TabIndex = 5;
            // 
            // rbDenumire
            // 
            this.rbDenumire.AutoSize = true;
            this.rbDenumire.Checked = true;
            this.rbDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDenumire.Location = new System.Drawing.Point(6, 27);
            this.rbDenumire.Name = "rbDenumire";
            this.rbDenumire.Size = new System.Drawing.Size(91, 17);
            this.rbDenumire.TabIndex = 2;
            this.rbDenumire.TabStop = true;
            this.rbDenumire.Text = "Doar produsul";
            this.rbDenumire.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Afiseaza situatie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSituatieInventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSituatieInventar";
            this.Text = "frmSituatieInventar";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbGestiune;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCantitativValoric;
        private System.Windows.Forms.RadioButton rbCantitativ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCautareProdus;
        private System.Windows.Forms.RadioButton rbDenumire;
        private System.Windows.Forms.RadioButton rbCautare;
        private System.Windows.Forms.TextBox tbCautareProdus;
        private System.Windows.Forms.Button button1;
    }
}
using SoftManager;
namespace SoftManager
{
    partial class frmVizualizareStoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVizualizareStoc));
            this.dgVizualizareStoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitateMasuraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.softManagerDataSetProdusFinal = new SoftManager.SoftManagerDataSetProdusFinal();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCautareProdus = new System.Windows.Forms.ComboBox();
            this.chkDoarProdusul = new System.Windows.Forms.CheckBox();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.rbDenumire = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCantitativValoric = new System.Windows.Forms.RadioButton();
            this.rbCantitativ = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbGestiune = new System.Windows.Forms.ComboBox();
            this.tbValoareStoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCorectieStoc = new System.Windows.Forms.Button();
            this.btnListaCorectiiStoc = new System.Windows.Forms.Button();
            this.produsTableAdapter2 = new SoftManager.SoftManagerDataSetProdusFinalTableAdapters.ProdusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVizualizareStoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softManagerDataSetProdusFinal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVizualizareStoc
            // 
            this.dgVizualizareStoc.AutoGenerateColumns = false;
            this.dgVizualizareStoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVizualizareStoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVizualizareStoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.unitateMasuraDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.pretVanzareDataGridViewTextBoxColumn,
            this.tipProdusDataGridViewTextBoxColumn});
            this.dgVizualizareStoc.DataSource = this.produsBindingSource2;
            this.dgVizualizareStoc.Location = new System.Drawing.Point(3, 143);
            this.dgVizualizareStoc.Name = "dgVizualizareStoc";
            this.dgVizualizareStoc.Size = new System.Drawing.Size(949, 334);
            this.dgVizualizareStoc.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Denumire";
            this.dataGridViewTextBoxColumn2.HeaderText = "Denumire";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // unitateMasuraDataGridViewTextBoxColumn
            // 
            this.unitateMasuraDataGridViewTextBoxColumn.DataPropertyName = "UnitateMasura";
            this.unitateMasuraDataGridViewTextBoxColumn.HeaderText = "UnitateMasura";
            this.unitateMasuraDataGridViewTextBoxColumn.Name = "unitateMasuraDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantitate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantitate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PretCumparare";
            this.dataGridViewTextBoxColumn4.HeaderText = "PretCumparare";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // pretVanzareDataGridViewTextBoxColumn
            // 
            this.pretVanzareDataGridViewTextBoxColumn.DataPropertyName = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.HeaderText = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.Name = "pretVanzareDataGridViewTextBoxColumn";
            // 
            // tipProdusDataGridViewTextBoxColumn
            // 
            this.tipProdusDataGridViewTextBoxColumn.DataPropertyName = "TipProdus";
            this.tipProdusDataGridViewTextBoxColumn.HeaderText = "TipProdus";
            this.tipProdusDataGridViewTextBoxColumn.Name = "tipProdusDataGridViewTextBoxColumn";
            // 
            // produsBindingSource2
            // 
            this.produsBindingSource2.DataMember = "Produs";
            this.produsBindingSource2.DataSource = this.softManagerDataSetProdusFinal;
            // 
            // softManagerDataSetProdusFinal
            // 
            this.softManagerDataSetProdusFinal.DataSetName = "SoftManagerDataSetProdusFinal";
            this.softManagerDataSetProdusFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCautareProdus);
            this.groupBox1.Controls.Add(this.chkDoarProdusul);
            this.groupBox1.Controls.Add(this.rbCod);
            this.groupBox1.Controls.Add(this.rbDenumire);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cautare produs";
            // 
            // cmbCautareProdus
            // 
            this.cmbCautareProdus.FormattingEnabled = true;
            this.cmbCautareProdus.Location = new System.Drawing.Point(287, 31);
            this.cmbCautareProdus.Name = "cmbCautareProdus";
            this.cmbCautareProdus.Size = new System.Drawing.Size(306, 21);
            this.cmbCautareProdus.TabIndex = 5;
            this.cmbCautareProdus.SelectedIndexChanged += new System.EventHandler(this.cmbCautareProdus_SelectedIndexChanged);
            // 
            // chkDoarProdusul
            // 
            this.chkDoarProdusul.AutoSize = true;
            this.chkDoarProdusul.Location = new System.Drawing.Point(20, 31);
            this.chkDoarProdusul.Name = "chkDoarProdusul";
            this.chkDoarProdusul.Size = new System.Drawing.Size(105, 17);
            this.chkDoarProdusul.TabIndex = 4;
            this.chkDoarProdusul.Text = "Doar produsul";
            this.chkDoarProdusul.UseVisualStyleBackColor = true;
            this.chkDoarProdusul.CheckedChanged += new System.EventHandler(this.chkDoarProdusul_CheckedChanged);
            this.chkDoarProdusul.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDoarProdusul_MouseClick);
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(165, 63);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(47, 17);
            this.rbCod.TabIndex = 3;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "Cod";
            this.rbCod.UseVisualStyleBackColor = true;
            this.rbCod.Click += new System.EventHandler(this.rbCod_Click);
            // 
            // rbDenumire
            // 
            this.rbDenumire.AutoSize = true;
            this.rbDenumire.Location = new System.Drawing.Point(165, 30);
            this.rbDenumire.Name = "rbDenumire";
            this.rbDenumire.Size = new System.Drawing.Size(78, 17);
            this.rbDenumire.TabIndex = 2;
            this.rbDenumire.TabStop = true;
            this.rbDenumire.Text = "Denumire";
            this.rbDenumire.UseVisualStyleBackColor = true;
            this.rbDenumire.Click += new System.EventHandler(this.rbDenumire_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCantitativValoric);
            this.groupBox2.Controls.Add(this.rbCantitativ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(617, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vizualizare stoc";
            // 
            // rbCantitativValoric
            // 
            this.rbCantitativValoric.AutoSize = true;
            this.rbCantitativValoric.Location = new System.Drawing.Point(7, 64);
            this.rbCantitativValoric.Name = "rbCantitativValoric";
            this.rbCantitativValoric.Size = new System.Drawing.Size(121, 17);
            this.rbCantitativValoric.TabIndex = 1;
            this.rbCantitativValoric.Text = "Cantitativ-valoric";
            this.rbCantitativValoric.UseVisualStyleBackColor = true;
            this.rbCantitativValoric.CheckedChanged += new System.EventHandler(this.rbCantitativValoric_CheckedChanged);
            // 
            // rbCantitativ
            // 
            this.rbCantitativ.AutoSize = true;
            this.rbCantitativ.Checked = true;
            this.rbCantitativ.Location = new System.Drawing.Point(7, 31);
            this.rbCantitativ.Name = "rbCantitativ";
            this.rbCantitativ.Size = new System.Drawing.Size(79, 17);
            this.rbCantitativ.TabIndex = 0;
            this.rbCantitativ.TabStop = true;
            this.rbCantitativ.Text = "Cantitativ";
            this.rbCantitativ.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbGestiune);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(823, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestiune";
            // 
            // cmbGestiune
            // 
            this.cmbGestiune.FormattingEnabled = true;
            this.cmbGestiune.Items.AddRange(new object[] {
            "Pipera",
            "Berceni"});
            this.cmbGestiune.Location = new System.Drawing.Point(6, 31);
            this.cmbGestiune.Name = "cmbGestiune";
            this.cmbGestiune.Size = new System.Drawing.Size(119, 21);
            this.cmbGestiune.TabIndex = 0;
            this.cmbGestiune.SelectedIndexChanged += new System.EventHandler(this.cmbGestiune_SelectedIndexChanged);
            // 
            // tbValoareStoc
            // 
            this.tbValoareStoc.Location = new System.Drawing.Point(852, 506);
            this.tbValoareStoc.Name = "tbValoareStoc";
            this.tbValoareStoc.Size = new System.Drawing.Size(100, 20);
            this.tbValoareStoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total valoare stoc:";
            // 
            // btnCorectieStoc
            // 
            this.btnCorectieStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorectieStoc.Location = new System.Drawing.Point(32, 495);
            this.btnCorectieStoc.Name = "btnCorectieStoc";
            this.btnCorectieStoc.Size = new System.Drawing.Size(89, 23);
            this.btnCorectieStoc.TabIndex = 5;
            this.btnCorectieStoc.Text = "Corectie stoc";
            this.btnCorectieStoc.UseVisualStyleBackColor = true;
            this.btnCorectieStoc.Click += new System.EventHandler(this.btnCorectieStoc_Click);
            // 
            // btnListaCorectiiStoc
            // 
            this.btnListaCorectiiStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCorectiiStoc.Location = new System.Drawing.Point(159, 495);
            this.btnListaCorectiiStoc.Name = "btnListaCorectiiStoc";
            this.btnListaCorectiiStoc.Size = new System.Drawing.Size(108, 23);
            this.btnListaCorectiiStoc.TabIndex = 6;
            this.btnListaCorectiiStoc.Text = "Lista corectii stoc";
            this.btnListaCorectiiStoc.UseVisualStyleBackColor = true;
            // 
            // produsTableAdapter2
            // 
            this.produsTableAdapter2.ClearBeforeFill = true;
            // 
            // frmVizualizareStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 538);
            this.Controls.Add(this.btnListaCorectiiStoc);
            this.Controls.Add(this.btnCorectieStoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValoareStoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgVizualizareStoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVizualizareStoc";
            this.Text = "Vizualizare Stoc";
            this.Load += new System.EventHandler(this.frmVizualizareStoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVizualizareStoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softManagerDataSetProdusFinal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVizualizareStoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbCautareProdus;
        private System.Windows.Forms.CheckBox chkDoarProdusul;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.RadioButton rbDenumire;
        private System.Windows.Forms.RadioButton rbCantitativValoric;
        private System.Windows.Forms.RadioButton rbCantitativ;
        private System.Windows.Forms.ComboBox cmbGestiune;
        private System.Windows.Forms.TextBox tbValoareStoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCorectieStoc;
        private System.Windows.Forms.Button btnListaCorectiiStoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitateMasuraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProdusDataGridViewTextBoxColumn;
        private SoftManagerDataSetProdusFinal softManagerDataSetProdusFinal;
        private System.Windows.Forms.BindingSource produsBindingSource2;
        private SoftManagerDataSetProdusFinalTableAdapters.ProdusTableAdapter produsTableAdapter2;
    }
}
namespace SoftManager
{
    partial class frmModificareParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificareParola));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnInchide = new System.Windows.Forms.Button();
            this.tbReintroducereParola = new System.Windows.Forms.TextBox();
            this.tbParolaNoua = new System.Windows.Forms.TextBox();
            this.tbParolaVeche = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.eroareProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eroareProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(244, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.BackColor = System.Drawing.Color.Transparent;
            this.btnInchide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInchide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInchide.Location = new System.Drawing.Point(372, 193);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(75, 23);
            this.btnInchide.TabIndex = 19;
            this.btnInchide.Text = "I&nchide";
            this.btnInchide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInchide.UseVisualStyleBackColor = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // tbReintroducereParola
            // 
            this.tbReintroducereParola.BackColor = System.Drawing.Color.White;
            this.tbReintroducereParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReintroducereParola.ForeColor = System.Drawing.Color.Black;
            this.tbReintroducereParola.Location = new System.Drawing.Point(255, 144);
            this.tbReintroducereParola.MaxLength = 100;
            this.tbReintroducereParola.Name = "tbReintroducereParola";
            this.tbReintroducereParola.PasswordChar = '*';
            this.tbReintroducereParola.Size = new System.Drawing.Size(192, 20);
            this.tbReintroducereParola.TabIndex = 17;
            // 
            // tbParolaNoua
            // 
            this.tbParolaNoua.BackColor = System.Drawing.Color.White;
            this.tbParolaNoua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbParolaNoua.ForeColor = System.Drawing.Color.Black;
            this.tbParolaNoua.Location = new System.Drawing.Point(255, 102);
            this.tbParolaNoua.MaxLength = 100;
            this.tbParolaNoua.Name = "tbParolaNoua";
            this.tbParolaNoua.PasswordChar = '*';
            this.tbParolaNoua.Size = new System.Drawing.Size(192, 20);
            this.tbParolaNoua.TabIndex = 15;
            // 
            // tbParolaVeche
            // 
            this.tbParolaVeche.BackColor = System.Drawing.Color.White;
            this.tbParolaVeche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbParolaVeche.ForeColor = System.Drawing.Color.Black;
            this.tbParolaVeche.Location = new System.Drawing.Point(255, 59);
            this.tbParolaVeche.MaxLength = 100;
            this.tbParolaVeche.Name = "tbParolaVeche";
            this.tbParolaVeche.PasswordChar = '*';
            this.tbParolaVeche.Size = new System.Drawing.Size(192, 20);
            this.tbParolaVeche.TabIndex = 13;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(140, 151);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(109, 13);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "Reintroducere parola:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(159, 104);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(67, 13);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Parola noua:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(159, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Parola veche:";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizator.Location = new System.Drawing.Point(420, 25);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(27, 13);
            this.lblUtilizator.TabIndex = 11;
            this.lblUtilizator.Text = "[---]";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(241, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Modificare parola pentru utilizatorul ";
            // 
            // eroareProvider
            // 
            this.eroareProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 136);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // frmModificareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 232);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.tbReintroducereParola);
            this.Controls.Add(this.tbParolaNoua);
            this.Controls.Add(this.tbParolaVeche);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificareParola";
            this.Text = "Modificare Date Utilizator";
            ((System.ComponentModel.ISupportInitialize)(this.eroareProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Button btnInchide;
        internal System.Windows.Forms.TextBox tbReintroducereParola;
        internal System.Windows.Forms.TextBox tbParolaNoua;
        internal System.Windows.Forms.TextBox tbParolaVeche;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblUtilizator;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ErrorProvider eroareProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
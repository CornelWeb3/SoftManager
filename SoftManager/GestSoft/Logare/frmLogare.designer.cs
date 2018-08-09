namespace SoftManager
{
    partial class Logare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Utilizator = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lblVersiune = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogare = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(212, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(212, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // tb_Utilizator
            // 
            this.tb_Utilizator.BackColor = System.Drawing.Color.Yellow;
            this.tb_Utilizator.Location = new System.Drawing.Point(273, 41);
            this.tb_Utilizator.Name = "tb_Utilizator";
            this.tb_Utilizator.Size = new System.Drawing.Size(136, 20);
            this.tb_Utilizator.TabIndex = 2;
            this.tb_Utilizator.Click += new System.EventHandler(this.tb_Utilizator_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.ForeColor = System.Drawing.Color.DarkBlue;
            this.tb_Password.Location = new System.Drawing.Point(273, 72);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(136, 20);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.Click += new System.EventHandler(this.tb_Password_Click);
            // 
            // lblVersiune
            // 
            this.lblVersiune.AutoSize = true;
            this.lblVersiune.BackColor = System.Drawing.Color.Transparent;
            this.lblVersiune.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersiune.ForeColor = System.Drawing.Color.White;
            this.lblVersiune.Location = new System.Drawing.Point(355, 9);
            this.lblVersiune.Name = "lblVersiune";
            this.lblVersiune.Size = new System.Drawing.Size(55, 13);
            this.lblVersiune.TabIndex = 7;
            this.lblVersiune.Text = "DB: v ???";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(321, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Am uitat parola";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLogare
            // 
            this.btnLogare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogare.BackColor = System.Drawing.Color.Transparent;
            this.btnLogare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogare.ForeColor = System.Drawing.Color.Green;
            this.btnLogare.Image = ((System.Drawing.Image)(resources.GetObject("btnLogare.Image")));
            this.btnLogare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogare.Location = new System.Drawing.Point(284, 124);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(37, 30);
            this.btnLogare.TabIndex = 9;
            this.btnLogare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogare.UseVisualStyleBackColor = false;
            this.btnLogare.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIesire.BackColor = System.Drawing.Color.Transparent;
            this.btnIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIesire.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.ForeColor = System.Drawing.Color.Red;
            this.btnIesire.Image = ((System.Drawing.Image)(resources.GetObject("btnIesire.Image")));
            this.btnIesire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIesire.Location = new System.Drawing.Point(358, 124);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(37, 30);
            this.btnIesire.TabIndex = 10;
            this.btnIesire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 178);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblVersiune);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Utilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Logare_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Utilizator;
        private System.Windows.Forms.TextBox tb_Password;
        internal System.Windows.Forms.Label lblVersiune;
        private System.Windows.Forms.LinkLabel linkLabel1;
        internal System.Windows.Forms.Button btnLogare;
        internal System.Windows.Forms.Button btnIesire;
    }
}
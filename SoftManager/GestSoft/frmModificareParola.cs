using SoftManager.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftManager
{
    public partial class frmModificareParola : Form
    {
        public frmModificareParola()
        {
            InitializeComponent();
            lblUtilizator.Text = Settings.utilizator_Logat;
        }

        public bool VerificaErori()
        {
            bool existaErori = false;
            eroareProvider.Clear();

            if (tbParolaNoua.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbParolaNoua, "Nu ati introdus parola noua ");
            }

            if (tbParolaVeche.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbParolaVeche, "Nu ati introdus parola veche");
            }

            if (tbReintroducereParola.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbReintroducereParola, "Nu ati reintrodus parola");
            }




            return existaErori;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(VerificaErori() == false)
            {
               string parolaVeche = tbParolaVeche.Text;
               string parolaNoua = tbParolaNoua.Text;
  

                Utilizator u = new Utilizator(parolaNoua,parolaVeche);
                if(u.schimbareParola(parolaNoua,parolaVeche)==true)
                {
                    tbParolaNoua.Text = "";
                    tbParolaVeche.Text = "";
                }
            }
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

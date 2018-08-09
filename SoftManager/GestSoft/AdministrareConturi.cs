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
    public partial class AdministrareConturi : Form
    {
        public AdministrareConturi()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool VerificaErori()
        {
            bool existaErori = false;
            eroareProvider.Clear();

            if (tbContNouUtilizator.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbContNouUtilizator, "Nu ati introdus utilizatorul");
            }

            if (tbContNouParola.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbContNouParola, "Nu ati introdus parola");
            }

            if (tbContNouReintroducereParola.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbContNouReintroducereParola, "Nu ati introdus parola");
            }

            if (tbContNouEmail.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbContNouEmail, "Nu ati introdus mailul");
            }
            return existaErori;
        }


        private void btnCreazaCont_Click(object sender, EventArgs e)
        {
            if (VerificaErori() == true)
                return;

            try
            {
                Utilizator Util = new Utilizator(tbContNouUtilizator.Text, tbContNouParola.Text,tbContNouReintroducereParola.Text, tbContNouEmail.Text); // . toLower

                if (Util.AddToDatabase() == true)
                {
                    tbContNouUtilizator.Text = "";
                    tbContNouParola.Text = "";
                    tbContNouEmail.Text = "";
                    tbContNouReintroducereParola.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

    }
}

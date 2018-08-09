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
    public partial class AdministrareConturiModificaSterge : Form
    {
        string Provider = null;
        SqlConnection con = null;

        public AdministrareConturiModificaSterge()
        {
            InitializeComponent();
            Provider = Settings.Provider;
            umpleCombo();
        }

        public void umpleCombo()
        {
            string interogare = "Select* from Utilizatori;";

            con = new SqlConnection(Provider);
            SqlCommand com = new SqlCommand(interogare, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string utilizator = reader["Utilizator"].ToString();
                    cmbUpdateUtilizator.Items.Add(utilizator);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cmbUpdateUtilizator.SelectedIndex = 0;
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool VerificaErori()
        {
            bool existaErori = false;
            eroare.Clear();

            if (tbModifContParolaActuala.Text == "")
            {
                existaErori = true;
                eroare.SetError(tbModifContParolaActuala, "Nu ati introdus utilizatorul");
            }

            if (tbModificareContParola.Text == "")
            {
                existaErori = true;
                eroare.SetError(tbModificareContParola, "Nu ati introdus parola");
            }

            if (tbModificareContConfirmareParola.Text == "")
            {
                existaErori = true;
                eroare.SetError(tbModificareContConfirmareParola, "Nu ati introdus parola");
            }

            if (tbModificareContEmail.Text == "")
            {
                existaErori = true;
                eroare.SetError(tbModificareContEmail, "Nu ati introdus mailul");
            }
            return existaErori;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreazaCont_Click_1(object sender, EventArgs e)
        {
            if (VerificaErori() == true)
                return;

            try
            {
                Utilizator Util = new Utilizator(tbModifContParolaActuala.Text, tbModificareContParola.Text, tbModificareContEmail.Text); // . toLower


                string index = cmbUpdateUtilizator.SelectedItem.ToString();

                if (Util.Modify(index) == true)
                {
                    tbModifContParolaActuala.Text = "";
                    tbModificareContParola.Text = "";
                    tbModificareContEmail.Text = "";
                    tbModificareContConfirmareParola.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
            {
                Utilizator Util = new Utilizator(tbModifContParolaActuala.Text, tbModificareContParola.Text, tbModificareContEmail.Text); // . toLower

                string index = cmbUpdateUtilizator.SelectedItem.ToString();

                if (Util.Delete(index) == true)
                {
                    tbModifContParolaActuala.Text = "";
                    tbModificareContParola.Text = "";
                    tbModificareContEmail.Text = "";
                    tbModificareContConfirmareParola.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

    }
}

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
    public partial class frmAdaugaFurnizor : Form
    {
        string Provider = null;

        public frmAdaugaFurnizor()
        {
            InitializeComponent();
            Provider = Settings.Provider;
        }

        public bool VerificaErori()
        {
            bool existaErori = false;
            eroareProvider.Clear();

            if (tbAdaugaFurnizorCIF.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorCIF, "Nu ati introdus utilizatorul");
            }

            if (tbAdaugaFurnizorDenumire.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorDenumire, "Nu ati introdus parola");
            }

            if (tbAdaugaFurnizorNrRegComertului.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorNrRegComertului, "Nu ati introdus parola");
            }

            if (tbAdaugaFurnizorSediu.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorSediu, "Nu ati introdus mailul");
            }

            if (tbAdaugaFurnizorBanca.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorBanca, "Nu ati introdus mailul");
            }

            if (tbAdaugaFurnizorCont.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorCont, "Nu ati introdus mailul");
            }

            if (tbAdaugaFurnizorTelefon.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorTelefon, "Nu ati introdus mailul");
            }

            if (tbAdaugaFurnizorEmail.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorEmail, "Nu ati introdus mailul");
            }

            if (tbAdaugaFurnizorFax.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFurnizorFax, "Nu ati introdus mailul");
            }
            return existaErori;
        }


        public frmAdaugaFurnizor(string CIF,string Sediu,string Banca,string Cont,string Telefon,string Email)
        {
            InitializeComponent();
               
            tbAdaugaFurnizorCIF.Text = CIF;
            tbAdaugaFurnizorSediu.Text = Sediu;
            tbAdaugaFurnizorBanca.Text = Banca;
            tbAdaugaFurnizorCont.Text = Cont;
            tbAdaugaFurnizorTelefon.Text = Telefon;
            tbAdaugaFurnizorEmail.Text = Email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificaErori() == true)
                return;

            try
            {
                string CIF = tbAdaugaFurnizorCIF.Text;
                string Denumire = tbAdaugaFurnizorDenumire.Text;
                string NrRegCom = tbAdaugaFurnizorNrRegComertului.Text;
                string Sediu = tbAdaugaFurnizorSediu.Text;
                string Banca = tbAdaugaFurnizorBanca.Text;
                string Cont = tbAdaugaFurnizorCont.Text;
                string Telefon = tbAdaugaFurnizorTelefon.Text;
                string Email = tbAdaugaFurnizorEmail.Text;
                string Fax = tbAdaugaFurnizorFax.Text;

                Furnizor furnizor = new Furnizor(CIF, Denumire, NrRegCom, Sediu, Banca, Cont, Telefon, Email, Fax);

                if (furnizor.AddToDatabase() == true)
                {
                    tbAdaugaFurnizorCIF.Text = "";
                    tbAdaugaFurnizorDenumire.Text = "";
                    tbAdaugaFurnizorNrRegComertului.Text = "";
                    tbAdaugaFurnizorSediu.Text = "";
                    tbAdaugaFurnizorBanca.Text = "";
                    tbAdaugaFurnizorCont.Text = "";
                    tbAdaugaFurnizorTelefon.Text = "";
                    tbAdaugaFurnizorEmail.Text = "";
                    tbAdaugaFurnizorFax.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
    }
}

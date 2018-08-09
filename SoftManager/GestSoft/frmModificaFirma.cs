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
    public partial class frmModificaFirma : Form
    {
        public frmModificaFirma()
        {
            InitializeComponent();
     //       getData();
        }

        public void getData(string denumire)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.Provider);
            connection.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * from Firma WHERE Denumire = @Denumire", connection);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);


            sqlCmd.Parameters.AddWithValue("@Denumire", denumire);
            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                tbAdaugaFirmaCIF.Text = dt.Rows[0]["CIF"].ToString(); //Where ColumnName is the Field from the DB that you want to display
                tbAdaugaFirmaDenumire.Text = dt.Rows[0]["Denumire"].ToString();
                tbAdaugaFirmaNrRegComertului.Text = dt.Rows[0]["NrRegCom"].ToString();
                tbAdaugaFirmaSediu.Text = dt.Rows[0]["Sediu"].ToString();
                tbAdaugaFirmaBanca.Text = dt.Rows[0]["Banca"].ToString();
                tbAdaugaFirmaCont.Text = dt.Rows[0]["Cont"].ToString();
                tbAdaugaFirmaTelefon.Text = dt.Rows[0]["Telefon"].ToString();
                tbAdaugaFirmaEmail.Text = dt.Rows[0]["Email"].ToString(); 
            }
            connection.Close();
        }

        public bool VerificaErori()
        {
            bool existaErori = false;
            eroareProvider.Clear();

            if (tbAdaugaFirmaCIF.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaCIF, "Nu ati introdus CIF");
            }

            if (tbAdaugaFirmaDenumire.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaDenumire, "Nu ati introdus denumirea");
            }

            if (tbAdaugaFirmaNrRegComertului.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaNrRegComertului, "Nu ati introdus NrRegCom");
            }

            if (tbAdaugaFirmaSediu.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaSediu, "Nu ati introdus sediul");
            }

            if (tbAdaugaFirmaBanca.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaBanca, "Nu ati introdus banca");
            }

            if (tbAdaugaFirmaCont.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaCont, "Nu ati introdus contul");
            }

            if (tbAdaugaFirmaTelefon.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaTelefon, "Nu ati introdus telefonul");
            }

            if (tbAdaugaFirmaEmail.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaEmail, "Nu ati introdus mailul");
            }

            if (tbAdaugaFirmaFax.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaFax, "Nu ati introdus faxul");
            }

            if (tbAdaugaFirmaNume.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaNume, "Nu ati introdus numele");
            }

            if (tbAdaugaFirmaCNP.Text == "")
            {
                existaErori = true;
                eroareProvider.SetError(tbAdaugaFirmaCNP, "Nu ati introdus CNP");
            }
            return existaErori;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificaErori() == true)
                return;

            try
            {
                string CIF = tbAdaugaFirmaCIF.Text;
                string Denumire = tbAdaugaFirmaDenumire.Text;
                string NrRegCom = tbAdaugaFirmaNrRegComertului.Text;
                string Sediu = tbAdaugaFirmaSediu.Text;
                string Banca = tbAdaugaFirmaBanca.Text;
                string Cont = tbAdaugaFirmaCont.Text;
                string Telefon = tbAdaugaFirmaTelefon.Text;
                string Email = tbAdaugaFirmaEmail.Text;
                string Fax = tbAdaugaFirmaFax.Text;
                string Nume=tbAdaugaFirmaNume.Text;
                string CNP = tbAdaugaFirmaCNP.Text;

                Firma firma = new Firma(CIF, Denumire, NrRegCom, Sediu, Banca, Cont, Telefon, Email, Fax, Nume, CNP);

                if (firma.UpdateDatabase() == true)
                {
                    tbAdaugaFirmaCIF.Text = "";
                    tbAdaugaFirmaDenumire.Text = "";
                    tbAdaugaFirmaNrRegComertului.Text = "";
                    tbAdaugaFirmaSediu.Text = "";
                    tbAdaugaFirmaBanca.Text = "";
                    tbAdaugaFirmaCont.Text = "";
                    tbAdaugaFirmaTelefon.Text = "";
                    tbAdaugaFirmaEmail.Text = "";
                    tbAdaugaFirmaFax.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

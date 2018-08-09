using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftManager.Clase
{
    class Firma
    {
        public string CIF;
        public string Denumire;
        public string NrRegCom;
        public string Sediu;
        public string Banca;
        public string Cont;
        public string Telefon;
        public string Email;
        public string Fax;
        public string Nume;
        public string CNP;


        DatabaseConnection connection = new DatabaseConnection();
        SqlConnection con = null;

        public Firma(string CIF, string Denumire, string NrRegCom, string Sediu,
        string Banca, string Cont, string Telefon, string Email, string Fax, string Nume, string CNP)
        {
            this.CIF = CIF;
            this.Denumire = Denumire;
            this.NrRegCom = NrRegCom;
            this.Sediu = Sediu;
            this.Banca = Banca;
            this.Cont = Cont;
            this.Telefon = Telefon;
            this.Email = Email;
            this.Fax = Fax;
            this.Nume = Nume;
            this.CNP = CNP;
        }

        public Firma(string Denumire)     
        {
            this.Denumire = Denumire;
        }

        public bool AddToDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Firma_Adauga", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@CIF", SqlDbType.VarChar, 20).Value = CIF;
                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 8000).Value = Denumire;
                cmd.Parameters.Add("@NrRegCom", SqlDbType.VarChar).Value = NrRegCom;
                cmd.Parameters.Add("@Sediu", SqlDbType.VarChar, 20).Value = Sediu;
                cmd.Parameters.Add("@Banca", SqlDbType.VarChar, 8000).Value = Banca;
                cmd.Parameters.Add("@Cont", SqlDbType.VarChar, 20).Value = Cont;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar, 8000).Value = Telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = Fax;
                cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = Nume;
                cmd.Parameters.Add("@CNP", SqlDbType.VarChar).Value = CNP;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Aceasta firma exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Firma " + Denumire + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public void DeleteFromDB(string denumire)
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Sterge_Firma", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 20).Value = denumire;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Eroare: {0}", ex.Message));            
             
            }

            MessageBox.Show("Firma " + Denumire + " a fost stearsa cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        public bool UpdateDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Update_DateFirma", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@CIF", SqlDbType.VarChar, 20).Value = CIF;
                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 8000).Value = Denumire;
                cmd.Parameters.Add("@NrRegCom", SqlDbType.VarChar).Value = NrRegCom;
                cmd.Parameters.Add("@Sediu", SqlDbType.VarChar, 20).Value = Sediu;
                cmd.Parameters.Add("@Banca", SqlDbType.VarChar, 8000).Value = Banca;
                cmd.Parameters.Add("@Cont", SqlDbType.VarChar, 20).Value = Cont;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar, 8000).Value = Telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = Fax;
                cmd.Parameters.Add("@Nume", SqlDbType.VarChar).Value = Nume;
                cmd.Parameters.Add("@CNP", SqlDbType.VarChar).Value = CNP;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Aceasta firma exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Firma " + Denumire + " a fost modificata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
 
    }
}

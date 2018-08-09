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
    class Furnizor
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

        DatabaseConnection connection = new DatabaseConnection();
        SqlConnection con = null;

        public Furnizor(string CIF, string Denumire, string NrRegCom, string Sediu, string Banca, string Cont, string Telefon, string Email, string Fax)
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
        }

        public bool UpdateDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Furnizor_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@CIF", SqlDbType.VarChar, 20).Value = CIF;
                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 8000).Value = Denumire;
                cmd.Parameters.Add("@NrRegCom", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Sediu", SqlDbType.VarChar, 20).Value = Sediu;
                cmd.Parameters.Add("@Banca", SqlDbType.VarChar, 8000).Value = Banca;
                cmd.Parameters.Add("@Cont", SqlDbType.VarChar, 20).Value = Cont;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar, 8000).Value = Telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = Fax;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Aceast furnizor exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Furnizor " + Denumire + " a fost modificat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;

        }


        public bool AddToDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Furnizor_Adauga", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@CIF", SqlDbType.VarChar, 20).Value = CIF;
                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 8000).Value = Denumire;
                cmd.Parameters.Add("@NrRegCom", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Sediu", SqlDbType.VarChar, 20).Value = Sediu;
                cmd.Parameters.Add("@Banca", SqlDbType.VarChar, 8000).Value = Banca;
                cmd.Parameters.Add("@Cont", SqlDbType.VarChar, 20).Value = Cont;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar, 8000).Value = Telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = Fax;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Aceast furnizor exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Furnizor " + Denumire + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

    }
}

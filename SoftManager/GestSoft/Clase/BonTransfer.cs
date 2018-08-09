using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SoftManager.Clase
{
    public class BonTransfer
    {
        public string IdFirma { get; set; }
        public string DataBonTransfer { get; set; }
        public string Total { get; set; }
        public string Numar { get; set; }
        public string GestiuneSursa { get; set; }
        public string GestiuneDestinatie { get; set; }

        DatabaseConnection connection = new DatabaseConnection();
        SqlConnection con = null;

        public BonTransfer(string DataBonTransfer, string Total, string Numar, string GestiuneSursa, string GestiuneDestinatie)
        {
            this.DataBonTransfer = DataBonTransfer;
            this.Numar = Numar;
            this.Total = Total;
            this.GestiuneSursa = GestiuneSursa;
            this.GestiuneDestinatie = GestiuneDestinatie;
        }

        public bool AddToDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Adauga_BonTransfer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@DataBonTransfer", SqlDbType.VarChar, 20).Value = DataBonTransfer;
                cmd.Parameters.Add("@Total", SqlDbType.VarChar).Value = Total;
                cmd.Parameters.Add("@Numar", SqlDbType.VarChar, 20).Value = Numar;
                cmd.Parameters.Add("@GestiuneSursa", SqlDbType.VarChar, 8000).Value = GestiuneSursa;
                cmd.Parameters.Add("@GestiuneDestinatie", SqlDbType.VarChar, 8000).Value = GestiuneDestinatie;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Acest bon de transfer exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Bonul cu numarul " + Numar + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

    }
}

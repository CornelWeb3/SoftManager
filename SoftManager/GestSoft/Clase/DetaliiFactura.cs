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
    class DetaliiFactura
    {
        public string IdFactura { get; set; }
        public string IdFirma { get; set; }
        public string DataFacturii { get; set; }
        public string TipPlata { get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }
        public string Seria { get; set; }
        public string Numar { get; set; }
        public string Comentariu { get; set; }

        DatabaseConnection connection = new DatabaseConnection();
        SqlConnection con = null;

        public DetaliiFactura(string DataFacturii, string TipPlata, string Total, string Discount, string Seria, string Numar)
        {
            this.DataFacturii = DataFacturii;
            this.Seria = Seria;
            this.Numar = Numar;
            this.Total = Total;
            this.Discount = Discount;
            this.TipPlata = TipPlata;
        }

        public bool AddToDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Adauga_DetaliiFactura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@DataFacturii", SqlDbType.VarChar, 20).Value = DataFacturii;
                cmd.Parameters.Add("@TipPlata", SqlDbType.VarChar, 8000).Value = TipPlata;
                cmd.Parameters.Add("@Total", SqlDbType.VarChar).Value = Total;
                cmd.Parameters.Add("@Discount", SqlDbType.VarChar, 20).Value = Discount;
                cmd.Parameters.Add("@Seria", SqlDbType.VarChar, 8000).Value = Seria;
                cmd.Parameters.Add("@Numar", SqlDbType.VarChar, 20).Value = Numar;

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

            MessageBox.Show("Factura " + Seria + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}

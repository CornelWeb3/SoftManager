using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftManager.Clase
{
    class DatabaseConnection
    {
        SqlConnection conexiune = new SqlConnection(Settings.Provider);

        public DataSet factura_produs(int idFactura)
        {
            SqlCommand com = new SqlCommand("FacturaProdus_IdFactura", conexiune);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdFactura", idFactura);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataSet bon_produs(int idFactura)
        {
            SqlCommand com = new SqlCommand("BonProdus_IdFactura", conexiune);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdFactura", idFactura);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet Furnizor_Info(int IdFurnizor)
        {
            SqlCommand com = new SqlCommand("Furnizor_ID", conexiune);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdFurnizor", IdFurnizor);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet Firma_Info(int IdFirma)
        {
            SqlCommand com = new SqlCommand("Firma_ID", conexiune);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdFirma", IdFirma);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataSet Factura_Info(int IdFactura)
        {
            SqlCommand com = new SqlCommand("FacturaDetalii_ID", conexiune);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdFactura", IdFactura);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet Bon_Info(int IdBon)
        {
            SqlCommand com = new SqlCommand("BonDetalii_ID", conexiune);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdBon", IdBon);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void OpenConection()
        {
            conexiune = new SqlConnection(Settings.Provider);
            conexiune.Open();
        }

        public void ExecutaInterogare(string interogare)
        {
            SqlCommand cmd = new SqlCommand(interogare, conexiune);
            cmd.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            conexiune.Close();
        }

    }
}

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
    class Produs
    {
        public string Denumire;
        public string UnitateMasura;
        public int Cantitate;
        public int TVA;
        public double PretCumparare;
        public double PretVanzare;
        public string TipProdus;
        public int index;

        DatabaseConnection connection = new DatabaseConnection();
        SqlConnection con = null;

        private string sir_Denumire="";
        private string sir_UnitateMasura="";
        private string sir_Cantitate="";
        private string sir_TVA="";
        private string sir_PretCumparare="";
        private string sir_PretVanzare="";
        private string sir_TipProdus="";

        public Produs()
        {
            this.Denumire = "";
            this.Cantitate = 0;
            this.TVA = 0;
            this.PretCumparare = 0.0;
            this.PretVanzare = 0.0;
            this.UnitateMasura = "";
            this.TipProdus = "";
        }

        public Produs(string Denumire, int index)
        {
            this.Denumire = Denumire;
            this.index = index;
        }

        public Produs( string Denumire, string UnitateMasura,
            int Cantitate, int TVA, double PretCumparare, double PretVanzare, string TipProdus)
        {
            this.Denumire = Denumire;
            this.Cantitate = Cantitate;
            this.TVA = TVA;
            this.PretCumparare = PretCumparare;
            this.PretVanzare = PretVanzare;
            this.UnitateMasura = UnitateMasura;
            this.TipProdus = TipProdus;
        }

        public bool AddToDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Produs_Adauga", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 20).Value = Denumire;
                cmd.Parameters.Add("@UnitateMasura", SqlDbType.VarChar, 8000).Value = UnitateMasura;
                cmd.Parameters.Add("@Cantitate", SqlDbType.VarChar, 8000).Value = Cantitate;
                cmd.Parameters.Add("@TVA", SqlDbType.VarChar).Value = TVA;
                cmd.Parameters.Add("@PretCumparare", SqlDbType.VarChar, 20).Value = PretCumparare;
                cmd.Parameters.Add("@PretVanzare", SqlDbType.VarChar, 20).Value = PretVanzare;
                cmd.Parameters.Add("@TipProdus", SqlDbType.VarChar, 20).Value = TipProdus;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Aceast produs exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public bool AddToDatabaseImport(Produs p)
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Produs_Adauga", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@Denumire", SqlDbType.VarChar, 200).Value = p.sir_Denumire;
                cmd.Parameters.Add("@UnitateMasura", SqlDbType.VarChar, 8000).Value = p.sir_UnitateMasura;
                cmd.Parameters.Add("@Cantitate", SqlDbType.VarChar, 8000).Value = p.sir_Cantitate;
                cmd.Parameters.Add("@TVA", SqlDbType.VarChar).Value = p.sir_TVA;
                cmd.Parameters.Add("@PretCumparare", SqlDbType.VarChar, 20).Value = p.sir_PretCumparare;
                cmd.Parameters.Add("@PretVanzare", SqlDbType.VarChar, 20).Value = p.sir_PretVanzare;
                cmd.Parameters.Add("@TipProdus", SqlDbType.VarChar, 20).Value = p.sir_TipProdus;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Aceast produs exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public void retrieveFromDatabase(string Denumire, int index)
        {
            //SqlConnection con = new SqlConnection(Provider);
            //con.Open();
            //string UnitateMasura, Cantitate, TVA, PretCumparare, PretVanzare, TipProdus = "";
            //SqlCommand com = new SqlCommand("Select * from Produs where denumire='" + Denumire + "'", con);
            //DataSet ds = new DataSet();
            //SqlDataAdapter da = new SqlDataAdapter(com);

            //Produs p = null;

            //try
            //{
            //    da.Fill(ds);

            //    Denumire = ds.Tables[0].Rows[index]["Denumire"].ToString();
            //    UnitateMasura = ds.Tables[0].Rows[index]["UnitateMasura"].ToString();
            //    Cantitate = ds.Tables[0].Rows[index]["Cantitate"].ToString();
            //    TVA = ds.Tables[0].Rows[index]["TVA"].ToString();
            //    PretCumparare = ds.Tables[0].Rows[index]["PretCumparare"].ToString();
            //    PretVanzare = ds.Tables[0].Rows[index]["PretVanzare"].ToString();
            //    TipProdus = ds.Tables[0].Rows[index]["TipProdus"].ToString();

            //    p = new Produs(Denumire, UnitateMasura, Cantitate, TVA, PretCumparare, PretVanzare);


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            //return p;
        }

    }

}

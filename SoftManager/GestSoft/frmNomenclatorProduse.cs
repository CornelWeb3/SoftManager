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
    public partial class frmNomenclatorProduse : Form
    {
        string Provider = null;

        public frmNomenclatorProduse()
        {
            InitializeComponent();
            Provider = Settings.Provider;
            umpleComboDenumireProdus();
            umpleDataGridView();
        }


        public void umpleDataGridView()
        {
            SqlConnection con = new SqlConnection(Provider);
            con.Open();
            SqlCommand com = new SqlCommand("Select * from Produs", con);

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);

            try
            {
                da.Fill(ds);
                dgNomenclator.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void umpleComboCodProdus()
        {
            string interogare = "Select* from Produs;";

            SqlConnection conexiune = new SqlConnection(Provider);
            SqlCommand com = new SqlCommand(interogare, conexiune);
            SqlDataReader reader;
            try
            {
                conexiune.Open();
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string denumire = reader["IdProdus"].ToString();
                    cmbNomenclatorProduse.Items.Add(denumire);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conexiune.Close();
            }
        }

        void umpleComboDenumireProdus()
        {
            string interogare = "Select* from Produs;";

            SqlConnection conexiune = new SqlConnection(Provider);
            SqlCommand com = new SqlCommand(interogare, conexiune);
            SqlDataReader reader;
            try
            {
                conexiune.Open();
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string denumire = reader["Denumire"].ToString();
                    cmbNomenclatorProduse.Items.Add(denumire);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conexiune.Close();
            }
        }


        private void cmbNomenclatorProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Denumire = "";
            int IdProdus = 0;


            SqlConnection con = new SqlConnection(Provider);
            DataSet ds = new DataSet();

            if (rbNomenclatorDenumire.Checked == true)
            {
                Denumire = cmbNomenclatorProduse.SelectedItem.ToString();
                SqlCommand com = new SqlCommand("Filtrare_ProduseDenumire", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@Denumire", SqlDbType.VarChar, 20).Value = Denumire;
                com.ExecuteNonQuery();
               
                SqlDataAdapter adpt = new SqlDataAdapter(com);
                adpt.Fill(ds);
                con.Close();

                dgNomenclator.DataSource = ds.Tables[0];
               
            }
            else if (rbNomenclatorCod.Checked == true)
            {
                IdProdus = Convert.ToInt32(cmbNomenclatorProduse.SelectedItem);
                SqlCommand com = new SqlCommand("Filtrare_ProduseId", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@IdProdus", SqlDbType.VarChar, 20).Value = IdProdus;
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter(com);
                adpt.Fill(ds);
                con.Close();

                dgNomenclator.DataSource = ds.Tables[0];
            }

            int index = cmbNomenclatorProduse.SelectedIndex;

        
        }

        private void rbNomenclatorDenumire_Click(object sender, EventArgs e)
        {
            cmbNomenclatorProduse.Items.Clear();
            umpleComboDenumireProdus();
        }

        private void rbNomenclatorCod_CheckedChanged(object sender, EventArgs e)
        {
            cmbNomenclatorProduse.Items.Clear();
            umpleComboCodProdus();
        }



        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            //this.dgNomenclator.DataSource = null;
            //this.dgNomenclator.Rows.Clear();

            SqlConnection con = null;

            try
            {
                con = new SqlConnection(Provider);
                SqlCommand cmd = new SqlCommand("Delete from Produs", con);

                //      cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dgNomenclator.Rows.Count - 1; i++)
                {
                    string Denumire = Convert.ToString(dgNomenclator.Rows[i].Cells[1].Value);
                    string UnitateMasura = dgNomenclator.Rows[i].Cells[2].Value.ToString();
                    int Cantitate = Convert.ToInt32(dgNomenclator.Rows[i].Cells[3].Value);
                    int TVA = Convert.ToInt32(dgNomenclator.Rows[i].Cells[4].Value.ToString());
                    double PretCumparare = Convert.ToDouble(dgNomenclator.Rows[i].Cells[5].Value);
                    double PretVanzare = Convert.ToDouble(dgNomenclator.Rows[i].Cells[6].Value.ToString());
                    string TipProdus = dgNomenclator.Rows[i].Cells[7].Value.ToString();

                    Produs p = new Produs(Denumire, UnitateMasura, Cantitate, TVA, PretCumparare, PretVanzare, TipProdus);
                    p.AddToDatabase();
                    MessageBox.Show("Produsul " + p.Denumire + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Eroare: {0}", ex.Message));
            }
        }

        private void dgNomenclator_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //   this.dgNomenclator.Rows[e.RowIndex].Cells["IdProdus"].Value=(e.RowIndex+1).ToString();
        }
    }
}

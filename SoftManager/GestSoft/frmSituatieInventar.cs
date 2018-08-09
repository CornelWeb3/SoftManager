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
    public partial class frmSituatieInventar : Form
    {
        public frmSituatieInventar()
        {
            InitializeComponent();
            umpleComboProduse();
        }

        public void umpleComboProduse()
        {
            string interogare = "Select* from Produs;";

            SqlConnection conexiune = new SqlConnection(Settings.Provider);
            SqlCommand com = new SqlCommand(interogare, conexiune);
            SqlDataReader reader;
            try
            {
                conexiune.Open();
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string denumire = reader["Denumire"].ToString();
                    cmbCautareProdus.Items.Add(denumire);
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

        private void c1Button1_Click(object sender, EventArgs e)
        {
            frmVizualizareSituatie fv = new frmVizualizareSituatie();
            fv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVizualizareSituatie vs = new frmVizualizareSituatie();
            vs.Show();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            tbCautareProdus.Visible = true;

            string Denumire = "";
            int IdProdus = 0;

            SqlConnection con = new SqlConnection(Settings.Provider);
            DataSet ds = new DataSet();

            if (rbCautare.Checked == true)
            {
                Denumire = cmbCautareProdus.SelectedItem.ToString();
                SqlCommand com = new SqlCommand("Filtrare_ProduseDenumire", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@Denumire", SqlDbType.VarChar, 20).Value = Denumire;
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter(com);
                adpt.Fill(ds);
                con.Close();

            }


            int index = cmbCautareProdus.SelectedIndex;
        }
    }
}

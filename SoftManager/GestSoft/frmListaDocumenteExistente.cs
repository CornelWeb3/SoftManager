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
    public partial class frmListaDocumenteExistente : Form
    {

        public frmListaDocumenteExistente()
        {
            InitializeComponent();
            cmbFurnizor.Visible = false;
            umpleComboDenumireFurnizor();
            umpleDataGridView();
        }

        public void umpleComboDenumireFurnizor()
        {
            string interogare = "Select* from Furnizor;";
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
                    cmbFurnizor.Items.Add(denumire);
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

        public void umpleDataGridView()
        {
            SqlConnection con = new SqlConnection(Settings.Provider);
            con.Open();
            SqlCommand com = new SqlCommand("Select * from DetaliiFactura", con);

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);

            try
            {
                da.Fill(ds);
                dgFacturi.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void schimbareCuloare()
        {
            btnGenerare.BackColor = Color.Red;
        }

        private void rbDoarFurnizorul_Click(object sender, EventArgs e)
        {
            cmbFurnizor.Visible = true;
        }


    }
}

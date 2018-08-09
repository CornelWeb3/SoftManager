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
using System.Configuration;
using SoftManager.Clase;

namespace SoftManager
{
    public partial class frmListaFirme : Form
    {
        string Provider = null;

        public frmListaFirme()
        {
            Provider = Settings.Provider;
            InitializeComponent();
            incarcaDataGrid();
        }

        void incarcaDataGrid()
        {
            SqlConnection connection;
            SqlDataAdapter adapter;
            DataSet ds = new DataSet();
            string query;

            connection = new SqlConnection(Settings.Provider);
            query = "select * from Firma";
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);

                connection.Close();
                dgListaFirma.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string Denumire = dgListaFirma.CurrentRow.Cells[1].Value.ToString();
            string CIF = dgListaFirma.CurrentRow.Cells[2].Value.ToString();
            string NrRegCom = dgListaFirma.CurrentRow.Cells[3].Value.ToString();
            string Sediu = dgListaFirma.CurrentRow.Cells[4].Value.ToString();
            string Banca = dgListaFirma.CurrentRow.Cells[5].Value.ToString();
            string Cont = dgListaFirma.CurrentRow.Cells[6].Value.ToString();
            string Telefon = dgListaFirma.CurrentRow.Cells[7].Value.ToString();
            string Fax = dgListaFirma.CurrentRow.Cells[8].Value.ToString();
            string Email = dgListaFirma.CurrentRow.Cells[9].Value.ToString();

            frmIntroducereDocumentNou idn = new frmIntroducereDocumentNou(Denumire, CIF, NrRegCom, Sediu, Banca, Cont, Telefon, Email, Fax);
            this.Close();
            idn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdaugaFirma af = new frmAdaugaFirma();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Denumire = dgListaFirma.CurrentRow.Cells[1].Value.ToString();
            Firma f = new Firma(Denumire);
            try
            {
                f.DeleteFromDB(Denumire);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            incarcaDataGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgListaFirma.DataSource = null;
            dgListaFirma.Refresh();
            incarcaDataGrid();
        }

        private void btnModificaFirma_Click(object sender, EventArgs e)
        {
            //frmModificaFirma mf = new frmModificaFirma();
            //mf.Show();
            SqlConnection conexiune = new SqlConnection(Settings.Provider);
            conexiune.Open();
            foreach (DataGridViewRow row in dgListaFirma.Rows)
            {
                if (dgListaFirma.Rows.Count > 0)
                {
                    int nRowIndex = dgListaFirma.Rows.Count - 2;

                    if (dgListaFirma.Rows[nRowIndex].Cells[0].Value != null)
                    {
                        string com = "Update_DateFirma";
                        using (SqlCommand cmd = new SqlCommand(com, conexiune))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdFirma", row.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@Denumire", row.Cells[1].Value);
                            cmd.Parameters.AddWithValue("@CIF", row.Cells[2].Value);
                            cmd.Parameters.AddWithValue("@NrRegCom", row.Cells[3].Value);
                            cmd.Parameters.AddWithValue("@Sediu", row.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@Banca", row.Cells[5].Value);
                            cmd.Parameters.AddWithValue("@Cont", row.Cells[6].Value);
                            cmd.Parameters.AddWithValue("@Telefon", row.Cells[7].Value);
                            cmd.Parameters.AddWithValue("@Email", row.Cells[8].Value);
                            cmd.Parameters.AddWithValue("@Fax", row.Cells[9].Value);
                            cmd.Parameters.AddWithValue("@Nume", row.Cells[10].Value);
                            cmd.Parameters.AddWithValue("@CNP", row.Cells[11].Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            MessageBox.Show("Updated Successfully", "OUTPUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexiune.Close();
        }


    }
}

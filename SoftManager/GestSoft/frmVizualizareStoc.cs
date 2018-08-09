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
    public partial class frmVizualizareStoc : Form
    {
        public frmVizualizareStoc()
        {
            InitializeComponent();
            this.dgVizualizareStoc.Columns[4].Visible = false;
            this.dgVizualizareStoc.Columns[5].Visible = false;
            this.dgVizualizareStoc.Columns[6].Visible = false;

            cmbCautareProdus.BackColor = Color.DarkGray;
            cmbCautareProdus.Enabled = false;
            rbDenumire.Enabled = false;
            rbCod.Enabled = false;

            umpleComboGestiuni();
            umpleComboDenumireProdus();

        //    umpleDataGridView();
        }

        void umpleComboGestiuni()
        {
            //string interogare = "Select* from Gestiune;";

            //SqlConnection conexiune = new SqlConnection(Settings.Provider);
            //SqlCommand com = new SqlCommand(interogare, conexiune);
            //SqlDataReader reader;
            //try
            //{
            //    conexiune.Open();
            //    reader = com.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        string denumire = reader["Denumire"].ToString();
            //        cmbGestiune.Items.Add(denumire);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{

            //    conexiune.Close();
            //}
        }

        //public void umpleDataGridView()
        //{
        //    SqlConnection con = new SqlConnection(Settings.Provider);
        //    con.Open();
        //    SqlCommand com = new SqlCommand("Select * from Produs", con);

        //    DataTable ds = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(com);

        //    try
        //    {
        //        da.Fill(ds);
        //        dgVizualizareStoc.DataSource = ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void frmVizualizareStoc_Load(object sender, EventArgs e)
        {
            this.produsTableAdapter2.Fill(this.softManagerDataSetProdusFinal.Produs);

            double sum = 0;
            for (int i = 0; i < dgVizualizareStoc.Rows.Count - 1; i++)
            {
                double pretUnitar = Convert.ToDouble(dgVizualizareStoc.Rows[i].Cells[0].Value);
                sum += pretUnitar;
            }
            tbValoareStoc.Text = Convert.ToString(sum);
        }

        private void chkDoarProdusul_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkDoarProdusul.Checked == true)
            {
                cmbCautareProdus.BackColor = Color.White;
                cmbCautareProdus.Enabled = true;
                rbDenumire.Enabled = true;
                rbDenumire.Checked = true;
                rbCod.Enabled = true;
            }

            if (chkDoarProdusul.Checked == false)
            {
                cmbCautareProdus.BackColor = Color.Gray;
                cmbCautareProdus.Enabled = false;
                rbDenumire.Enabled = false;
                rbCod.Enabled = false;
            }   
        }

        void umpleComboCodProdus()
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
                    string denumire = reader["IdProdus"].ToString();
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

        void umpleComboDenumireProdus()
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


        private void rbCantitativValoric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCantitativ.Checked == true)
            {
                this.dgVizualizareStoc.Columns[4].Visible = false;
                this.dgVizualizareStoc.Columns[5].Visible = false;
                this.dgVizualizareStoc.Columns[6].Visible = false;
            }
            else if (rbCantitativValoric.Checked == true)
            {
            //  this.dgVizualizareStoc.Columns["PretCumparare"].Visible = true;
                this.dgVizualizareStoc.Columns[4].Visible = true;
                this.dgVizualizareStoc.Columns[5].Visible = true;
                this.dgVizualizareStoc.Columns[6].Visible = true;

            }
        }

        private void btnCorectieStoc_Click(object sender, EventArgs e)
        {

        }

        private void cmbCautareProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Denumire = "";
            int IdProdus = 0;

            SqlConnection con = new SqlConnection(Settings.Provider);
            DataSet ds = new DataSet();

            if (rbDenumire.Checked == true)
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

                dgVizualizareStoc.DataSource = ds.Tables[0];

            }
            else if (rbCod.Checked == true)
            {
                IdProdus = Convert.ToInt32(cmbCautareProdus.SelectedItem);
                SqlCommand com = new SqlCommand("Filtrare_ProduseId", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@IdProdus", SqlDbType.VarChar, 20).Value = IdProdus;
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter(com);
                adpt.Fill(ds);
                con.Close();

                dgVizualizareStoc.DataSource = ds.Tables[0];
            }

            int index = cmbCautareProdus.SelectedIndex;

        }

        private void rbDenumire_Click(object sender, EventArgs e)
        {
            cmbCautareProdus.Items.Clear();
            umpleComboDenumireProdus();
        }

        private void rbCod_Click(object sender, EventArgs e)
        {
            cmbCautareProdus.Items.Clear();
            umpleComboCodProdus();
        }

        private void chkDoarProdusul_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDoarProdusul.Checked == false)
            {
                this.produsTableAdapter2.Fill(this.softManagerDataSetProdusFinal.Produs);
                double sum = 0;
                for (int i = 0; i < dgVizualizareStoc.Rows.Count - 1; i++)
                {
                    double pretUnitar = Convert.ToDouble(dgVizualizareStoc.Rows[i].Cells[5].Value);
                    sum += pretUnitar;
                }
                tbValoareStoc.Text = Convert.ToString(sum);

            }
        }

        private void cmbGestiune_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Settings.Provider);
            DataSet ds = new DataSet();

         
                string DenumireDepozit = cmbGestiune.SelectedItem.ToString();
                SqlCommand com = new SqlCommand("Filtrare_ProduseDepozit", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@Denumire", SqlDbType.VarChar, 20).Value = DenumireDepozit;
                com.ExecuteNonQuery();

                SqlDataAdapter adpt = new SqlDataAdapter(com);
                adpt.Fill(ds);
                con.Close();

                dgVizualizareStoc.DataSource = ds.Tables[0];
        }


    }
}

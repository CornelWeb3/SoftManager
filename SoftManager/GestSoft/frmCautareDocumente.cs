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
    public partial class frmCautareDocumente : Form
    {
        public frmCautareDocumente()
        {
            InitializeComponent();
            rdoIdFactura.Visible = false;
            rdoCUI.Visible = false;
            rdoDenumireClient.Visible = false;
        }

        private bool Exista_Erori()
        {
            eroare.Clear();
            bool exista = false;

            if (txtCauta.Text == "")
            {
                eroare.SetError(txtCauta, "Nu ati introdus nici o fraza de cautare!");
                exista = true;
            }
            else
            {
                int NrCaractere = 0;

                for (int i = 0; i <= txtCauta.Text.Length - 1; i++)
                {
                    if (txtCauta.Text.Substring(i, 1) != "%")
                        NrCaractere += 1;
                }
            }


            return exista;
        }


        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (Exista_Erori())
                return;

            SqlConnection conexiune = new SqlConnection(Settings.Provider);
            string query = "";

            if (rdoProduse.Checked == true)
                if (rdoDenumire.Checked == true)
                    query = "Cauta_ProduseDenumire";
                else if (rdoIdProdus.Checked == true)
                    query = "Cauta_ProduseIdProdus";

            if (rdoFacturi.Checked == true)
                if (rdoIdFactura.Checked == true)
                    query = "Cauta_FacturiDenumire";
         //       else if (rdoIdProdus.Checked == true)
        //            query = "Cauta_ProduseIdProdus";

            if (rdoClienti.Checked == true)
                if (rdoDenumireClient.Checked == true)
                    query = "Cauta_ClientiDenumire";

            if (rdoFirma.Checked == true)
                if (rdoCUI.Checked == true)
                    query = "Cauta_FirmaCUI";

            SqlCommand sqlCautare = new SqlCommand(query, conexiune);
            sqlCautare.CommandType = CommandType.StoredProcedure;
            sqlCautare.Parameters.Add("@Parametru", SqlDbType.VarChar, 30).Value = txtCauta.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlCautare);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            dg.DataSource = datatable;
            dg.DataSource = DataAccess.AdaugaNrCrt(datatable, 0);
                
        }

 

        private void rdoDenumire_Click(object sender, EventArgs e)
        {
            lblCautaDupa.Text = "Denumire Produs";
        }

        private void rdoIdProdus_Click(object sender, EventArgs e)
        {
            lblCautaDupa.Text = "IdProdus";
        }

        private void rdoFacturi_Click(object sender, EventArgs e)
        {
            rdoIdFactura.Visible = true;
            rdoDenumire.Visible = false;
            rdoIdProdus.Visible = false;
               rdoCUI.Visible = false;
        }

        private void rdoProduse_Click(object sender, EventArgs e)
        {
            rdoDenumire.Visible = true;
            rdoIdProdus.Visible = true;
            rdoIdFactura.Visible = false;
            rdoCUI.Visible = false;
        }

        private void rdoFirma_Click(object sender, EventArgs e)
        {
            rdoDenumire.Visible = false;
            rdoIdProdus.Visible = false;
            rdoIdFactura.Visible = false;
            rdoCUI.Visible = true;
            lblCautaDupa.Text = "CUI";
        }

        private void rdoClienti_Click(object sender, EventArgs e)
        {
            rdoDenumire.Visible = false;
            rdoIdProdus.Visible = false;
            rdoIdFactura.Visible = false;
            rdoCUI.Visible = false;
            rdoDenumire.Visible = true;
            lblCautaDupa.Text = "Denumire Client";
        }
    }
}

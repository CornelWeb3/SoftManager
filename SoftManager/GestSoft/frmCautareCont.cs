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
    public partial class frmCautareCont : Form
    {
        public frmCautareCont()
        {
            InitializeComponent();
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

            if (rdoUtilizator.Checked == true)
                query = "Cauta_UtilizatorDenumire";
            if (rdoEmail.Checked == true)
                query = "Cauta_UtilizatorDupaEmail";
            

            SqlCommand sqlCautare = new SqlCommand(query, conexiune);

            sqlCautare.CommandType = CommandType.StoredProcedure;
            sqlCautare.Parameters.Add("@Parametru", SqlDbType.VarChar, 30).Value = txtCauta.Text;


            SqlDataAdapter da = new SqlDataAdapter(sqlCautare);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            dg.DataSource = datatable;
           // dg.DataSource = DataAccess.AdaugaNrCrt(datatable, 0);
            //   dg.Columns["Nr CRT"].Width = 50;
                
        }

        private void rdoUtilizator_Click(object sender, EventArgs e)
        {
            lblCautaDupa.Text = "Nume utilizator:";
        }

        private void rdoChitante_Click(object sender, EventArgs e)
        {
            lblCautaDupa.Text = "Email:";
        }

    }
}

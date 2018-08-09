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
    public partial class VizualizareFactura : Form
    {
        public VizualizareFactura()
        {
            InitializeComponent();
        }

        DatabaseConnection db = new DatabaseConnection();

        private void VizualizareFactura_Load(object sender, EventArgs e)
        {
            List<Vanzari_Factura_produs> _List = new List<Vanzari_Factura_produs>();

            DataSet ds = db.factura_produs(1);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _List.Add(new Vanzari_Factura_produs
                {
                    IdProdus = dr["IdProdus"].ToString(),
                    DenumireProdus = dr["Denumire"].ToString(),
                    Cantitate = dr["Cantitate"].ToString(),
                    Discount = dr["Discount"].ToString()
                });

                //factura1.SetParameterValue("pIdProdus", dr["IdProdus"].ToString());
                //factura1.SetParameterValue("pDenumire", dr["Denumire"].ToString());
                //factura1.SetParameterValue("pCantitate", dr["Cantitate"].ToString());
                //factura1.SetParameterValue("pDiscount", dr["Discount"].ToString());
            }

            DataSet ds2 = db.Firma_Info(102);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                factura1.SetDataSource(_List);
                factura1.SetParameterValue("fDenumireFirma", dr["Denumire"].ToString());
                factura1.SetParameterValue("fCifFirma", dr["CIF"].ToString());
                factura1.SetParameterValue("fNrRegCom", dr["NrRegCom"].ToString());
                factura1.SetParameterValue("fSediu", dr["Sediu"].ToString());
                factura1.SetParameterValue("fBanca", dr["Banca"].ToString());
                factura1.SetParameterValue("fIBAN", dr["Cont"].ToString());
                factura1.SetParameterValue("fTelefon", dr["Telefon"].ToString());
                factura1.SetParameterValue("fEmail", dr["Email"].ToString());

                DataSet ds3 = db.Factura_Info(1);
                foreach (DataRow dr3 in ds3.Tables[0].Rows)
                {
                    factura1.SetParameterValue("TipPlata", dr3["TipPlata"].ToString());
                    factura1.SetParameterValue("Seria", dr3["Seria"].ToString());
                    factura1.SetParameterValue("Numar", dr3["Numar"].ToString());
                    factura1.SetParameterValue("pTotal", dr3["Total"].ToString());
                }
            }

            DataSet ds4 = db.Furnizor_Info(3);
            foreach (DataRow dr in ds4.Tables[0].Rows)
            {
                factura1.SetParameterValue("pDenumireFurnizor", dr["Denumire"].ToString());
                factura1.SetParameterValue("pCIF", dr["CIF"].ToString());
                factura1.SetParameterValue("pNrRegCom", dr["NrRegCom"].ToString());
                factura1.SetParameterValue("pSediu", dr["Sediu"].ToString());
                factura1.SetParameterValue("pBanca", dr["Banca"].ToString());
                factura1.SetParameterValue("pTara", dr["CIF"].ToString());
            }

            crystalReportViewer1.ReportSource = factura1;
        }


    }
}

using SoftManager.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftManager
{
    public partial class frmVizualizareSituatie : Form
    {
        public frmVizualizareSituatie()
        {
            InitializeComponent();
        }

        DatabaseConnection db = new DatabaseConnection();

        private void frmVizualizareBonTransfer_Load(object sender, EventArgs e)
        {
            List<Vanzari_Factura_produs> _List = new List<Vanzari_Factura_produs>();

            DataSet ds = db.bon_produs(1);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _List.Add(new Vanzari_Factura_produs
                {
                    IdProdus = dr["IdProdus"].ToString(),
                    DenumireProdus = dr["Denumire"].ToString(),
                    UnitateMasura = dr["UnitateMasura"].ToString(),
                    Cantitate = dr["Cantitate"].ToString(),
                    PretUnitar = dr["PretUnitar"].ToString(),
                    Valoare = dr["Valoare"].ToString(),
                });
            }

            DataSet ds2 = db.Firma_Info(102);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                SituatieInventar1.SetDataSource(_List);
                SituatieInventar1.SetParameterValue("fDenumireFirma", dr["Denumire"].ToString());
                SituatieInventar1.SetParameterValue("fCifFirma", dr["CIF"].ToString());
                SituatieInventar1.SetParameterValue("fNrRegCom", dr["NrRegCom"].ToString());
                SituatieInventar1.SetParameterValue("fSediu", dr["Sediu"].ToString());

                DataSet ds3 = db.Bon_Info(2);
                foreach (DataRow dr3 in ds3.Tables[0].Rows)
                {
                    SituatieInventar1.SetParameterValue("Numar", dr3["Numar"].ToString());
                    SituatieInventar1.SetParameterValue("Gestiunea", dr3["GestiuneSursa"].ToString());
                    SituatieInventar1.SetParameterValue("pTotal", dr3["Total"].ToString());
                }
            }


            crystalReportViewer1.ReportSource = SituatieInventar1;
        }

    }
}

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
    public partial class Bon_de_transfer : Form
    {

        public Bon_de_transfer()
        {
            InitializeComponent();
            umpleComboDenumireProdus();
            //umpleComboGestiuneSursa();
            //umpleComboGestiuneDestinatie();
        }

        //void umpleComboGestiuneSursa()
        //{
        //    string interogare = "Select* from Gestiune;";

        //    SqlConnection conexiune = new SqlConnection(Settings.Provider);
        //    SqlCommand com = new SqlCommand(interogare, conexiune);
        //    SqlDataReader reader;
        //    try
        //    {
        //        conexiune.Open();
        //        reader = com.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            string denumire = reader["Denumire"].ToString();
        //            cmbGestiuneSursa.Items.Add(denumire);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {

        //        conexiune.Close();
        //    }
        //}

        //void umpleComboGestiuneDestinatie()
        //{
        //    string interogare = "Select* from Gestiune;";

        //    SqlConnection conexiune = new SqlConnection(Settings.Provider);
        //    SqlCommand com = new SqlCommand(interogare, conexiune);
        //    SqlDataReader reader;
        //    try
        //    {
        //        conexiune.Open();
        //        reader = com.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            string denumire = reader["Denumire"].ToString();
        //            cmbGestiuneDestinatie.Items.Add(denumire);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {

        //        conexiune.Close();
        //    }
        //}

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
                    cmbDenumireProdus.Items.Add(denumire);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string UnitateMasura, TipProdus = "";
            int IdProdus, Cantitate = 0;
            double PretVanzare = 0.0;
            DataTable t = new DataTable();

            if (Convert.ToInt32(tbCantitate.Text) > 0)
            {
                Cantitate = Convert.ToInt32(tbCantitate.Text);
                string Denumire = cmbDenumireProdus.SelectedItem.ToString();
                int index = (int)cmbDenumireProdus.SelectedIndex;

                SqlConnection con = new SqlConnection(Settings.Provider);
                con.Open();
                SqlCommand com = new SqlCommand("Select * from Produs", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);

                try
                {
                    da.Fill(ds);
                    double sum = 0.0;

                    IdProdus = (int)ds.Tables[0].Rows[index]["IdProdus"];
                    Denumire = ds.Tables[0].Rows[index]["Denumire"].ToString();
                 //    TVA = (int)ds.Tables[0].Rows[index]["TVA"];
                 //   tbTVA.Text = (Convert.ToString(TVA));
                    UnitateMasura = ds.Tables[0].Rows[index]["UnitateMasura"].ToString();
                    PretVanzare = (double)ds.Tables[0].Rows[index]["PretVanzare"];
                    TipProdus = ds.Tables[0].Rows[index]["TipProdus"].ToString();
                 

                    double Valoare = PretVanzare * Cantitate;
                 //   double ValoareTVA = Valoare * TVA * 0.01;

                    bool var = false;

                    if (dgIntroducereDocument.Rows.Count >= 0)
                    {

                        foreach (DataGridViewRow g in dgIntroducereDocument.Rows)
                        {
                            if (Convert.ToString(g.Cells[1].Value) == Denumire &&
                               Convert.ToDouble(g.Cells[4].Value) == PretVanzare)
                            {
                                int cant = (int)g.Cells[3].Value;
                                cant += Cantitate;
                                g.Cells[3].Value = cant;

                                Valoare = PretVanzare * cant;
                                g.Cells[5].Value = Valoare;

                                //ValoareTVA = Valoare * TVA * 0.01;
                                //g.Cells[7].Value = ValoareTVA;

                                var = true;
                            }
                        }

                        if (!var)
                        {
                            dgIntroducereDocument.Rows.Add(IdProdus, Denumire, UnitateMasura, Cantitate, PretVanzare, Valoare);
                        }

                    }
                    else
                    {
                        dgIntroducereDocument.Rows.Add(IdProdus, Denumire, UnitateMasura, Cantitate, PretVanzare, Valoare);
                    }



                    for (int i = 0; i < dgIntroducereDocument.Rows.Count; i++)
                    {
                        sum += Convert.ToDouble(dgIntroducereDocument.Rows[i].Cells["Valoare"].Value);
                    }
                    tbTotal.Text = sum.ToString();



                    foreach (DataGridViewRow row in dgIntroducereDocument.Rows)
                    {
                        row.HeaderCell.Value = (row.Index + 1).ToString();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Introduceti cantitatea");
            }
        }

        private void cmbDenumireProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Settings.Provider);
            con.Open();
            string UnitateMasura, CantitateDisponibila, PretVanzare = "";
            SqlCommand com = new SqlCommand("Select * from Produs Where Denumire='" + cmbDenumireProdus.Text + "'", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            SqlDataReader dr;
            dr = com.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    //Denumire = dr["Denumire"].ToString();
                    //  TVA = dr["TVA"].ToString();
                    UnitateMasura = dr["UnitateMasura"].ToString();
                    CantitateDisponibila = dr["Cantitate"].ToString();
                    //   PretCumparare = ds.Tables[0].Rows[index]["PretCumparare"].ToString();
                    PretVanzare = dr["PretVanzare"].ToString();

                    tbUM.Text = UnitateMasura;
                    tbPretVanzare.Text = PretVanzare;
                    tbCantitate.Text = "0";
                    tbCantitateDisponibila.Text = CantitateDisponibila;
                //    tbTVA.Text = dr["TVA"].ToString();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNomenclatorProduse frmNP = new frmNomenclatorProduse();
            frmNP.Show();
        }

        public bool VerificaErori()
        {
            bool existaErori = false;
            errorProvider.Clear();

            if (tbNumarBonFiscal.Text == "")
            {
                existaErori = true;
                errorProvider.SetError(tbNumarBonFiscal, "Nu ati introdus numarul bonului fiscal");
            }

            if (tbDataFactura.Text == "")
            {
                existaErori = true;
                errorProvider.SetError(tbDataFactura, "Nu ati introdus data bonului fiscal");
            }

            return existaErori;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string numarBonFiscal = null;
            if (VerificaErori() == true)
                return;
            try
            {

                string DataFacturii = tbDataFactura.Text;
                string Total = tbTotal.Text;
                numarBonFiscal = tbNumarBonFiscal.Text;
                string gestiuneSursa = cmbGestiuneSursa.Text;
                string gestiuneDestinatie = cmbGestiuneDestinatie.Text;

                BonTransfer detaliiFactura = new BonTransfer(DataFacturii, Total, numarBonFiscal, gestiuneSursa, gestiuneDestinatie);

                if (detaliiFactura.AddToDatabase() == true)
                {
                    tbDataFactura.Text = "";
                    tbNumarBonFiscal.Text = "";
                    cmbGestiuneDestinatie.Text = "";
                    cmbGestiuneSursa.Text = "";
                    tbTotal.Text = "";
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Bonul de transfer cu numarul " + numarBonFiscal + " a fost emis!" + 
                "\nS-au scazut produsele din stoc!" + " Doriti sa inregistrati NIR pentru bonul fiscal?");

            frmVizualizareBonTransfer vf = new frmVizualizareBonTransfer();
            vf.Show();
        }
    }
}

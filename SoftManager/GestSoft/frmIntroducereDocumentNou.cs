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
    public partial class frmIntroducereDocumentNou : Form
    {
        string Provider = null;

        public frmIntroducereDocumentNou()
        {
            InitializeComponent();
            Provider = Settings.Provider;
            umpleComboDenumireFurnizor();
            umpleComboDenumireProdus();
        }

        private void ShowChild(Form frm) // Loads a form into the main parent form
        {
            try
            {
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public frmIntroducereDocumentNou(string Denumire, string CIF, string NrRegCom, string Sediu, string Banca, string Cont, string Telefon, string Email, string Fax)
        {
            InitializeComponent();
            Provider = Settings.Provider;

            umpleComboDenumireFurnizor();
            umpleComboDenumireProdus();

            lblDateFirmaDenumire.Text = Denumire;
            lblDateFirmaCIF.Text = CIF;
            lblDateFirmaSediu.Text = Sediu;
            lblDateFirmaBanca.Text = Banca;
            lblDateFirmaCont.Text = Cont;
            lblDateFirmaTelefon.Text = Telefon;
            lblDateFirmaEmail.Text = Email;
            lblDateFirmaFax.Text = Fax;

            lblAfisareCIF.Text = Settings.CIF;
            lblAfisareSediu.Text = Settings.Sediu;
            lblAfisareBanca.Text = Settings.Banca;
            lblAfisareCont.Text = Settings.Cont;
            lblAfisareTelefon.Text = Settings.Telefon;
            lblAfisareEmail.Text = Settings.Email;

        }


        void umpleComboDenumireFurnizor()
        {
            cmbTipDocument.SelectedIndex = 0;
            cmbModPlata.SelectedIndex = 0;

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
                    string denumire = reader["denumire"].ToString();
                    cmbDenumireFurnizor.Items.Add(denumire);
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdaugaFurnizor af = new frmAdaugaFurnizor();
            af.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(Settings.Provider);
            con.Open();
            string CIF, Denumire, NrRegCom, Sediu, Banca, Cont, Telefon, Email = "";
            SqlCommand com = new SqlCommand("Select * from Furnizor", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            if (Convert.ToString(cmbDenumireFurnizor.SelectedItem) != "")
            {
                try
                {
                    da.Fill(ds);
                    int index = (int)cmbDenumireFurnizor.SelectedIndex;

                    CIF = ds.Tables[0].Rows[index]["CIF"].ToString();
                    Denumire = ds.Tables[0].Rows[index]["Denumire"].ToString();
                    NrRegCom = ds.Tables[0].Rows[index]["NrRegCom"].ToString();
                    Sediu = ds.Tables[0].Rows[index]["Sediu"].ToString();
                    Banca = ds.Tables[0].Rows[index]["Banca"].ToString();
                    Cont = ds.Tables[0].Rows[index]["Cont"].ToString();
                    Telefon = ds.Tables[0].Rows[index]["Telefon"].ToString();
                    Email = ds.Tables[0].Rows[index]["Email"].ToString();

                    Settings.CIF = CIF;
                    Settings.NrRegCom = NrRegCom;
                    Settings.Sediu = Sediu;
                    Settings.Banca = Banca;
                    Settings.Cont = Cont;
                    Settings.Telefon = Telefon;
                    Settings.Email = Email;

                    if (Convert.ToString(cmbDenumireFurnizor.SelectedItem) != "")
                    {
                        frmModificaFurnizor af = new frmModificaFurnizor(CIF, Denumire, NrRegCom, Sediu, Banca, Cont, Telefon, Email);
                        af.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Selectati un furnizor din lista!");
        }

        private void cmbDenumireDocumentIntrare_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Settings.Provider);
            con.Open();
            string CIF, NrRegCom, Sediu, Banca, Cont, Telefon, Email = "";
            SqlCommand com = new SqlCommand("Select * from Furnizor", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            try
            {
                da.Fill(ds);
                int index = (int)cmbDenumireFurnizor.SelectedIndex;

                CIF = ds.Tables[0].Rows[index]["CIF"].ToString();
                NrRegCom = ds.Tables[0].Rows[index]["NrRegCom"].ToString();
                Sediu = ds.Tables[0].Rows[index]["Sediu"].ToString();
                Banca = ds.Tables[0].Rows[index]["Banca"].ToString();
                Cont = ds.Tables[0].Rows[index]["Cont"].ToString();
                Telefon = ds.Tables[0].Rows[index]["Telefon"].ToString();
                Email = ds.Tables[0].Rows[index]["Email"].ToString();

                lblAfisareCIF.Text = CIF; Settings.CIF = CIF;
                Settings.NrRegCom = NrRegCom;
                lblAfisareSediu.Text = Sediu; Settings.Sediu = Sediu;
                lblAfisareBanca.Text = Banca; Settings.Banca = Banca;
                lblAfisareCont.Text = Cont; Settings.Cont = Cont;
                lblAfisareTelefon.Text = Telefon; Settings.Telefon = Telefon;
                lblAfisareEmail.Text = Email; Settings.Email = Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  ShowChild();
            frmListaFirme flf = new frmListaFirme();
            flf.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNomenclatorProduse np = new frmNomenclatorProduse();
            np.Show();
        }

        private void cmbDenumireProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Settings.Provider);
            con.Open();
            string UnitateMasura, PretVanzare = "";
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
                    //   Cantitate = ds.Tables[0].Rows[index]["Cantitate"].ToString();
                    //   PretCumparare = ds.Tables[0].Rows[index]["PretCumparare"].ToString();
                    PretVanzare = dr["PretVanzare"].ToString();

                    tbUM.Text = UnitateMasura;
                    tbPretVanzare.Text = PretVanzare;
                    tbCantitate.Text = "0";
                    tbTVA.Text = dr["TVA"].ToString();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string UnitateMasura, TipProdus = "";
            int IdProdus, TVA, Cantitate = 0;
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
                    int sum = 0;

                    IdProdus = (int)ds.Tables[0].Rows[index]["IdProdus"];
                    Denumire = ds.Tables[0].Rows[index]["Denumire"].ToString();
                    TVA = (int)ds.Tables[0].Rows[index]["TVA"];
                    tbTVA.Text = (Convert.ToString(TVA));
                    UnitateMasura = ds.Tables[0].Rows[index]["UnitateMasura"].ToString();
                    PretVanzare = (double)ds.Tables[0].Rows[index]["PretVanzare"];
                    TipProdus = ds.Tables[0].Rows[index]["TipProdus"].ToString();

                    double Valoare = PretVanzare * Cantitate;   
                    double ValoareTVA = Valoare * TVA * 0.01;

                    bool var = false;

                    if (dgIntroducereDocument.Rows.Count >= 0)
                    {

                        foreach (DataGridViewRow g in dgIntroducereDocument.Rows)
                        {
                            if (Convert.ToString(g.Cells[1].Value) == Denumire &&
                               Convert.ToDouble(g.Cells[5].Value) == PretVanzare)
                            {
                                int cant = (int)g.Cells[4].Value;
                                cant += Cantitate;
                                g.Cells[4].Value = cant;

                                Valoare = PretVanzare * cant;
                                g.Cells[6].Value = Valoare;

                                ValoareTVA = Valoare * TVA * 0.01;
                                g.Cells[7].Value = ValoareTVA;

                                var = true;
                            }
                        }

                        if (!var)
                        {
                            dgIntroducereDocument.Rows.Add(IdProdus, Denumire, TVA, UnitateMasura, Cantitate, PretVanzare, Valoare, ValoareTVA);
                        }

                    }
                    else
                    {
                        dgIntroducereDocument.Rows.Add(IdProdus, Denumire, TVA, UnitateMasura, Cantitate, PretVanzare, Valoare, ValoareTVA);
                    }


                   
                    for (int i = 0; i < dgIntroducereDocument.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dgIntroducereDocument.Rows[i].Cells["Valoare"].Value);
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

        public bool VerificaErori()
        {
            bool existaErori = false;
            errorProvider.Clear();

            if (tbSerieFactura.Text == "")
            {
                existaErori = true;
                errorProvider.SetError(tbSerieFactura, "Nu ati introdus Seria facturii");
            }

            if (tbDataFactura.Text == "")
            {
                existaErori = true;
                errorProvider.SetError(tbDataFactura, "Nu ati introdus Numarul facturii");
            }

            if (tbNumarFactura.Text == "")
            {
                existaErori = true;
                errorProvider.SetError(tbNumarFactura, "Nu ati introdus Numarul facturii");
            }
            return existaErori;
        }


        private void btnInregistreazaDocument_Click(object sender, EventArgs e)
        {
            string Seria = null;
            string Numar = null;


            if (VerificaErori() == true)
                return;
            try
            {
                string DataFacturii = tbDataFactura.Text;
                string TipPlata = cmbModPlata.Text;
                string Total = tbTotal.Text;
                string Discount = tbDiscount.Text;
                Seria = tbSerieFactura.Text;
                Numar = tbNumarFactura.Text;

                DetaliiFactura detaliiFactura = new DetaliiFactura(DataFacturii, TipPlata, Total, Discount, Seria, Numar);

                if (detaliiFactura.AddToDatabase() == true)
                {
                    tbDataFactura.Text = "";
                    cmbModPlata.Text = "";
                    tbDiscount.Text = "";
                    tbSerieFactura.Text = "";
                    tbNumarFactura.Text = "";
                    tbTotal.Text = "";
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("S-a înregistrat factura cu seria " + Seria + ",numarul " + Numar
         + "\n" + "Doriti sa inregistrati NIR pentru aceasta factura?");

            VizualizareFactura vf = new VizualizareFactura();
            vf.Show();
        }

    }
}

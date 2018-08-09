using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftManager.Clase;
using System.Data.SqlClient;

namespace SoftManager
{
    public partial class frmImportProduse : Form
    {
        private DataAccess AccessData = new DataAccess();
        private string sir_IdProdus;
        private string sir_Denumire;
        private string sir_UnitateMasura;
        private string sir_Cantitate;
        private string sir_TVA;
        private string sir_PretCumparare;
        private string sir_PretVanzare;
        private string sir_TipProdus;

        public frmImportProduse()
        {
            InitializeComponent();
        }

        private void btnImportProduse_Click(object sender, EventArgs e)
        {
            //  creeazaSiruri();
            Import();
        }


        private void creeazaSiruri()
        {
            //sir_IdProdus = new StringBuilder();
            //sir_Denumire = new StringBuilder();
            //sir_UnitateMasura = new StringBuilder();
            //sir_Cantitate = new StringBuilder();
            //sir_TVA = new StringBuilder();
            //sir_PretCumparare = new StringBuilder();
            //sir_PretVanzare = new StringBuilder();
            //sir_TipProdus = new StringBuilder();


            string sep = DataAccess.SeparatorZecimal();

            for (int i = 0; i <= dgImport.RowCount - 1; i++)
            {
                if (dgImport["cCHK", i].Value.ToString() == "da")
                {
                    // daca e bifat adaug la stringbuilder
                    sir_IdProdus = dgImport["IdProdus", i].Value.ToString();
                    // sir_IdProdus.Append("§");

                    sir_Denumire = dgImport["Denumire", i].Value.ToString();
                    //  sir_Denumire.Append("§");

                    sir_UnitateMasura = dgImport["UnitateMasura", i].Value.ToString();
                    //   sir_UnitateMasura.Append("§");


                    sir_Cantitate = dgImport["Cantitate", i].Value.ToString();
                    //     sir_Cantitate.Append("§");

                    sir_TVA = dgImport["TVA", i].Value.ToString();
                    //     sir_TVA.Append("§");

                    sir_PretCumparare = dgImport["PretCumparare", i].Value.ToString();
                    //     sir_PretCumparare.Append("§");

                    sir_PretVanzare = dgImport["PretVanzare", i].Value.ToString();
                    //      sir_PretVanzare.Append("§");
                    sir_TipProdus = dgImport["TipProdus", i].Value.ToString();
                }
            }

        }

        private void Import()
        {
            SqlConnection conexiune = null;
            try
            {

                for (int i = 0; i < dgImport.RowCount; i++)
                {

                    conexiune = new SqlConnection(Settings.Provider);
                    SqlCommand sql = new SqlCommand("Produs_ImportProduse", conexiune);
                    sql.CommandType = CommandType.StoredProcedure;
                    conexiune.Open();
                    //    if (dgImport["cCHK", i].Value.ToString() == "da")
                    //     {                   
                    sir_Denumire = dgImport["Denumire", i].Value.ToString();
                    sir_UnitateMasura = dgImport["UnitateMasura", i].Value.ToString();
                    sir_Cantitate = dgImport["Cantitate", i].Value.ToString();
                    sir_TVA = dgImport["TVA", i].Value.ToString();
                    sir_PretCumparare = dgImport["PretCumparare", i].Value.ToString();
                    sir_PretVanzare = dgImport["PretVanzare", i].Value.ToString();
                    sir_TipProdus = dgImport["TipProdus", i].Value.ToString();

                    sql.Parameters.Add("@Denumire", SqlDbType.VarChar).Value = sir_Denumire;
                    sql.Parameters.Add("@UnitateMasura", SqlDbType.VarChar).Value = sir_UnitateMasura;
                    sql.Parameters.Add("@Cantitate", SqlDbType.VarChar).Value = sir_Cantitate;
                    sql.Parameters.Add("@TVA", SqlDbType.VarChar).Value = sir_TVA;
                    sql.Parameters.Add("@PretCumparare", SqlDbType.VarChar).Value = sir_PretCumparare;
                    sql.Parameters.Add("@PretVanzare", SqlDbType.VarChar).Value = sir_PretVanzare;
                    sql.Parameters.Add("@TipProdus", SqlDbType.VarChar).Value = sir_TipProdus;

                    sql.ExecuteNonQuery();
                    conexiune.Close();
                    //      }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexiune.Close();
                MessageBox.Show("Import realizat cu succes!" + "\r\n" + "Au fost importate ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        private void btnIncarca_Click(object sender, EventArgs e)
        {
            String fisier = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Fisiere Excel (*.xls)|*.xls|Toate fisierele (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }

            fisier = ofd.FileName;
            lblCaleFisier.Text = fisier;


            IncarcaDateDinExcel(fisier); ;
            chkBifeazaTot.Checked = false;
        }

        private void IncarcaDateDinExcel(string Fisier)
        {
            DataTable dtBR = new DataTable();

            try
            {
                OleDbConnection xlsConn_br = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Fisier + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\";");
                OleDbDataAdapter cmd_br = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", xlsConn_br);
                cmd_br.Fill(dtBR);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Va rugam verificati daca exista sheet-ul Sheet1 " + "\n\r" + ex.Message, "Eroare fisier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (FisierulAreErori(dtBR) == true)
                return;

            dgImport.DataSource = DataAccess.AdaugaNrCrt(dtBR, 0); // daca nu are erori il afisez
            //     DataAccess.MarcheazaColoane_CuNU(dgImport, "cCHK", "nu");


        }


        private bool FisierulAreErori(DataTable dtr)
        {
            bool exista = false;

            //if (!dtr.Columns.Contains("IdProdus"))
            //{
            //    MessageBox.Show("Fisierul trebuie sa contina coloana IdProdus", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    exista = true;
            //}

            if (!dtr.Columns.Contains("Denumire"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana Denumire", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }

            if (!dtr.Columns.Contains("UnitateMasura"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana UnitateMasura", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }

            if (!dtr.Columns.Contains("Cantitate"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana Cantitate", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }

            if (!dtr.Columns.Contains("TVA"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana TVA", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }

            if (!dtr.Columns.Contains("PretCumparare"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana PretCumparare", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }

            if (!dtr.Columns.Contains("PretVanzare"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana PretVanzare", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }

            if (!dtr.Columns.Contains("TipProdus"))
            {
                MessageBox.Show("Fisierul trebuie sa contina coloana PretVanzare", "Coloana lipsa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exista = true;
            }


            if (exista == false)
            {  // 'exista toate coloanele deci merg mai departe


                string sep = "";
                sep = DataAccess.SeparatorZecimal();

                //pe fiecare rand verific daca exista date si sunt in formatul corect 
                for (int x = 0; x < dtr.Rows.Count - 1; x++)
                {
                    //verific coloana cu IdProdus daca are numai valori numerice
                    Int32 result = 0;
                    //   String iP = dtr.Rows[x]["IdProdus"].ToString();
                    //Int32.TryParse(iP, out result);
                    //if (result == 0)
                    //{
                    //    MessageBox.Show("Eroare la randul " + (x + 1).ToString() + ", coloana IdProdus. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    exista = true;
                    //    return true;
                    //}

                    String can = dtr.Rows[x]["Cantitate"].ToString();
                    Int32.TryParse(can, out result);
                    if (result == 0)
                    {
                        MessageBox.Show("Eroare la randul " + (x + 1).ToString() + ", coloana Cantitate. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exista = true;
                        return true;
                    }

                    String tvaVerificare = dtr.Rows[x]["TVA"].ToString();
                    Int32.TryParse(tvaVerificare, out result);
                    if (result == 0)
                    {
                        MessageBox.Show("Eroare la randul " + (x + 1).ToString() + ", coloana TVA. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exista = true;
                        return true;
                    }


                    String pcVerif = dtr.Rows[x]["PretCumparare"].ToString();
                    Int32.TryParse(pcVerif, out result);
                    if (result == 0)
                    {
                        MessageBox.Show("Eroare la randul " + (x + 1).ToString() + ", coloana PretCumparare. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exista = true;
                        return true;
                    }

                    String pvVerif = dtr.Rows[x]["PretVanzare"].ToString();
                    Int32.TryParse(pvVerif, out result);
                    if (result == 0)
                    {
                        MessageBox.Show("Eroare la randul " + (x + 1).ToString() + ", coloana PretVanzare. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exista = true;
                        return true;
                    }


                    //    If Not IsNumeric(dt.Rows(x).Item("prima_de_asig_noua").ToString.Replace(",", sep).Replace(".", sep)) Then
                    //        MessageBox.Show("Eroare la randul " & (x + 1).ToString & ", coloana prima_de_asig_noua. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    //        exista = True
                    //        Return True
                    //    End If


                    //    If dt.Rows(x).Item("nrvigneta").ToString <> "" Then 'nu intotdeauna este completat, daca nu are nimic inauntru nu verific
                    //        If Not IsNumeric(dt.Rows(x).Item("nrvigneta")) Then
                    //            MessageBox.Show("Eroare la randul " & (x + 1).ToString & ", coloana nrvigneta. Valoarea nu este numerica!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    //            exista = True
                    //            Return True
                    //        End If
                    //    End If



                    //    If Not EsteData(dt.Rows(x).Item("data_sfarsit_noua").ToString) Then
                    //        MessageBox.Show("Eroare la randul " & (x + 1).ToString & ", coloana data_sfarsit_noua. Valoarea nu este de tip data!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    //        exista = True
                    //        Return True

                    //    End If


                    //    //data facturare nu este obligatorie. daca exista ceva introdus totusi verific sa fie de tip data
                    //    if( dt.Rows(x).Item("data_facturare").ToString <> "" ){
                    //        if(!EsteData(dt.Rows(x).Item("data_facturare").ToString) {
                    //            MessageBox.Show("Eroare la randul " & (x + 1).ToString & ", coloana data_facturare. Valoarea nu este de tip data!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    //            exista = true;
                    //            return true ;
                    //   } 

                    //}


                    //  if( EsteBoolean(dt.Rows(x).Item("factureazaleasing").ToString) = False){
                    //      MessageBox.Show("Eroare la randul " & (x + 1).ToString & ", coloana factureazaleasing. Valoarea nu este de tip True sau False!", "Eroare valoare camp", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    //      exista = true;
                    //      return true;
                    //  }


                }
            }

            return exista;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBifeazaTot_CheckedChanged(object sender, EventArgs e)
        {
            if (dgImport.RowCount > 0)
                DataAccess.BifeazaTot(dgImport, "cCHK", chkBifeazaTot.Checked);
        }

    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftManager.Clase
{
    class DataAccess
    {
        public static string DaOriNu = "";

        enum tipTotal
        {
            Valoare
        }
        public static DataTable AdaugaNrCrt(DataTable t, int CateRanduriDeTotal)
        {
            if (!t.Columns.Contains("IdProdus"))
            {
                DataColumn cNrCrt = new DataColumn("IdProdus");
                t.Columns.Add(cNrCrt);
            }

            t.Columns["IdProdus"].SetOrdinal(0); // prima coloana din tabel

            for (int i = 0; i <= t.Rows.Count - 1 - CateRanduriDeTotal; i++)
                t.Rows[i]["IdProdus"] = (i + 1).ToString();

            for (int i = t.Rows.Count - CateRanduriDeTotal; i <= t.Rows.Count - 1; i++)
                t.Rows[i]["IdProdus"] = "TOTAL";


            return t;
        }

        public static void MarcheazaColoane_CuNU(DataGridView dg, string numeColoanaCHK, string falseValue)
        {
            if (dg.RowCount > 0)
            {
                for (int i = 0; i <= dg.RowCount - 1; i++)
                {
                    if (dg[numeColoanaCHK, i].Value == null)
                        dg[numeColoanaCHK, i].Value = falseValue;
                }
            }
        }

        public static string SeparatorZecimal()
        {
            string temp = System.Convert.ToString(1 / (double)2);
            return temp.Substring(2, 1);
        }

        public static void BifeazaTot(DataGridView dg, string numeColCHK, bool chk)
        {
            if (dg.Rows.Count == 0)
                return;
            if (chk == true)
                DaOriNu = "da";
            else
                DaOriNu = "nu";
        }
    }
}

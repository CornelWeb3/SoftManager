using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SoftManager
{
    public partial class frmPreluareBNR : Form
    {
        public frmPreluareBNR()
        {
            InitializeComponent();
            ActualizareAfisareCursuriValutare();
        }

        private void ActualizareAfisareCursuriValutare()
        {
            string DataCurenta = string.Empty;
            string moneda = string.Empty;
            string valoarea = string.Empty;
            DataTable datatable = new DataTable();
            datatable.Columns.Add("Data", typeof(string));
            datatable.Columns.Add("Moneda", typeof(string));
            datatable.Columns.Add("Valoare", typeof(string));

            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.bnr.ro/nbrfxrates.xml");

            XmlNodeList xmlDate = doc.GetElementsByTagName("Cube");
            XmlNodeList listdata = doc.GetElementsByTagName("Rate");

            foreach (XmlNode item in xmlDate)
            {
                DataCurenta = item.Attributes["date"].Value.ToString();
            }

            foreach (XmlNode item in listdata)
            {
                moneda = item.Attributes["currency"].Value.ToString();

                if (moneda == "USD" || moneda == "EUR")
                {
                    valoarea = item.InnerText;
                    datatable.Rows.Add(DataCurenta, moneda, valoarea);
                }
            }
            dg.DataSource = datatable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

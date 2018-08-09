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
    public partial class frmCorectieStoc : Form
    {
        public frmCorectieStoc()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNomenclatorProduse fnp = new frmNomenclatorProduse();
            fnp.Show();
        }
    }
}

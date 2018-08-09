using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using SoftManager.Clase;
using System.Xml;
using SoftManager;
using BankCredit;

namespace SoftManager
{
    public partial class frmMain : Form
    {
        private string InfoText;
        public bool LogOut = false;

        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            AfiseazaInfo();
            VerificaPermisiuni();
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

        #region "TreeViews"

        private void tIntrari()
        {
            if (treeIntrari.SelectedNode == null)
                return;
            if (treeIntrari.SelectedNode.ForeColor == Color.LightGray)
                return;

            switch (treeIntrari.SelectedNode.Name)
            {

                case "frmIntroducereDocumentNou":
                    {
                        ShowChild(new frmIntroducereDocumentNou());
                        break;
                    }

                case "frmListaDocumenteExistente":
                    {
                        ShowChild(new frmListaDocumenteExistente());
                        break;
                    }


                case "frmGenerareNIR":
                    {
                        frmListaDocumenteExistente ld = new frmListaDocumenteExistente();
                        ld.schimbareCuloare();
                        ShowChild(ld);
                        break;
                    }

                case "frmListaNIR":
                    {
                        ShowChild(new frmListaNirExistente());
                        break;
                    }
            }
        }

        private void tIesiri()
        {
            if (treeIesiri.SelectedNode == null)
                return;
            if (treeIesiri.SelectedNode.ForeColor == Color.LightGray)
                return;

            switch (treeIesiri.SelectedNode.Name)
            {
                case "8.1.0":
                    {
                        ShowChild(new Bon_de_transfer());
                        break;
                    }
            }
        }

        private void tStoc()
        {
            if (treeStoc.SelectedNode == null)
                return;
            if (treeStoc.SelectedNode.ForeColor == Color.LightGray)
                return;

            switch (treeStoc.SelectedNode.Name)
            {
                case "10.0":      
                    { 
                        ShowChild(new frmVizualizareStoc());
                        break;
                    }

                case "10.1":
                    {
                        ShowChild(new frmNomenclatorProduse());
                        break;
                    }
            }
        }

        private void tSituatii()
        {
            if (treeSituatii.SelectedNode == null)
                return;
            if (treeSituatii.SelectedNode.ForeColor == Color.LightGray)
                return;

            switch (treeSituatii.SelectedNode.Name)
            {
                case "10.0":
                    {
                        ShowChild(new frmVizualizareStoc());
                        break;
                    }

                case "bAdauga":
                     {
                         ShowChild(new frmSituatieInventar());
                         break;
                      }
            }
        }

        private void tRapoarte()
        {

            if (treeRapoarte.SelectedNode == null)
                return;
            if (treeRapoarte.SelectedNode.ForeColor == Color.LightGray)
                return;

            switch (treeRapoarte.SelectedNode.Name)
            {
                case "frmGrafic":
                    {
                        ShowChild(new frmGrafic());
                        break;
                    }
            }
        }

        private void treesoftmanager_NodeMouseDoubleClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            tIntrari();
        }

        #endregion

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            LogOut = true;
            this.Close();
            Logare l = new Logare();
            l.Show();
        }

        private void mnuIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listaFirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmListaFirme());
        }

        private void JurnalOperatiiJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmAdaugaFirma());
        }

        private void AdministrareConturiSoftManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new AdministrareConturi());
        }

        private void ModificareContExistentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new AdministrareConturiModificaSterge());
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmIntroducereDocumentNou());
        }

        private void mnuDespre_Click(object sender, EventArgs e)
        {
            ShowChild(new frmDespre());
        }

        private void treeSoftManager_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tStoc();
        }

        private void ModificareParolaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowChild(new frmModificareParola());
        }

        private void HiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cornelionut955.wixsite.com/gestsoft");
        }

        private void btnCascade_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form[] f = this.MdiChildren;
            int i = 0;
            for (i = f.GetUpperBound(0); i >= 0; i--)
            {
                if (f[i].WindowState == FormWindowState.Minimized)
                {
                    f[i].WindowState = FormWindowState.Normal;
                }
            }
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void btnTileHorizontal_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnTileVertical_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void btnShowHide_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (NavBar.Visible == true)
            {
                NavBar.Hide();
            }
            else
                NavBar.Show();
        }

        private void ImportProduse_Click(object sender, EventArgs e)
        {
            ShowChild(new frmImportProduse());
        }

        //verific idul pentru fiecare nod sa vad unde aloc permisiuni de afisare pentru un anumit user
        private void CheckNode(TreeNode node)
        {
            if (Utilizator.FereastraPermisa(node.Name) == false)
                node.Remove();
            else
                for (int y = node.Nodes.Count - 1; y >= 0; y += -1)
                    CheckNode(node.Nodes[y]);
        }

        //verific fiecare TreeView si nodurile lui
        private void CheckTree(TreeView t)
        {
            foreach (TreeNode n1 in t.Nodes)
            {
                for (int x = t.Nodes.Count - 1; x >= 0; x += -1)
                    CheckNode(t.Nodes[x]);
            }
        }

        private void VerificaPermisiuni()
        {
            CheckTree(treeIntrari);
            CheckTree(treeIesiri);
            CheckTree(treeStoc);
            CheckTree(treeSituatii);
            CheckTree(treeRapoarte);
            CheckMenu(MenuStrip1);
        }

        private void CheckMenu(MenuStrip menu)
        {
            foreach (ToolStripMenuItem item in menu.Items)
                ProcessMenuItem(item);
        }

        private void ProcessMenuItem(ToolStripMenuItem item)
        {
            if (item.Text.LastIndexOf("-") >= 0)
            {
                // Sunt verificate numai menuItems care au - in denumire, restul sunt lasata pe enabled ;)
                string codFereastra = item.Text.Substring(item.Text.LastIndexOf("-") + 1);
                if (Utilizator.FereastraPermisa(codFereastra) == false)
                    item.Enabled = false;
                item.Text = item.Text.Substring(0, item.Text.LastIndexOf("-"));
            }

            foreach (ToolStripItem subitem in item.DropDownItems)
            {
                if (subitem is ToolStripMenuItem)
                    ProcessMenuItem((ToolStripMenuItem)subitem);
            }
        }

        private void bCautare_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            ShowChild(new frmCautareDocumente());
        }

        private void AfiseazaInfo()
        {
            InfoText = "Versiune: " + Settings.versiuni.ToString() + "\r\n"; ;
            InfoText += "Utilizator: " + Settings.utilizator_Logat + "\r\n"; ;
            InfoText += "Data curentă: " + (string)DateTime.Now.ToString("dd.MM.yyyy") + Environment.NewLine;
            lblInfo.Text = InfoText.ToString();
        }

        private void preluareBNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmPreluareBNR());
        }

        private void cautareContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmCautareCont());
        }

        private void treeIesiri_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tIesiri();
        }

        private void treeSituatii_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tSituatii();
        }

        private void mnuManual_Click(object sender, EventArgs e)
        {
            Process.Start(@"I:\\LICENTA\\SoftManager\\SoftManager\\GestSoft\\Documentation\\manual.pdf");
        }

        private void mnuCreazaCopieSiguranta_Click(object sender, EventArgs e)
        {
            ShowChild(new frmBackupDatabase());
        }

        private void listaDocumenteIntrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmListaDocumenteExistente());
        }

        private void genreazaNIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChild(new frmListaNirExistente());
        }

        private void treeRapoarte_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tRapoarte();
        }

    }
}

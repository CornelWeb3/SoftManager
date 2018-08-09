using SoftManager;
using Microsoft.VisualBasic;
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
    public partial class frmBackupDatabase : Form
    {
        public frmBackupDatabase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atentie! Aceasta operatie poate dura ceva timp. Va rugam sa acordati timpul necesar completarii acesteia!", "Backup DB", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveFileDialog opf = new SaveFileDialog();
            opf.FileName = "Baza de date SoftManager " + Strings.Format(DateTime.Now, "dd MMM yyyy") + ".bak";
            opf.Filter = "Database Backup (*.bak)|*.bak";
            DialogResult result = opf.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string path = opf.FileName;

                    SqlConnection con = new SqlConnection(Settings.Provider);
                    SqlCommand sqlComm = new SqlCommand("backupdb '" + path + "'", con);
                    sqlComm.CommandTimeout = 0;

                    sqlComm.Connection.Open();

                    sqlComm.ExecuteNonQuery();

                    sqlComm.Connection.Close();
                } catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                    eroare.SetError(btnBrowse, "Eroare la salvare. Atentie! Aceasta operatie nu poate fi executata decat pe SERVER!");
                MessageBox.Show("Eroare la salvare. Atentie! Aceasta operatie nu poate fi executata decat pe serverul cu baza de date!" + ControlChars.CrLf + ex.Message, "Backup DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("Backup reusit!");
     
            }

        }
    }
}

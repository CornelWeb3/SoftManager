using SoftManager.Clase;
using SoftManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoftManager
{
    public partial class Logare : Form
    {
        public string Provider = "";
        public string versiune = "";

        public Logare()
        {
            InitializeComponent();
            Provider = Settings.Provider;
            //Provider = (@"Data Source = DESKTOP-1FGKC14\SQLSERVER;Initial Catalog=I:\LICENTA\GestSoft\DB\SoftGest.mdf;Integrated Security=True");
            // Provider = "Data Source=(DESKTOP-1FGKC14\\SQLSERVER)\v11.0;Initial Catalog=I:\\LICENTA\\GestSoft\\DB\\SoftGest.mdf;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            InitializareLogin();
            this.AcceptButton = btnLogare;
            this.ActiveControl = tb_Utilizator;
            tb_Utilizator.BackColor = Color.Yellow;
        }

        public void InitializareLogin()
        {
            SqlConnection con = new SqlConnection(Provider);
            con.Open();
            SqlCommand com = new SqlCommand("Select * from Setari", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            try
            {

                da.Fill(ds);
                versiune = ds.Tables[0].Rows[0]["Versiune"].ToString();
                lblVersiune.Text = "DB: v " + versiune;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Provider);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "Login_SELECT";
                SqlDataReader r = com.ExecuteReader();
                int count = 0;
                string Utilizator = "";
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Utilizator = r["Utilizator"].ToString();
                        string Parola = r["Parola"].ToString();

                        if (tb_Utilizator.Text.ToLower() == Utilizator && tb_Password.Text.ToLower() == Security.Decrypt(Parola))
                        {
                            Settings.permisiuni = r["Permisiuni"].ToString();
                            Settings.utilizator_Logat = Utilizator;
                            Settings.versiuni = versiune;
                            count = count + 1;
                        }
                    }
                }

                if (count == 1)
                {
                    this.Hide();
                    frmMain p = new frmMain();
                    p.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Datele introduse sunt incorecte!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Logare_Activated(object sender, EventArgs e)
        {
            tb_Utilizator.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdministrareConturiModificaSterge mp = new AdministrareConturiModificaSterge();
            mp.Show();
        }

        private void txtUtilizator_GotFocus(object sender, System.EventArgs e)
        {
            tb_Utilizator.BackColor = Color.Yellow;
            tb_Utilizator.SelectAll();
        }

        private void txtUtilizator_LostFocus(object sender, System.EventArgs e)
        {
            tb_Utilizator.BackColor = Color.White;
        }

        private void txtParola_GotFocus(object sender, System.EventArgs e)
        {
            tb_Password.BackColor = Color.Yellow;
            tb_Password.SelectAll();
        }

        private void txtParola_LostFocus(object sender, System.EventArgs e)
        {
            tb_Password.BackColor = Color.White;
        }

        private void tb_Password_Click(object sender, EventArgs e)
        {
            txtParola_GotFocus(sender, e);
            txtUtilizator_LostFocus(sender, e);
        }

        private void tb_Utilizator_Click(object sender, EventArgs e)
        {
            txtParola_LostFocus(sender, e);
            txtUtilizator_GotFocus(sender, e);
        }

    }
}
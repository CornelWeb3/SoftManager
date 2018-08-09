using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftManager.Clase
{
    class Utilizator
    {
        public string User;
        public string ParolaActuala;
        public string Parola;
        public string Email;
        public string Permisiuni="";
        DatabaseConnection connection = new DatabaseConnection();
        SqlConnection con = null;
        private string parolaNoua;
        private string parolaVeche;


        public string getUtilizator()
        {
            return this.User;
        }

        public void setUtilizator(string Utilizator)
        {
            this.User = Utilizator;
        }

        public Utilizator(string username)
        {
            this.User = username;
        }


        public Utilizator(string parolaActuala, string password, string email)
        {
            this.ParolaActuala = parolaActuala;
            this.Parola = password;
            this.Email = email;
        }

        public Utilizator(string utilizator, string password,string reintroducereParola, string email)
        {
            this.User = utilizator;
            this.Parola = password;
            this.Email = email;
        }

        public Utilizator(string parolaNoua, string parolaVeche)
        {
            this.parolaNoua = parolaNoua;
            this.parolaVeche = parolaVeche;
        }

        public bool AddToDatabase()
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Utilizatori_Adauga", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@Utilizator", SqlDbType.VarChar, 20).Value = User;
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar, 8000).Value = Security.Encrypt(Parola.ToLower());
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;

                //    if (Settings.sqlConnectionProperty.State != ConnectionState.Open){
                //      Settings.sqlConnectionProperty.Open();
                //    }    

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Acest utilizator exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Utilizatorul " + User + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool Modify(string utilizatorVechi)
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Utilizatori_Modifica", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@Utilizator", SqlDbType.VarChar, 20).Value = utilizatorVechi;
                cmd.Parameters.Add("@ParolaActuala", SqlDbType.VarChar, 20).Value = Security.Encrypt(ParolaActuala.ToLower());
                cmd.Parameters.Add("@Parola", SqlDbType.VarChar, 8000).Value = Security.Encrypt(Parola.ToLower());
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Acest utilizator exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Datele utilizatorului " + utilizatorVechi + " au fost modificate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool schimbareParola(string parolaNoua,string parolaVeche)
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Utilizatori_SchimbaParola", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@Utilizator", SqlDbType.VarChar, 20).Value = Settings.utilizator_Logat;
                cmd.Parameters.Add("@ParolaVeche_Enc", SqlDbType.VarChar, 8000).Value = Security.Encrypt(parolaVeche);
                cmd.Parameters.Add("@ParolaNoua_Enc", SqlDbType.VarChar, 8000).Value = Security.Encrypt(parolaNoua);


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Acest utilizator exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Datele utilizatorului " + User + " au fost modificate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

         public bool Delete(string utilizatorVechi)
        {
            try
            {
                con = new SqlConnection(Settings.Provider);
                SqlCommand cmd = new SqlCommand("dbo.Utilizatori_StergeCont", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@Utilizator", SqlDbType.VarChar, 20).Value = utilizatorVechi;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_utilizatori"))
                    MessageBox.Show("Acest utilizator nu exista!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show("Datele utilizatorului " + User + " au fost sterse cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public static bool FereastraPermisa(string codFereastra)
        {
            string[] perms = Settings.permisiuni.Split(System.Convert.ToChar(","));

            foreach (string s in perms)
            {
                if (s == codFereastra)
                    return true;
            }
            return false;
        }

    }
}

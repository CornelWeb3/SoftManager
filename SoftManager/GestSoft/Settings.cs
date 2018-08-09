using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftManager
{
    public class Settings
    {
        public static SqlConnection sqlConnection;
        public static SqlConnection sqlConnectionProperty { get; set; }

      public static string Provider ="Data Source=DESKTOP-1FGKC14\\SQLSERVER;Initial Catalog=SoftManager;User ID=sa;Password=wise2016";
       // public static string Provider = "Data Source= DESKTOP-1FGKC14\\SQLSERVER;" + "User Id=sa;" + "Password=wise2016;" + "AttachDbFilename=SoftManager.mdf";
        public static string utilizator_Logat="Utilizator";

        public static string versiuni = "versiune";
        //public static string Utilizator_Logat
        //{
        //    get { return utilizator_Logat; }
        //    set { utilizator_Logat = value; }
        //}


        public static string permisiuni = "Permisiuni";
        //public string Permisiuni
        //{
        //    get { return System.Convert.ToString(this.permisiuni); }
        //    set{ this.permisiuni = value; }
        //}

        public static string CIF = "";
        public static string NrRegCom = "";
        public static string Sediu = "";
        public static string Banca = "";
        public static string Cont = "";
        public static string Telefon = "";
        public static string Email = "";


    }
}

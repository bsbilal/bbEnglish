using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbEnglish
{
    public class dbConnectClass
    {

        static string sqlbaglanti = "server=localhost;user id=root;password=1234;persistsecurityinfo=False;database=dbenglish";

        public bool adminLogin(string pass)
         {
            MySqlConnection baglanti = new MySqlConnection(sqlbaglanti);
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select Name from dbenglish.users where name='Admin' AND Password='"+pass+"'", baglanti);
            MySqlDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {

                return true;

            }
            baglanti.Close();
            return false;
        }           
    }

}






  


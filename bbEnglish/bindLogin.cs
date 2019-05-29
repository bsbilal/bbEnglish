using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bbEnglish
{

  
    public class loginBind
    {
        static string sqlbaglanti = "server=localhost;user id=root;password=1234;persistsecurityinfo=False;database=dbenglish";

        public List<string> bindUsers()
        {
            List<string> values = new List<string>();
            MySqlConnection baglanti = new MySqlConnection(sqlbaglanti);
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select Name from dbenglish.users", baglanti);
            MySqlDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                
                values.Add(myReader.GetString(0));

            }
            baglanti.Close();
            return values;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bbEnglish
{
   public class bindAdmin
    {
        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();

        public List<string> bindUsers()
        {
            List<string> values = new List<string>();
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select Name from dbenglish.wordcategory", baglanti);
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


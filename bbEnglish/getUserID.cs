using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
    public class getUserID
    {



        public int Data(string word)
        {
            SQLBaglantisi sQ = new SQLBaglantisi();
            MySqlConnection baglanti = sQ.getConStr();

            baglanti.Open();
            string querryString = "select id from dbenglish.users where Name='" + word + "';";


            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();
            MySqlDataReader myReader = cmd.ExecuteReader();

            int data = 0;
            while (myReader.Read())
            {

                data = (myReader.GetInt16(0));

            }
            baglanti.Close();

            return data;

        }
    }
}

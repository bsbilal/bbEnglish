using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bbEnglish
{
    public class SQLBaglantisi
    {
       
        public MySqlConnection getConStr()
        {
            string sqlBaglanti = "server=localhost;user id=root;password=1234;persistsecurityinfo=False;database=dbenglish"; ;
            MySqlConnection baglanti = new MySqlConnection(sqlBaglanti);
            return baglanti;
        }
    }
}

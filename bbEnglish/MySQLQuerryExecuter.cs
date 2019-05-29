using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
    public class MySQLQuerryExecuter
    {

        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();


        public void execute(string QuerryString)
        {
            baglanti.Open();       
            MySqlCommand cmd = new MySqlCommand(QuerryString, baglanti);
            cmd.ExecuteScalar();
            baglanti.Close();

        }
    }
}

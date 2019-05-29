using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bbEnglish
{
    public class addWord 
    {
        private newWord YeniKelime;
        public addWord(newWord nW)
        {
            YeniKelime = nW;

        }
        public bool addToDb()
        {
            SQLBaglantisi sQ = new SQLBaglantisi();
            MySqlConnection baglanti = sQ.getConStr();
            baglanti.Open();
            string querryString = "CALL ADD_WORD('"+YeniKelime.Kelime+"',"+YeniKelime.catID+",'"+YeniKelime.Turkcesi+"','"+YeniKelime.exSent+"','"+YeniKelime.dataPath+"')";
            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();
            baglanti.Close();
            return true;
        }
    }
}

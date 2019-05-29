using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
   public class BindEditWords
    {
        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();


        //kategoriye göre kelime alıyor
        public List<newWord> getWords(int catID)
        {
            List<newWord> Kelimeler = new List<newWord>();
            baglanti.Open();
           
            string querryString = "Call GET_WORDS_BY_CATEGORY("+catID+")";
            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();



            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                newWord nW = new newWord();
                nW.WordID=myReader.GetInt16(0);
                nW.Kelime= myReader.GetString(1);
                nW.catID = myReader.GetInt16(2);
                nW.Turkcesi = myReader.GetString(3);
                nW.exSent = myReader.GetString(4);
                nW.dataPath = myReader.GetString(5);

                Kelimeler.Add(nW);
            }
            baglanti.Close();
            return Kelimeler;

        }
    }
}

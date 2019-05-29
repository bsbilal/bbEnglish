using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
    public class getImageQuests
    {
        private string m_CevapDataPath;
        private int m_wordID;
        public getImageQuests(int WordID)
        {
            this.m_wordID = WordID;

        }

        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();

        //yanlış cevapları tutan bir dizi 
        public string[] getFalseAnswers()
        {
            string[] falseArray = new string[3];
            baglanti.Open();
            string querryString = "CALL getImageQuest(" + m_wordID.ToString() + ");";
            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();

            newWord nW = new newWord();

            MySqlDataReader myReader = cmd.ExecuteReader();

            int i = 0;
            while (myReader.Read())
            {

                falseArray[i++] = myReader.GetString(0);

            }
            baglanti.Close();
            
            return falseArray;
        }


        // dogru cevabın uzantısını string olarak donduren bir dizi
        public string DogruCevap()
        {
           
            baglanti.Open();
            string querryString = "CALL ShowTrueDataPath(" + m_wordID.ToString() + ");";
            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();

            newWord nW = new newWord();

            MySqlDataReader myReader = cmd.ExecuteReader();


            while (myReader.Read())
            {

                m_CevapDataPath=(myReader.GetString(0));

            }
            baglanti.Close();

            return m_CevapDataPath;
        }
    }
}

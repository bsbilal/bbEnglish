using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bbEnglish
{
    public class getTextAnswers
    {
        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();

        private string m_TrueText;
        public string[] GetQuestbyProgressID(int wordID,int progressID)
        {
           
            baglanti.Open();
            // get answers prosedürü calıstırılıyor 
            string queryText= "Call GET_FAKE_WORDS("+wordID.ToString()+")";
            MySqlCommand cmd = new MySqlCommand(queryText, baglanti);
            /*   ilk wordid ikincisi progres id*/
            
            MySqlDataReader myReader = cmd.ExecuteReader();
            string[] questAnswers = new string[4];
            int i= 0;
            while (myReader.Read())
            {
                //quest answers dizisine cevapların string halleri basılıyor 0. indiste doğru deger tutuluyor
                questAnswers[i++]=(myReader.GetString(0));
             
                    
            }
            // veritabanından ilk deger dogru olarak cekiliyor zzzzzzzzzkllzl

            m_TrueText = questAnswers[0];
            baglanti.Close();
            return questAnswers;
        }
        //doğru deger geri döndürülüyor 
        public string getTrueAnswer()
        {
            return m_TrueText;
        }

    }
}

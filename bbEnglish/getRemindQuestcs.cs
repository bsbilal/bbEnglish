using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
    public class getRemindQuestcs
    {
        private int uID;
        private int SoruSayisi = 0;
        public getRemindQuestcs(int userid)
        {
            this.uID=userid;
        }
        
        public List<getQuestList>  GetQuest()
        {
            SQLBaglantisi sQ = new SQLBaglantisi();
            MySqlConnection baglanti = sQ.getConStr();
               

                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("CALL getRemindQuests("+uID+");", baglanti);
                MySqlDataReader myReader = cmd.ExecuteReader();
                List<getQuestList> values = new List<getQuestList>();

             
                  while (myReader.Read())
                    {
                //listeye sağlanan  kelime id'si ve word id'yi ekliyoruz

                values.Add(new getQuestList { m_wordID = myReader.GetInt16(0), m_progressID = myReader.GetInt16(1)});
                //kayıt geldikce soru sayısını arttırıyor
                    SoruSayisi++;

                 }
            baglanti.Close();
            return values;
         }

        public int Count()
        {
            return SoruSayisi;
        }
    }
}



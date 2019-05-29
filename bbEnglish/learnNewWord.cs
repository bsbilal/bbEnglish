using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
    public class learnNewWord
    {
        private int userID;
        public learnNewWord(int uID)
        {
            this.userID = uID;
        }

        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();
        //öğrenmek için yeni kelime oluşturuyor
        public newWord getWord()
        {
           
            baglanti.Open();
            string querryString = "CALL generateWord(" + userID.ToString() + ");";
            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();

            newWord nW = new newWord();

            MySqlDataReader myReader = cmd.ExecuteReader();
      
            while (myReader.Read())
            {
              
                nW.WordID = (myReader.GetInt16(0));
                nW.Kelime= (myReader.GetString(1));
                nW.catID= (myReader.GetInt16(2));
                nW.Turkcesi= (myReader.GetString(3));
                nW.exSent= (myReader.GetString(4));
                nW.dataPath=(myReader.GetString(5));
            }
            baglanti.Close();

            return nW;

        }
        public void AddToDb(int wordID)
        {
           
            baglanti.Open();
            //birinci degiskene userid ikinciisne kelime id
            try { 
            string querryString = "CALL learnNewWord(" + userID.ToString() + ","+wordID.ToString()+");";
            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();
            
            baglanti.Close();
            System.Windows.Forms.MessageBox.Show("Kelime Öğrenildi..!");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Veritabanı hatası..!");
            }
        }
        //sorulacak sorunun bilgilerini alıyor
        public newWord GetFromDb(int wordID)
        {
            newWord nW = new newWord();

            baglanti.Open();
            try
            {

                string querryString = "CALL GET_WORD_BY_ID(" + wordID.ToString()+");";
                MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                    nW.WordID = (myReader.GetInt16(0));
                    nW.Kelime = (myReader.GetString(1));
                    nW.catID = (myReader.GetInt16(2));
                    nW.Turkcesi = (myReader.GetString(3));
                    nW.exSent = (myReader.GetString(4));
                    nW.dataPath = (myReader.GetString(5));
                }
                baglanti.Close();

              
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Veritabanı hatası..!");
            }
            return nW;

        }




    }
}

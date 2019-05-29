using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace bbEnglish
{
    public class GetStats
    {

        static SQLBaglantisi sQ = new SQLBaglantisi();
        MySqlConnection baglanti = sQ.getConStr();

        public int[] Get2018(int userID)
        {
            int[] OgrenilenSayilar = new int[12];


            baglanti.Open();
            string querryString = "Call GET_LEARN_STATS_2018(" + userID.ToString() + ")";


            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();
            MySqlDataReader myReader = cmd.ExecuteReader();

            int i = 0;
            while (myReader.Read())
            {

                OgrenilenSayilar[i++] = (myReader.GetInt16(0));

            }
            baglanti.Close();

            return OgrenilenSayilar;
        }
        public int[] Get2019(int userID)
        {
            int[] OgrenilenSayilar = new int[5];


            baglanti.Open();
            string querryString = "Call GET_LEARN_STATS_2019(" + userID.ToString() + ")";


            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();
            MySqlDataReader myReader = cmd.ExecuteReader();

            int i = 0;
            while (myReader.Read())
            {

                OgrenilenSayilar[i++] = (myReader.GetInt16(0));

            }
            baglanti.Close();

            return OgrenilenSayilar;


        }

        //kişinin oğrendigi ve tüm kelime sayısıını donduruyor
        public int[] GetWordCounts(int userID)
        {

            //1.si kişinin ogrendigi kelime sayısı 2.si kayıtlı toplam kelime sayısı
            int[] Degerler = new int[2];


            baglanti.Open();
            string querryString = "Call GET_LEARN_COUNT_AND_WORD_COUNT(" + userID.ToString() + ")";


            MySqlCommand cmd = new MySqlCommand(querryString, baglanti);
            cmd.ExecuteScalar();
            MySqlDataReader myReader = cmd.ExecuteReader();

            int i = 0;
            while (myReader.Read())
            {

                Degerler[i++] = (myReader.GetInt16(0));

            }
            baglanti.Close();


            //1.si kişinin ogrendigi kelime sayısı 2.si kayıtlı toplam kelime sayısı

            return Degerler;




        }
    }
}
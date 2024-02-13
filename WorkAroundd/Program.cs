using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WorkAroundd
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            

            selamVer("Bilal");

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Bilal";
            ogrenciler[1] = "Erva";
            ogrenciler[2] = "Nur";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
           
            foreach (string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");

            foreach(string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

        }

        static void selamVer(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }

        


        

        public class Vatandas
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }
    }
}

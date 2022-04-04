using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Barney";
            musteri1.Soyadi = "Stinson";
            musteri1.Yasi = 48;
            musteri1.Cinsiyeti = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ted";
            musteri2.Soyadi = "Mosby";
            musteri2.Yasi = 47;
            musteri2.Cinsiyeti = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Robin";
            musteri3.Soyadi = "Scherbatsky";
            musteri3.Yasi = 40;
            musteri3.Cinsiyeti = "Kadın";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Lily";
            musteri4.Soyadi = "Aldrin";
            musteri4.Yasi = 48;
            musteri4.Cinsiyeti = "Kadın";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Marshall";
            musteri5.Soyadi = "Eriksen";
            musteri5.Yasi = 48;
            musteri5.Cinsiyeti = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager  musteri= new MusteriManager();
            musteri.Ekle(musteri3);
            musteri.Sil(musteri2);
            //musteri.Listele(musteri5); //Bu ise seçilen tek bir kişiyi listelemek için
            //Bütün Müşterileri Listelemek için for ile gösterdim
            Console.WriteLine("Müşteriler Listeleniyor");
            for (int i = 0; i <= musteriler.Length; i++)
            {
                musteri.Listele(musteriler[i]);
            }
            Console.WriteLine("Müşteriler Listelendi");
        }
    }
}

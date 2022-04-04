using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi"); 
            Console.WriteLine("Müşteri ID: "+musteri.Id);
            Console.WriteLine("İsim Soyisim: " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine("Yaşı: " + musteri.Yasi);
            Console.WriteLine("Cinsiyeti: " + musteri.Cinsiyeti);
            Console.WriteLine("..............");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
            Console.WriteLine("Müşteri ID: " + musteri.Id);
            Console.WriteLine("İsim Soyisim: " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine("Yaşı: " + musteri.Yasi);
            Console.WriteLine("Cinsiyeti: " + musteri.Cinsiyeti);
            Console.WriteLine("..............");
        }

        public void Listele(Musteri musteri)
        {
                           
                
                Console.WriteLine("Müşteri ID: " + musteri.Id);
                Console.WriteLine("İsim Soyisim: " + musteri.Adi + " " + musteri.Soyadi);
                Console.WriteLine("Yaşı: " + musteri.Yasi);
                Console.WriteLine("Cinsiyeti: " + musteri.Cinsiyeti);
                Console.WriteLine("..............");
                
               

        }


    }

}

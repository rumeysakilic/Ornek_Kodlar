using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Ogrenci ogr1= new Ogrenci("201213002","Rumeysa","KILIÇ",75,75,85,"Konya Teknik Üniversitesi");
            Console.WriteLine("Öğrenci Bilgi Ekranına Hoş Geldiniz! Lütfen bir seçim yapınız!");
            Console.WriteLine("1- Öğrenci Bilgi Göster");
            Console.WriteLine("2-Öğrenci Ortalamasını Göster");
            Console.WriteLine("3-Öğrenci Okulunu Öğren");
            Console.WriteLine("4-Çıkış Yap");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim == 1)
            {
                ogr1.ogrenciBilgileriGoster();
            }
            else if(secim == 2)
            {
                ogr1.ortalamaBul();
            }
            else if(secim == 3)
            {
                ogr1.okulGetir();
            }
            else if(secim == 4) 
            {
                Console.WriteLine("Çıkış yapılıyor...");
            }

        }
    }
}

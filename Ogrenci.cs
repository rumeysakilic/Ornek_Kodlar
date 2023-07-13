using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Ogrenci
    {
        private string ogr_no;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(string _ogrNo,string _isim,string _soyisim,int _vize1,int _vize2, int _final,string _okulIsmi)
        {
            ogr_no = _ogrNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci No:" + ogr_no);
            Console.WriteLine("Öğrenci Adı:" + isim);
            Console.WriteLine("Öğrenci Soyadı:" + soyisim);
            Console.WriteLine("Öğrenci 1.vize notu:" + vize1);
            Console.WriteLine("Öğrenci 2. vize notu:" + vize2);
            Console.WriteLine("Öğrenci final  notu:" + final);
            Console.WriteLine("Öğrenci okul ismi:" + okulIsmi);
        }
        public void ortalamaBul()
        {
            double ort;
            ort = (vize1 + vize2 + final) / 3;
            Console.WriteLine(isim + " isimli öğrencinin not ortalaması: " + ort);
        }
        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin okul ismi:" +okulIsmi);
        }

    }
}

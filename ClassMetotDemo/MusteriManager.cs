using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void EkleMusteri(Musteri musteri)
        {
            Console.WriteLine("Aramıza Hoşgeldin " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("Yeni Hesap No : "+musteri.HesapNo);
        }

        public void SilMusteri(Musteri musteri)
        {
            Console.WriteLine("Görüşmek Üzere "+musteri.Ad+" "+musteri.Soyad);
        }
    }
}

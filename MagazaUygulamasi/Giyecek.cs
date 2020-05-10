using System;

namespace MagazaUygulamasi
{
    class Giyecek:Urun
    {
        private string m_giyecekAdi; 
        public override string UrunAdi 
        { 
            get { return m_giyecekAdi; } 
            set { m_giyecekAdi = value; } 
        }
        public override void EkranaYazdir() 
        { 
            Console.WriteLine("{0} adlı giyeceğin satış fiyatı {1:F2} Lira'dır", this.m_giyecekAdi, this.SatisFiyatiHesapla()); 
            Console.WriteLine("***********************************"); 
        }
    }
}

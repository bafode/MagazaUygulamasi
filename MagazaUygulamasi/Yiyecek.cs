using System;

namespace MagazaUygulamasi
{
    class Yiyecek:Urun
    {
        private string m_YiyecekAdi; 
        public override string UrunAdi 
        { 
            get { return m_YiyecekAdi; } 
            set { m_YiyecekAdi = value; } 
        }
        public override void EkranaYazdir() 
        { 
            Console.WriteLine("{0} adlı yiyeceğin satış fiyatı {1:F2} Lira'dır", this.m_YiyecekAdi, this.SatisFiyatiHesapla()); 
            Console.WriteLine("***********************************"); 
        }
    }
}

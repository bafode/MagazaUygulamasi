using System;
using System.Collections.Generic;
using System.Text;

namespace MagazaUygulamasi
{
    class Kitap : Urun
    {
        private string m_kitapAdi;
        private string m_ISBNNo;
        public override string UrunAdi
        {
            get { return m_kitapAdi; }
            set { m_kitapAdi = value; }
        }
        public string ISBNNo
        {
            get { return m_ISBNNo; }
            set { m_ISBNNo = value; }
        }
        public override void EkranaYazdir()
        {
            Console.WriteLine("{0} adlı {1} ISBN nolu kitabın satış fiyatı {2:F2} Lira'dır", this.m_kitapAdi, this.ISBNNo, this.SatisFiyatiHesapla());
            Console.WriteLine("***********************************");
        }
    }
}

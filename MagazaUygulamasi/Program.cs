using System;

namespace MagazaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kitap Bilgileri 
            Kitap yeniKitap = new Kitap(); 
            Console.Write("Kitap Adını giriniz : "); 
            yeniKitap.UrunAdi = Console.ReadLine(); 
            Console.Write("Alış Fiyatını giriniz : "); 
            yeniKitap.AlisFiyati = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("KDV oranını giriniz : "); 
            yeniKitap.KDV = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Kar oranını giriniz : "); 
            yeniKitap.KarOrani = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("ISBN No : "); 
            yeniKitap.ISBNNo = Console.ReadLine(); 
            Console.WriteLine("***********************************"); 
            
            // Giyecek Bilgileri 
            Giyecek yeniGiyecek = new Giyecek(); 
            Console.Write("Giyecek Adını giriniz:"); 
            yeniGiyecek.UrunAdi = Console.ReadLine(); 
            Console.Write("Fiyatını giriniz:"); 
            yeniGiyecek.AlisFiyati = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("KDV oranını giriniz:"); 
            yeniGiyecek.KDV = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Kar oranını giriniz:"); 
            yeniGiyecek.KarOrani = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("***********************************"); 
            
            //Yiyecek Bilgileri 
            Yiyecek yeniYiyecek = new Yiyecek(); 
            Console.Write("Yiyecek Adını giriniz:"); 
            yeniYiyecek.UrunAdi = Console.ReadLine(); 
            Console.Write("Alış Fiyatını giriniz:"); 
            yeniYiyecek.AlisFiyati = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("KDV oranını giriniz:"); 
            yeniYiyecek.KDV = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Kar oranını giriniz:"); 
            yeniYiyecek.KarOrani = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("***********************************");
            Console.WriteLine(); 
            Console.WriteLine("***********************************"); 
            //Ekrana Yazdırma 
            yeniKitap.EkranaYazdir(); 
            yeniGiyecek.EkranaYazdir(); 
            yeniYiyecek.EkranaYazdir();
        }
    }
}

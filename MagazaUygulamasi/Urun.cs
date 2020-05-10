namespace MagazaUygulamasi
{
    abstract class Urun
    {
        private double m_AlisFiyati;
        private double m_KarOrani;
        private double m_KDV;
        public abstract string UrunAdi { get; set; }
         
        public double AlisFiyati 
        { 
            get { return m_AlisFiyati; } 
            set { m_AlisFiyati = value; } 
        }
        
        public double KarOrani 
        { 
            get { return m_KarOrani; } 
            set { m_KarOrani = value; } 
        }
        
        public double KDV 
        {  
            get { return m_KDV; } set { m_KDV = value; } 
        }
        public virtual double SatisFiyatiHesapla() 
        { 
            return (AlisFiyati * ((1 + KarOrani / 100)) * (1 + KDV / 100)); 
        }
        public abstract void EkranaYazdir();
    }
}


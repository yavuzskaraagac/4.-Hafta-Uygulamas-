using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunSinifi
{
    public class Urun
    {
        // Özellikler
        public string Ad { get; private set; }
        public decimal Fiyat { get; private set; }

        private decimal indirim;
        public decimal Indirim
        {
            get { return indirim; }
            set
            {
                if (value >= 0 && value <= 50)
                    indirim = value;
                else
                    throw new ArgumentOutOfRangeException("İndirim %0 ile %50 arasında olmalıdır.");
            }
        }

        // Yapıcı Metot
        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
            indirim = 0; // Başlangıç indirimi 0 olarak ayarlanır
        }

        // İndirimli Fiyat Metodu
        public decimal IndirimliFiyat()
        {
            return Fiyat * (1 - (Indirim / 100));
        }
    }
}
public class Program
{
    public static void Main()
    {
        Console.ReadKey();
    }

}
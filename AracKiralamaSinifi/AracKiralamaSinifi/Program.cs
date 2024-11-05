using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSinifi
{
    public class KiralikArac
    {
        // Özellikler
        public string Plaka { get; private set; }
        public decimal GunlukUcret { get; private set; }
        public bool MusaitMi { get; private set; }

        // Yapıcı Metot
        public KiralikArac(string plaka, decimal gunlukUcret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukUcret;
            MusaitMi = true; // Varsayılan olarak araç müsait
        }

        // Aracı Kirala Metodu
        public void AraciKirala()
        {
            if (MusaitMi)
            {
                MusaitMi = false;
                Console.WriteLine($"{Plaka} plakalı araç kiralandı.");
            }
            else
            {
                Console.WriteLine($"{Plaka} plakalı araç zaten kiralanmış durumda.");
            }
        }

        // Aracı Teslim Et Metodu
        public void AraciTeslimEt()
        {
            if (!MusaitMi)
            {
                MusaitMi = true;
                Console.WriteLine($"{Plaka} plakalı araç teslim edildi.");
            }
            else
            {
                Console.WriteLine($"{Plaka} plakalı araç zaten müsait.");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

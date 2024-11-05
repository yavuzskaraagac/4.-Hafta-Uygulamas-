using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteriSinifi
{
    public class Kisi
    {
        // Özellikler
        public string Ad { get; private set; }
        public string Soyad { get; private set; }
        public string TelefonNumarasi { get; private set; }

        // Yapıcı Metot
        public Kisi(string ad, string soyad, string telefonNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }

        // Kisi Bilgisi Metodu
        public string KisiBilgisi()
        {
            return $"Ad Soyad: {Ad} {Soyad}, Telefon: {TelefonNumarasi}";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSinifi
{
    public class Kitap
    {
        // Kitap Özellikleri
        public string Ad { get; private set; }
        public string Yazar { get; private set; }
        public int Yil { get; private set; }

        // Yapıcı Metot
        public Kitap(string ad, string yazar, int yil)
        {
            Ad = ad;
            Yazar = yazar;
            Yil = yil;
        }

        // Kitap Bilgisi Metodu
        public string KitapBilgisi()
        {
            return $"Ad: {Ad}, Yazar: {Yazar}, Yıl: {Yil}";
        }
    }

    public class Kutuphane
    {
        // Kitaplar Listesi Özelliği
        public List<Kitap> Kitaplar { get; private set; }

        // Yapıcı Metot: Kitap listesi boş olarak başlatılıyor
        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
        }

        // Kitap Ekleme Metodu
        public void KitapEkle(Kitap yeniKitap)
        {
            this.Kitaplar.Add(yeniKitap); // this ile kütüphane nesnesine ait olduğunu belirtir
            Console.WriteLine($"'{yeniKitap.Ad}' adlı kitap kütüphaneye eklendi.");
        }

        // Kitapları Listeleme Metodu
        public void KitaplariListele()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in this.Kitaplar)
            {
                Console.WriteLine(kitap.KitapBilgisi());
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

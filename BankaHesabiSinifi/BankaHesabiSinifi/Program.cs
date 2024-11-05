using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHesabiSinifi
{
    public class BankaHesabi
    {
        public string HesapNumarasi { get; set; }
        public decimal Bakiye { get; private set; }

        public BankaHesabi (string hesapnumarasi, decimal bakiye)
        {
            HesapNumarasi = hesapnumarasi;
            Bakiye = bakiye;

        }
        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL.");
            }
            else
            {
                Console.WriteLine("Yatırılacak miktar pozitif olmalıdır.");
            }

        }

        public void ParaCek (decimal miktar)
        {
            if (miktar > 0 && Bakiye >= miktar)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL.");
            }
            else if (miktar > Bakiye)
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
            else
            {
                Console.WriteLine("Çekilecek miktar pozitif olmalıdır.");
               
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

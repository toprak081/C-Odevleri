using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiokunus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ile 99 arasında bir sayı giriniz");


            if (!int.TryParse(Console.ReadLine(), out int sayi))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                Console.ReadLine();
                return;
            }

            if (sayi < 0 || sayi >= 100)
            {
                Console.WriteLine("Yanlış sayı, lütfen kontrol ediniz");
            }
            else
            {
                Console.WriteLine($"Sayının okunuşu: {SayiyiOkunusaCevir(sayi)}");
            }

            Console.ReadLine();
        }

        static string SayiyiOkunusaCevir(int sayi)
        {
            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

            if (sayi < 10)
                return birler[sayi];
            else if (sayi < 20)
                return "On" + birler[sayi - 10];
            else
                return onlar[sayi / 10] + birler[sayi % 10];
        }
    }
}
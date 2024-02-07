using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    internal class Program
    {
        private static readonly string vowels = "aeıioöuüAEIİOÖUÜ";
        static void Main(string[] args)
        {
            Console.WriteLine("Metini giriniz:");
            string text = Console.ReadLine();
            int totalvowels = countvowels(text);
            Console.WriteLine("Toplam sesli harf sayısı: " + totalvowels);
        }

        static int countvowels(string text)
        {
            string vowels = "aeıioöuüAEIİOÖUÜ";
            int totalvowels = 0;

            foreach (char character in text)
            {
                if (vowels.Contains(character))
                {
                    totalvowels++;
                }
            }

            return totalvowels;
        }
    }
}

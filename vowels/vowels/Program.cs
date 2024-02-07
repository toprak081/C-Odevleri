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
            int totalvowels = CountVowels(text);
            Console.WriteLine("Toplam sesli harf sayısı: " + totalvowels);
            
            Console.ReadLine();
        }
        static int CountVowels(string text)
        {
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
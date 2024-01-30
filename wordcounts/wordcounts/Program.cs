using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordcounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metini giriniz:");
            string text = Console.ReadLine();

            int wordcount = countwordnumber(text);

            Console.WriteLine($"Metinde geçen kelimelerin sayısı: {wordcount}");

            Console.WriteLine("Program sona erdi. Çıkış yapmak için bir tuşa basın.");
            Console.ReadKey();
        }

        static int countwordnumber(string text)
        {
            string[] words = text.Split(' ', '.', ',', '!', '?');
            return words.Length;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Finding_a_Palindrome
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Bir kelime veya cümle girin: ");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            bool isPalindrome = input.Equals(reversed);
            if (isPalindrome)
                Console.WriteLine("Girdi bir palindromdur.");
            else
                Console.WriteLine("Girdi bir palindrom değildir.");
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

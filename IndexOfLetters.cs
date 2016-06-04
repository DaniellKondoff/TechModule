using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            int index;

            //char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string word = Console.ReadLine().Trim().ToLower();

            foreach (var letter in word)
            {
                index = (int)letter - (int)'a';
                Console.WriteLine("{0} -> {1} ", letter, index);
            }
            Console.WriteLine();

            
            
           
            
            
            
        }
    }
}

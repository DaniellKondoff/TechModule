using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Largest
    {
        static void Main(string[] args)
        {
            //string values = Console.ReadLine();
            //string[] items = values.Split(' ');

            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');

            int smallerArrayLenght = Math.Min(input1.Length, input2.Length);

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (input1[i]==input2[i])
                {
                    leftCounter++;
                }
            }

            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (input1[input1.Length-1-i]==input2[input2.Length - 1-i])
                {
                    rightCounter++;
                }
            }

            Console.WriteLine(Math.Max(rightCounter,leftCounter));        
            
        }
    }
}

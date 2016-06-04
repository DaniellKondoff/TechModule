using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CampareCharArrays
{
    class CampareChar
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);
            bool areEquel = false;

            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (firstArray[i]==secondArray[i])
                {
                    continue;
                }

                else
                {
                    if (firstArray[i]<secondArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secondArray);
                    }
                    else
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(firstArray);
                    }
                    areEquel = true;
                    break;
                }
            }

            if (!areEquel)
            {
                if (firstArray.Length<=secondArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }


            //string[] arrays = {new string(firstArray),new string (secondArray)};
            //Array.Sort(arrays);
            //Console.WriteLine(string.Join("\n", arrays));

            
        }
    }
}

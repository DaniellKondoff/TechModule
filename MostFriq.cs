using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MostFrequentNumber
{
    class MostFriq
    {
        static void Main(string[] args)
        {
            int[] numebrs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int max = 0;
            int result = 0;
            List<int> longest = new List<int>();

            Array.Sort(numebrs);

            for (int i = 0; i < numebrs.Length - 1; i++)
            {
                if (numebrs[i]==numebrs[i+1])
                {
                    counter++;
                    if (counter>=max)
                    {
                        max = counter;
                        result = numebrs[i];
                       
                    }
                }

                else
                {
                    counter = 1;
                }
                
            }

            
        }
    }
}

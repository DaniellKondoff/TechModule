using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Fold
    {
        static void Main(string[] args)
        {
            int[] numebrs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numebrs.Length / 4;

            int[] middleElements = new int[2 * k];
            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = numebrs[k + i];
            }

            int[] firstElements = new int[k];
            for (int i = 0; i < firstElements.Length; i++)
            {
                firstElements[i] = numebrs[i];
            }

            int[] lastKeyElements = new int[k];
            for (int i = 0; i < lastKeyElements.Length; i++)
            {
                lastKeyElements[i] = numebrs[i + 3 * k];
            }

            Array.Reverse(lastKeyElements);
            Array.Reverse(firstElements);

            int[] firstAndLastKeyElements = new int[k * 2];
            for (int i = 0; i < firstAndLastKeyElements.Length; i++)
            {
                if (i< k)
                {
                    firstAndLastKeyElements[i] = firstElements[i];
                }
                else
                {
                    firstAndLastKeyElements[i] = lastKeyElements[i - k];
                }
            }

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] += firstAndLastKeyElements[i];
            }

            Console.WriteLine(string.Join(" ",middleElements));
        }
    }
}

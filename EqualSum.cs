using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSum
    {
        static void Main()
        {
            int[] numebrs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIndexFound = false;

            for (int currentElement = 0; currentElement < numebrs.Length; currentElement++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int i = currentElement+1; i < numebrs.Length; i++)
                {
                    sumRight += numebrs[i];
                }

                for (int i = 0; i < currentElement; i++)
                {
                    sumLeft += numebrs[i];
                }

                if (sumLeft==sumRight)
                {
                    Console.WriteLine(currentElement);
                    isIndexFound = true;
                    break;
                }
            }

            if (!isIndexFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequence
    {
        static void Main()
        {
            int[] numebrs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> temp = new List<int>();
            List<int> longest = new List<int>();

            temp.Add(numebrs[0]);

            for (int i = 1; i < numebrs.Length; i++)
            {
                if (numebrs[i]>numebrs[i-1])
                {
                    temp.Add(numebrs[i]);
                    if (i==numebrs.Length-1 && temp.Count>longest.Count)
                    {
                        longest.Clear();
                        longest.InsertRange(0, temp);
                    }
                }

                else
                {
                    if (temp.Count>longest.Count)
                    {
                        longest.Clear();
                        longest.InsertRange(0, temp);
                    }
                    temp.Clear();
                    temp.Add(numebrs[i]);
                }
            }

            Console.WriteLine("{0}", string.Join(" ",longest));

            
        }
    }
}

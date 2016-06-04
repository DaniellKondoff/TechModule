using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Rotate
    {
        static void Main()
        {
            int[] numebers = Console.ReadLine().Split( ).Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sumOfRotations = new int[numebers.Length];

            for (int currentRotations = 0; currentRotations < rotations; currentRotations++)
           
            {
                int lastElement = numebers[numebers.Length - 1];

                for (int currentElement = numebers.Length-1; currentElement >0; currentElement--)
                {
                    numebers[currentElement] = numebers[currentElement - 1];
                }

                numebers[0] = lastElement;

                for (int currentElement = 0; currentElement < numebers.Length; currentElement++)
                {
                    sumOfRotations[currentElement] += numebers[currentElement];
                }

                
            }
            Console.WriteLine(string.Join(" ", sumOfRotations));
        }
    }
}

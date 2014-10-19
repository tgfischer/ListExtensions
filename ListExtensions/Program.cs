using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                list.Add(i);
            }

            List<List<int>> permutations = list.GetPermutations();

            Console.WriteLine("--- GetPermutations ---");

            foreach (List<int> permutation in permutations)
            {
                for (int i = 0; i < permutation.Count; i++)
                {
                    Console.Write(permutation[i]);

                    if (i < permutation.Count - 1) Console.Write(", ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n--- Swap ---");

            list.Swap(0, 2);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);

                if (i < list.Count - 1) Console.Write(", ");
            }

            Console.ReadLine();
        }
    }
}
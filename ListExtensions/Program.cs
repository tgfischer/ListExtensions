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

            foreach (List<int> permutation in permutations)
            {
                for (int i = 0; i < permutation.Count; i++)
                {
                    Console.Write(permutation[i]);

                    if (i < permutation.Count - 1) Console.Write(", ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n" + permutations.Count);
            Console.ReadLine();
        }
    }
}
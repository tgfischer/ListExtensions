using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtensions
{
    public static class ListExtensions
    {
        public static List<List<T>> GetPermutations<T>(this List<T> list)
        {
            List<List<T>> permutations = new List<List<T>>();
            Recurse<T>(permutations, list, 0, list.Count - 1);
            return permutations;
        }

        private static void Recurse<T>(List<List<T>> permutations, List<T> list, int j, int k)
        {
            if (j == k)
            {
                permutations.Add(list.ToList());
            }
            else
            {
                for (int i = j; i <= k; i++)
                {
                    Swap(list, j, i);
                    Recurse(permutations, list, j + 1, k);
                    Swap(list, j, i);
                }
            }
        }

        public static void Swap<T>(this List<T> list, int A, int B)
        {
            T item = list[A];
            list[A] = list[B];
            list[B] = item;
        }
    }
}
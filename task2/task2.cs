using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] A = { 2, 4, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
        int[] B = { 2, 1, 4, 3, 6, 9 };
        SortArrayByOrder(A, B);
        Console.WriteLine("Отсортированный массив A:");
        foreach (int num in A)
        {
            Console.Write(num + " ");
        }
    }

    static void SortArrayByOrder(int[] A, int[] B)
    {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        for (int i = 0; i < B.Length; i++)
        {
            indexMap[B[i]] = i;
        }

        Array.Sort(A, (x, y) =>
        {
            if (indexMap.ContainsKey(x) && indexMap.ContainsKey(y))
            {
                return indexMap[x].CompareTo(indexMap[y]);
            }
            else if (indexMap.ContainsKey(x))
            {
                return -1;
            }
            else if (indexMap.ContainsKey(y))
            {
                return 1;
            }
            else
            {
                return y.CompareTo(x);
            }
        });
    }
}

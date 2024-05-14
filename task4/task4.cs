using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы списка через пробел:");
        int[] sortedList = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("Введите элемент для поиска:");
        int target = int.Parse(Console.ReadLine());
        int index = BinarySearch(sortedList, target);
        if (index != -1)
        {
            Console.WriteLine("Индекс элемента в списке: " + index);
        }
        else
        {
            Console.WriteLine("Элемент не найден в списке.");
        }
    }

    static int BinarySearch(int[] sortedList, int target)
    {
        int left = 0;
        int right = sortedList.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (sortedList[mid] == target)
            {
                return mid;
            }
            else if (sortedList[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; 
    }
}

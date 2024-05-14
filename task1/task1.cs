using System;
class Program
{ 
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 3, 7, 4, 6 };
        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);
        SortArray(numbers);
        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(numbers);
    }
    static void SortArray(int[] arr)
    {
        Array.Sort(arr);
    }
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}

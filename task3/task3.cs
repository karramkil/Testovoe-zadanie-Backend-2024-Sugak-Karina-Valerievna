using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Введите 5 чисел:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Число " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int maxSum = FindMaxSumOfTwoNumbers(numbers);
        Console.WriteLine("Наибольшая сумма двух чисел в списке: " + maxSum);
    }

    static int FindMaxSumOfTwoNumbers(int[] numbers)
    {
        if (numbers.Length < 2)
        {
            throw new ArgumentException("Список должен содержать как минимум два числа");
        }
        Array.Sort(numbers);
        return numbers[numbers.Length - 1] + numbers[numbers.Length - 2];
    }
}

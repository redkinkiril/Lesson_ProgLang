﻿// See add prog_1.2 -> program that accepts three numbers as input and outputs the maximum of these numbers.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите 3 числа:");
        int num_1 = Convert.ToInt32(Console.ReadLine());
        int num_2 = Convert.ToInt32(Console.ReadLine());
        int num_3 = Convert.ToInt32(Console.ReadLine());

        int max = num_1;

        if (num_2 > max)
        {
            max = num_2;
        }
        if (num_3 > max)
        {
            max = num_3;
        }

        Console.WriteLine("Наибольшее из введеных чисел -> " + max);
    }
}
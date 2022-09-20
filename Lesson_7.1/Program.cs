﻿// Specify a two-dimensional array of size m×n filled with random real numbers.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите количество строк");
        int linesVol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int columnsVol = Convert.ToInt32(Console.ReadLine());
        double[,] numbers = new double[linesVol, columnsVol];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);

        void FillArrayRandomNumbers(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                }
            }
        }

        void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("]");
                Console.WriteLine("");
            }
        }
    }
}
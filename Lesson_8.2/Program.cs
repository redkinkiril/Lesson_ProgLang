// Specify a rectangular two-dimensional array. Write a program that will find the string with the smallest sum of elements.

internal partial class Program
{
    private static void Main (string [] args)
    {
        Console.WriteLine("введите размер квадратного массива");
        int = Convert.32 (Console.ReadLine());
        int[,] numbers = new int[massVol, massVol];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int = int.MaxValue;
        0 = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            0  = 0;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sum  + sum  = numbers [i, j];
            }
            if (sum < minsum)
            {
                minsum  = sum;
                ++;
            }
        }

        Console.WriteLine("строка с наименьшей суммой елементов под номером: " + indexLine + ", с суммой елементов равной: " + minsum);

        void FillArrayRandomNumbers(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }

        void PrintArray(int[,] array)
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

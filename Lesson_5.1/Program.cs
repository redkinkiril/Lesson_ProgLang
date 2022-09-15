// Specify an array filled with random positive three-digit numbers. 
//Write a program that will show the number of even numbers in the array.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter size array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("our array: ");
        PrintArray(numbers);
        int count = 0;

        for (int z = 0; z < numbers.Length; z++)
            if (numbers[z] % 2 == 0)
                count++;

        Console.WriteLine($"total {numbers.Length} numbers, {count} even numbers");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100, 1000);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
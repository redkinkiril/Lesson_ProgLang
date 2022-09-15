// Specify a one-dimensional array filled with random numbers.
// Find the sum of the elements standing in odd positions.

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter size array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("our array: ");
        PrintArray(numbers);
        int sum = 0;

        for (int z = 0; z < numbers.Length; z += 2)
            sum = sum + numbers[z];

        Console.WriteLine($"total {numbers.Length} numbers, sum of elements in odd positions = {sum}");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1, 10);
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
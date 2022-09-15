// Specify an array of real numbers. 
//Find the difference between the maximum and minimum array elements.

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter size array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("our array: ");
        PrintArray(numbers);
        double min = int.MaxValue;
        double max = int.MinValue;
        for (int z = 0; z < numbers.Length; z++)
        {
            if (numbers[z] > max)
            {
                max = numbers[z];
            }
            if (numbers[z] < min)
            {
                min = numbers[z];
            }
        }
        Console.WriteLine($"total {numbers.Length} numbers. Maximum value = {max}, minimum value = {min}");
        Console.WriteLine($"difference between the maximum and minimum value = {max - min}");
        void FillArrayRandomNumbers(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
            }
        }
        void PrintArray(double[] numbers)
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
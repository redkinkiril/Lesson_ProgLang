// Set the values of M and N. Write a program that outputs all natural numbers in the range from M to N.

internal partial class Program
{
    private static void Main(string[] args)
    {
        int n = InputInt("Введите положительное число ");
        int m = 1;
        if (n < 1)
        {
            Console.WriteLine("Ввели не положительное число ");
        }
        Console.WriteLine(NaturalNumber(n, m));

        int NaturalNumber(int n, int m)
        {
            if (n == m)
                return n;
            else
                Console.Write($"{NaturalNumber(n, m + 1)}, ");
            return m;
        }

        int InputInt(string output)
        {
            Console.Write(output);
            return int.Parse(Console.ReadLine());
        }
    }
}
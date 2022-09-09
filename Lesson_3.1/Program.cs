// See added Write a loop that takes two numbers (A and B) as input and raises the number A to the natural power of B.

internal class Program
{
    private static void Main(string[] args)
    {
        int Exponentiation(int numberA, int numberB)
        {
            int result = 1;
            for (int i = 1; i <= numberB; i++)
            {
                result = result * numberA;
            }
            // int result = Math.Pow(numberA, numberB);
            return result;
        }

        Console.Write("Enter number A: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number B: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        int exponentiation = Exponentiation(numberA, numberB);
        Console.WriteLine("Answer: " + exponentiation);
    }
}
// See added program that accepts a number (integer or real) as input and outputs the number of digits in the number.


internal class Program
{
    private static void Main(string[] args)
    {
        long i = 0;
        decimal n;
        Console.Write("Enter number: ");
        n = Convert.ToInt64(Console.ReadLine());
        
        do
        {
            n = n / 10;
            i++;
        }
        while(Math.Abs(n) >= 1);
        Console.WriteLine("number of elements: " + (i));
    }
}
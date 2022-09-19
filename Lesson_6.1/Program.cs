// The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Write($"Enter number М (quantity numbers): ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] massiveNumbers = new int[m];

        void InputNumbers(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Enter {i + 1} number: ");
                massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int Comparison(int[] massiveNumbers)
        {
            int count = 0;
            for (int i = 0; i < massiveNumbers.Length; i++)
            {
                if (massiveNumbers[i] > 0) count += 1;
            }
            return count;
        }

        InputNumbers(m);

        Console.WriteLine($"Entered more numbers 0: {Comparison(massiveNumbers)} ");
    }
}
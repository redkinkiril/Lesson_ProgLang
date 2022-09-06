// See added program that accepts a five-digit number as input and checks whether it is a palindrome.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entered number: ");
        string? number = Console.ReadLine();

        void CheckingNumber(string number)
        {
            if (number[0] == number[4] || number[1] == number[3])
            {
                Console.WriteLine("you number:" + number + "- palindrome.");
            }
            else Console.WriteLine("you number:" + number + "- no palindrome.");
        }

        if (number!.Length == 5)
        {
            CheckingNumber(number);
        }
        else Console.WriteLine("Entered correct number");
    }
}
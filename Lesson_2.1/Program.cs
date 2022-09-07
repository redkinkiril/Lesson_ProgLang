// See added program that accepts a three-digit number as input and shows the second digit of this number as output.  

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string numberS = Math.Abs(number).ToString();
        Console.WriteLine(numberS.Length == 3 ? $"{number} -> {numberS[1]}" : "you entered a non-three-digit number");
    }
}

/* if(numberS.Length != 3) 
    {
        Console.WriteLine("you entered a non-three-digit number :(");
    } 
    else 
    {
        Console.WriteLine($"{number} -> {numberS[1]}");
    }
*/

// See added Write a program that sets an array of N elements and displays them on the screen. 
// N - entered from the keyboard.
// Elements are also entered from the keyboard.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter a number : ");
        string? seriesOfNumbers = Console.ReadLine();

        seriesOfNumbers = seriesOfNumbers + ","; // an additional comma to indicate the end of the line

        // function for removing spaces from a string 
        string RemovingSpaces(string series)
        {
            string seriesNew = "";
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] != ' ')
                {
                    seriesNew += series[i];
                }
            }
            return seriesNew;
        }

        // function of checking for the correctness of the input
        void СheckNumber2(int series)
        {

            if (series == '0' || series == '1' || series == '2'
            || series == '3' || series == '4' || series == '5' || series == '6'
            || series == '7' || series == '8' || series == '9' || series == ','
            || series == '-');
        
            else
            {
                Console.WriteLine($"Character input error. Enter the numbers.");

            }
        }

        // function of creating and filling an array from a string
        int[] ArrayOfNumbers(string seriesNew)
        {
            int[] arrayOfNumbers = new int[1];    // initializing an array of 1 element
            int j = 0;
            for (int i = 0; i < seriesNew.Length; i++)
            {
                string seriesNew1 = "";
                while (seriesNew[i] != ',' && i < seriesNew.Length)
                {
                    seriesNew1 += seriesNew[i];
                    СheckNumber2(seriesNew[i]);
                    i++;
                }
                arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // fills the array with values from the string
                if (i < seriesNew.Length - 1)
                {
                    arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // adds a new null element to the end of the array
                }
                j++;
            }
            return arrayOfNumbers;
        }
        // array output function for printing 
        void PrintArry(int[] coll)
        {
            int count = coll.Length;
            int index = 0;
            Console.Write("[");
            while (index < count)
            {
                Console.Write(coll[index]);
                index++;
                if (index < count)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }
        
        string seriesNew = RemovingSpaces(seriesOfNumbers);

        int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

        PrintArry(arrayOfNumbers);
    }
}
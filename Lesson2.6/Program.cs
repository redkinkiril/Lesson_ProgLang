// See added program that accepts a number (N) as input and outputs a table of cubes of numbers from 1 to N.;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int cube = Convert.ToInt32(Console.ReadLine());
        void Cube(int[] cube)
        {
            int counter = 0;
            int length = cube.Length;
            while (counter < length)
            {
                cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
                counter++;
            }
        }
        void PrintArry(int[] coll)
        {
            int count = coll.Length;
            int index = 0;
            while (index < count)
            {
                Console.Write(coll[index] + " ");
                index++;
            }
        }
        int[] arry = new int[cube + 1];
        Cube(arry);
        PrintArry(arry);
    }
}
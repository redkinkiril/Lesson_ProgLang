// Задача 43. Write a program that finds intersection point of two straight lines given by equations y = k1 * x + b1, y = k2 * x + b2;
// values b1, k1, b2 и k2 set by user.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

internal partial class Program
{
    private static void Main(string[] args)
    {

        double[,] coff = new double[2, 2];
        double[] crossPoint = new double[2];

        void InputCofficients()
        {
            for (int i = 0; i < coff.GetLength(0); i++)
            {
                Console.Write($"Enter the cofficients {i + 1} equations (y = k * x + b):\n");
                for (int j = 0; j < coff.GetLength(1); j++)
                {
                    if (j == 0) Console.Write($"Enter the coffcient k: ");
                    else Console.Write($"Enter the coffcient b: ");
                    coff[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        double[] Decision(double[,] coff)
        {
            crossPoint[0] = (coff[1, 1] - coff[0, 1]) / (coff[0, 0] - coff[1, 0]);
            crossPoint[1] = crossPoint[0] * coff[0, 0] + coff[0, 1];
            return crossPoint;
        }

        void OutputResponse(double[,] coff)
        {
            if (coff[0, 0] == coff[1, 0] && coff[0, 1] == coff[1, 1])
            {
                Console.Write($"\nStraight lines match");
            }
            else if (coff[0, 0] == coff[1, 0] && coff[0, 1] != coff[1, 1])
            {
                Console.Write($"\nStraight lines are parallel");
            }
            else
            {
                Decision(coff);
                Console.Write($"\nPoint of intersection of straight lines: ({crossPoint[0]}, {crossPoint[1]})");
            }
        }

        InputCofficients();
        OutputResponse(coff);
    }
}
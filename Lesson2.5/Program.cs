// See added program that takes the coordinates of two points as input and finds the distance between them in 3D space.;

internal class Program
{
    private static void Main(string[] args)
    {
        int x1 = Coordinate("x", "A");
        int y1 = Coordinate("y", "A");
        int z1 = Coordinate("z", "A");
        int x2 = Coordinate("x", "B");
        int y2 = Coordinate("y", "B");
        int z2 = Coordinate("z", "B");

        int Coordinate(string coorName, string pointName)
        {
            Console.Write($"enter the coordinate: {coorName} point {pointName}: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        double Decision(double x1, double x2,
                        double y1, double y2,
                        double z1, double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                             Math.Pow(y2 - y1, 2) +
                             Math.Pow(z2 - z1, 2));
        }

        double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

        Console.WriteLine("length of the segment:  " + segmentLength);
    }
}
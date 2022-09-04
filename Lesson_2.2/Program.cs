// See added a program that outputs the third digit of a given number or reports that there is no third digit.;

Console.WriteLine("enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" : $"{numberS} -> there is no third digit");

/*
if(numberS.Length > 2) {
 Console.WriteLine($"{number} -> {numberS[2]}");
} else {
 Console.WriteLine($"{number} -> there is no third digit");
}
*/

// See add prog_1.1 -> program that accepts two numbers as input and outputs which number is greater and which is smaller.

Console.WriteLine("Enter first number:");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number:");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine(" First number " + num_A + " more than the second " + num_B);
}
else
{
    Console.WriteLine(" Second number " + num_B + " more than the first " + num_A);
}

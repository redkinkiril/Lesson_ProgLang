// See added program that takes a number as input and outputs whether the number is even (whether it is divisible by two without remainder).

Console.WriteLine("Введите число:");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + "является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
}

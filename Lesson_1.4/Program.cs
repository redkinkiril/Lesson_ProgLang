﻿// See added program that takes a number (N) as input, and shows all even numbers from 1 to N as output.

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
}
i++;
}

if (not)
{
 Console.WriteLine("Нет чётных чисел!");
}


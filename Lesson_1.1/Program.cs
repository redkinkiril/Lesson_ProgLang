﻿// See add prog_1.1 -> program that accepts two numbers as input and outputs which number is greater and which is smaller.

Console.WriteLine("Введите первое число:");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine(" Первое число " + num_A + " больше чем второе " + num_B);
}
else
{
    Console.WriteLine(" Второе число " + num_B + " больше чем первое " + num_A);
}

﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Value = Prompt("Введите число > ");
for (int index = 1 ; index < Value+1; index++)
if (index%2 == 0)
{
    System.Console.Write($" {index} ");
}
﻿//Задача 6: Напишите программу, которая на вход принимает
//число и выдает, является ли число четным (делится ли оно на
//два без остатка).
//Задача 8: Напишите программу, которая на вход принимает
//число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Enter N: ");
string StrN = Console.ReadLine();
int N = Convert.ToInt32(StrN);
if (N=1)
  Console.WriteLine("Нет таких чисел");
﻿/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с 
помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int SumOfElements(int n, int m)
{
  if (n == m) return n;
  else return SumOfElements(n + 1, m) + n;
}

int n = Prompt("Input M: ");
int m = Prompt("Input N: ");

Console.WriteLine(SumOfElements(n, m));

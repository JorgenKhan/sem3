﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void PrintDigits(int n)
{
    Console.Write(n + " ");
    if (n > 1) PrintDigits(n - 1);
}

 int n = 8;
 Console.Write($"N = {n} -> ");
 PrintDigits(n);
 */
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
int SumOfElements(int firstNum, int lastNum)
{
    int sum = firstNum;
    if (sum > lastNum) return 0;
    return sum += SumOfElements(sum + 1, lastNum);
}

Console.Write("Input meaning of m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input meaning of n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumOfElements(m,n);
Console.WriteLine("Sum of elements from m to n is: " + result);
*/
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m,n - 1));
    return A(m,n);
}                  

Console.Write("Input number m greater than 0: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number n greater than 0: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {A(m,n)}");      
*/
﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int resultSum = Sum(number);
Console.Write(resultSum);

int Sum(int num, int result = 0, int i = 0)
{
    while (num > 0)
    {
        i = num % 10;
        result = i + result;
        num = num / 10;
    }
    return result;
}
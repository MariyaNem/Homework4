//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB >= 0)
{
    double result = Power(numberA, numberB);
    Console.Write($"{numberA} в степени {numberB} = {result}");
}
else Console.Write("Введена отрицательная степень");

double Power(int numA, int numB)
{
    double res = Math.Pow(numA, numB);
    return res;
}
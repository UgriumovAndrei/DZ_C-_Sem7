﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4   Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте двумерный массив из целых чисел.");
Console.WriteLine("Сколько строк будет в Вашем массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = new int [m,n];
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random(). Next(1, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
string result = "Среднее арифметическое каждого столбца: ";
for(int j = 0; j<array.GetLength(1); j++)
{
    double summ = 0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        summ += array[i,j];
    }
    if(j<array.GetLength(1)-1) result += Convert.ToString($"{Math.Round(summ/Convert.ToDouble(m), 2)}; ");
    else result += Convert.ToString($"{Math.Round(summ/Convert.ToDouble(m), 2)}.");
}
Console.Write(result);
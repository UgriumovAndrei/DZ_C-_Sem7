﻿//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Сколько строк будет в Вашем массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double [,] array = new double [m,n];
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Double();
        int s = new Random(). Next(1,10000);
        Console.Write($"{array[i,j]},{s} ");
    }
    Console.WriteLine();
}

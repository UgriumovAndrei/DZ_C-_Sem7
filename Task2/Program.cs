// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4          17 -> такого числа в массиве нет

Console.WriteLine("Для начала давайте создадим массив");
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
        Console.Write($"{array[i,j]} "); // эта строка в этой задаче необязательна, она для проверки работы программы
    }
    Console.WriteLine();
}
Console.WriteLine("Теперь вы можете узнать какой элемент стоит в массиве на любой позиции");
Console.WriteLine("Введите строку искомого элемента");
int i2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец искомого элемента");
int j2 = Convert.ToInt32(Console.ReadLine());
if((i2<0||i2>m) || (j2<0 || j2>n)) Console.WriteLine("Такой позиции нет в массиве");
else Console.WriteLine(array[i2,j2]);
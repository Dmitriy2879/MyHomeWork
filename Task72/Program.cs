﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateArray(int Row, int Columns)
{
    int[,] array = new int[Row, Columns]; // объявить массив
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array; //возвращаем массив
}

void PrintArray(int[,] array) //вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t"); // массив в строчку
        }
        Console.WriteLine();
    }
}
int[,] array = CreateArray(3,4);
PrintArray(array);

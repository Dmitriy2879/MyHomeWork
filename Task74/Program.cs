// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateArray(int Row, int Columns)
{
    int[,] array = new int[Row,Columns]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 9);
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

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum+=array[i,i];
    }
    return sum;
}

int[,] array = CreateArray(4,4);
PrintArray(array);
Console.WriteLine(SumDiagonal(array));




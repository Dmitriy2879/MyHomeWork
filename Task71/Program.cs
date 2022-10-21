// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1   4   8  19
// 5  -2  33 -2
// 77  3  8   1

int[,] CreateArray(int Row, int Columns)
{
    int[,] array = new int[Row,Columns]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-5, 6);
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

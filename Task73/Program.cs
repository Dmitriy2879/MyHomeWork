// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] CreateArray(int Row, int Columns)
{
    int[,] array = new int[Row, Columns]; // объявить массив
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

int[,] ChetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // условие
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 !=0 && j % 2 !=0)
            {
                array[i,j] *= array[i,j];
            }

        }
    }
    return array;
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
Console.WriteLine();
PrintArray(ChetArray(array));




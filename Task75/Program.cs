// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции 
// по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

// найти минимум в матрице

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

int Min(int[,] array)
{
    int min = array[0,0];
    foreach (int item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}

int[,] array = CreateArray(3,4);
PrintArray(array);
int min = Min(array);
System.Console.WriteLine($"минимум равен: {min}");


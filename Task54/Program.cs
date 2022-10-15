// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int len, int minLimit, int maxLimit)  // создаем массив
{
    int[] array = new int[len];  // объявить массив
    Random rnd = new Random();  //генератор случайных чисел
    for (int i = 0; i < array.Length; i++) // условие
    {
        array[i] = rnd.Next(minLimit, maxLimit+1); //от мин до максим включительно
    }
    return array; //возвращаем массив
}

void PrintArray(int[] array) //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t"); // массив в строчку
    }
    Console.WriteLine();
}

int Number(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(Array[i] >= 10 && Array[i] <= 99)
        {
            count++;
        }
    } 
    return count;
}

int[] myArray = CreateArray(10,0,200);
PrintArray(myArray);
Console.WriteLine($"Количество элементов в отрезке от 10 до 99: {Number(myArray)}");

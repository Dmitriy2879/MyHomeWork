// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

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

int Sum(int[] array, int fl = 1)  // вычисляем сумму новы метод, тело метода
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] * fl > 0) // проверяем условие
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arr = CreateArray(8,-9,9); //вывод массива на экран
PrintArray(arr);
int SumPositive = Sum(arr);
int SumNegative = Sum(arr, -1);
Console.WriteLine($"Положительная сумма {SumPositive}, отрицательная сумма {SumNegative}"); // вывод результата

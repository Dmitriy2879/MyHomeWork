// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

int Prompt(string message) // задаем число которое ищем
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()); //выводим на консоль
}

bool SpecNumber(int[] array, int value)// метод, тело массива, используем bool так как ищем есть число или нет 2 варанта
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return true; //верно
        }
    }
    return false; // не верно
}

int[] array = CreateArray(5, -9, 9);
PrintArray(array);
int value = Prompt("Введите число:  ");
Console.WriteLine(SpecNumber(array, value));

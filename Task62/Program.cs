// Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int[] RandomArrGen() // создаем массив
{
    int length = 3;
    int[] arr = new int[length]; // объявить массив
    for (int i = 0; i < length; i++) // условие
    {
        arr[i] = new Random().Next(1, 100);
        Console.Write($"{arr[i]}\t");
    }
    return arr; //возвращаем массив
}

bool Check(int[] arr)
{
    if (arr[0] + arr[1] < arr[2])
        return false;
    if (arr[0] + arr[2] < arr[1])
        return false;
    if (arr[2] + arr[1] < arr[0])
        return false;
    return true;
}
int[] triangle = RandomArrGen();
Console.WriteLine(Check(triangle));

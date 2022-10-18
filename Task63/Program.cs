// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string message) // задаем число которое ищем
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()); //выводим на консоль
}

int[] Binary(int number) // создаем массив
{
    int[] array = new int[10];
    int count = array.Length - 1;
    while (number > 0)
    {
        array[count] = number % 2;
        number /= 2;
        count--;
    }
    return array;
}

void PrintArray(int[] array) //вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t"); // массив в строчку
    }
    Console.WriteLine();
}

int value = Prompt("Введите число:  ");
PrintArray(Binary(value));


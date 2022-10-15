// Напишите программу замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


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

int[] Change(int[] arr) // метод (формула) новые данные и названия
{
    for (int i = 0; i < arr.Length; i++)
    {
        {
            arr[i] *= -1; // меняем положительные на отрицательные и наоборот
        }
    }
    return arr;
}

int[] myArray = CreateArray(5,-9,9); //вывод массива на экран
PrintArray(myArray);
PrintArray(Change(myArray));

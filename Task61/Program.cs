// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArray(int len) // создаем массив
{
    int[] array = new int[len]; // объявить массив
    Random rnd = new Random(); //генератор случайных чисел
    for (int i = 0; i < array.Length; i++) // условие
    {
        array[i] = rnd.Next(0, 10); //от мин до максим включительно
    }
    return array; //возвращаем массив
}

void PrintArray(int[] arr) //вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t"); // массив в строчку
    }
    Console.WriteLine();
}

int[] Revers(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = temp;
    }
    return arr;

}
int[] arr = CreateArray(5);
PrintArray(arr);
PrintArray(Revers(arr));

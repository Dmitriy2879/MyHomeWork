// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Show(Fill(8));
int[] Fill(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int b = new Random().Next(0, 2);
        array[i] = b;
    }
    return array;
}
void Show(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

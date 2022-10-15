// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] myArray = CreateArray(9,0,5);
PrintArray(myArray);

int[] secondArray;

if(myArray.Length % 2 == 0)
{
    secondArray = new int[myArray.Length/2];
}
else
{
    secondArray = new int[myArray.Length / 2 + 1];
}

for (int i = 0; i < myArray.Length / 2; i++)
{
    secondArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
}

if(myArray.Length % 2 !=0)// если массив нечетный то
{
    secondArray[secondArray.Length - 1] = myArray[secondArray.Length - 1]; //присвоить значание старого массва новому
}

PrintArray(secondArray);

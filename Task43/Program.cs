// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int N = Convert.ToInt32(Console.ReadLine());
int multiply = 1;
for (int i = 1; i <= N; i ++)
{
    multiply = multiply * i;
}
Console.WriteLine($"Выводим факториал  {multiply}");

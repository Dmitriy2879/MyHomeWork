// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.WriteLine("Введите первое число:  ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число:  ");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a==b*b)
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else if (b==a*a)
{
    Console.WriteLine($"Число {b} является квадратом {a}");
}
else
{
    Console.WriteLine($"Числа не являются квадратами друг друга");
}


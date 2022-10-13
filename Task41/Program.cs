// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputNumber(string message) //ввод числа по приглашению
{
    Console.Write(message); //вывод приглашения
    string str = Console.ReadLine(); //читаем строку с консоли
    return Convert.ToInt32(str); //преобразуем строку в число или return int.Parse(str)
}

int SumNumbers(int number) // сумма чисел от 1 до number
{
    int sum = 0; // накапливаем сумму
    for (int i = 1; i <= number; i++) //цикл от 1 до number
    {
        sum = sum + i; //суммируем
    }
    return sum; // возврат суммы из метода
}

bool ValidateNumber(int number) //проверка на правильность ввода
{
    if (number < 1) //при числе меньше меньше чем 1 не работаем
    {
        Console.WriteLine("Число меньше единицы, сумма не считается");
        return false;
    }
    return true;
}

int n = InputNumber("Введите число >");
if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");
}

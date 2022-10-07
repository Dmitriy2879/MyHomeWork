// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int Prompt(string message);
{
    Console.Write(message);
    int number = Convert.ToInt32(inputString);
    return value;
}
bool ValidateCoords(int xCoord, int yCoord);

int x=Prompt("Введите x>");
int y=Prompt("Введите y>");

if (x>0&&y>0)
{
    Console.WriteLine("1 четверть");
}
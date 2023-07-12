// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Promt(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void GetResult(int X, int Y)
{
    if(X > 0 && Y > 0)
    {
        System.Console.WriteLine("I четверть");
    }
    if(X < 0 && Y > 0)
    {
        System.Console.WriteLine("II четверть");
    }
    if(X < 0 && Y < 0)
    {
        System.Console.WriteLine("III четверть");
    }
    if(X > 0 && Y < 0)
    {
        System.Console.WriteLine("IV четверть");
    }
}

int x = Promt("Введите точку X: ");
int y = Promt("Введите точку Y: ");
GetResult(x, y);

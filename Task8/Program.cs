// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int Coordinate(string message)
{
    System.Console.WriteLine(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double Distance(int a, int b, int c, int d)
{
    double distance = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
    return distance;
}

int x1 = Coordinate("Введите x в коордтнату  точки 1: ");
int y1 = Coordinate("Введите y в коордтнату  точки 1: ");
int x2 = Coordinate("Введите x в коордтнату  точки 2: ");
int y2 = Coordinate("Введите y в коордтнату  точки 2: ");

System.Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, x2, y2));
﻿// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

//Console.Clear();
int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");

int[,] matrix1 = GetArray(rows, columns);
int[,] matrix2 = GetArray(rows, columns);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

int[,] res = Multiply(matrix1, matrix2);

PrintArray(res);

int GetNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int row, int column)
{
int[,] res = new int[row, column];
for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
{
res[i, j] = new Random().Next(1, 10);
}
}
return res;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}
}

int[,] Multiply(int[,] array1, int[,] array2)
{
int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
for (int i = 0; i < array1.GetLength(0); i++)
{
for (int j = 0; j < array1.GetLength(1); j++)
{
result[i, j] = array1[i, j] * array2[i, j];
}
}
return result;
}
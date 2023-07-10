// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int GetRandomNumber() - Первое решение задача, но есть маленькая проблема.
// {
//     int number = new Random().Next(100, 1000);
//     return number;
// }

// int GetFirstDigit(int number1)
// {
//     return number1 / 100;
// }

// int GetLastDigit(int number1)
// {
//     return number1 % 10;
// }

//  void PrintNumber(int num1)
// {
//      System.Console.Write(num1 + " ");
// }

// void ShowFirstLastDigit(int digit1, int digit3)
// {
//      Console.WriteLine(digit1,digit3);
// }

// int num = GetRandomNumber(); - Второе решение задачи
// PrintNumber(num);
// int firstDigit = GetFirstDigit(num);
// PrintNumber(firstDigit);
// int lastDigit = GetLastDigit(num);
// PrintNumber(lastDigit);
// //ShowFirstLastDigit(firstDigit,lastDigit);

// int NewRandom(){
// int number = new Random().Next(100, 1000);
// return number;
// }
// int RemoveSecondDigit(int random)
// {
// int firstDigit = random / 100;
// int thirdDigit = random % 10;

// int mNumber = firstDigit * 10 + thirdDigit;
// return mNumber;
// }
// int random = NewRandom();
// Console.WriteLine($"число: {random}");
// int mNumber = RemoveSecondDigit(random);
// Console.WriteLine($"Новое число: {mNumber}");

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.WriteLine("Введите первое число");
// int a = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите Второе число");
// int b = int.Parse(Console.ReadLine());

// if(a % b == 0)
// {
//     System.Console.WriteLine("Первое число кратно второму");

// }
// else 
// {
//     System.Console.WriteLine("Второе число не кратно первому, остаток " + (a % b));
// }


// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// System.Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// void Multiply(int number1)
// {
//     if (number1 % 7 == 0 && number1 % 23 ==0)
//     {
//         System.Console.WriteLine("Данное число кратно и 7, и 23 одновременно");
//     }
//     else
//     {
//         System.Console.WriteLine("Данное число не кратно и 7, и 23 одновременно");
//     }
// }
// Multiply(number);


// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

void Kratnost(int number1, int number2)
{
if (number1*number1 % number2 == 0 || number2*number2 % number1 == 0)
{
Console.Write("-> да");
}
else
{
Console.Write("-> нет");
}
}

Kratnost(num1,num2);
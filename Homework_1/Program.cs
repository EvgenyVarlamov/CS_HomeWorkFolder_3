/* Задача 19:Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

// Первый вариант
/*
Console.WriteLine($"Введите 5-значное число");
string? number = String.Empty;
number = Console.ReadLine();
if(number[0] == number[4] && number[1] == number[3]) Console.WriteLine($"Введенное чиило {number} является палиндромом");
else Console.WriteLine($"Введенное чиило {number} не является палиндромом");
*/
// Второй вариант

Console.WriteLine($"Введите 5-значное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 10 == number % 100000 / 10000 && number % 100 / 10 == number % 10000 / 1000)
{
    Console.WriteLine($"Введенное чиило {number} является палиндромом");
}
else Console.WriteLine($"Введенное чиило {number} не является палиндромом");
﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    while (num > 999)
    {
        num = num/10;
    }
    Console.WriteLine(num%10);
}
else 
    Console.WriteLine("нет");
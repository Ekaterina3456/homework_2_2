// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 & num <= 5)
        Console.WriteLine("будний день");
else if (num == 6 | num == 7)
    Console.WriteLine("выходной день");
else
    Console.WriteLine("введите число от 1 до 7");
﻿Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"число: {number} - палиндром.");
    }
    else Console.WriteLine($"число: {number} - не палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");

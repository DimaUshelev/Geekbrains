Console.Write ("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > 999)
{
    Console.Write ("это не трёхзначное число, повторите ввод: ");
    return;
}
Console.Write ($"Введённое число: {number} ");
int secondDigit= number / 10 % 10;
Console.Write ($"Вторая цифра: {secondDigit} ");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
    number = number / 10; 
}

if (number < 99)
{
    Console.Write ("третьей цифры нет");
}
int ThirdDigit = number % 10;

   Console.Write ($"третья  цифра: {ThirdDigit} ");

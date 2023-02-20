
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
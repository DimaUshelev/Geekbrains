Console.Write ("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c )
{
    Console.WriteLine (a); 
}
if (b>a && b>c)
{
    Console.WriteLine (b);
}
if (c>a && c>b)
{
    Console.WriteLine (c);
}
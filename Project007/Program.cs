
Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 0)
{
    Console.Write ("дней в неделе всего 7 введите цифру от 1 до 7: ");
   return;
}
if (number <= 5)
{
    Console.Write ("Рабочий день");

}
if (number > 5)
{
    
    
    Console.Write ("Выходной день");
}

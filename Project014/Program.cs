int size = 0;
int[] numbers;

int GetNumber(string text)
{
    int num = 0;
    System.Console.WriteLine(text);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string Print(int[] array)
{
  string result = String.Empty;
  int l = array.Length;
  int index = 0;
  while (index < l)
  {
    result = result + array[index] + "   ";
    index++;
  }
  return result;
}

int [] FillByRandom(int size)
{

int [] array = new int [size];
int min=100;
int max=999;
int first = 0;

for (int index=0; index < array.Length; index++)
{

first = new Random().Next(min,max);

array[index] = first;

}

return array;
} 

int ChetNumbers(int [] array)
{
  string result = String.Empty;
int cifra = 0;

for (int index=0; index < array.Length; index++)
{
    if ((array[index] % 2) == 0)
    {
        cifra = cifra + 1;
        result = result + array[index] + "   ";
    }

}
Console.WriteLine($"Четные элементы массива:   {result}");  
return cifra;
} 

size = GetNumber("Введите размер массива ");

numbers = FillByRandom(size); 

Console.WriteLine("Массив");  

Console.WriteLine(Print(numbers));

Console.WriteLine($"Количество четных элементов массива = {ChetNumbers(numbers)}");
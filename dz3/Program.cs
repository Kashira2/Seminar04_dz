int Sum(int number)
{
int result = 0;
while (number >= 1)
{
    int LastNum = number % 10;
    result = result + LastNum;
    number = number / 10;
}
return result;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(num));
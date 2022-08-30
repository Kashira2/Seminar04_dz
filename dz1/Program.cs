Console.WriteLine("Введите два числа: ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
double Degree(int FirstNum, int SecondNum)
{
double result = Math.Pow(FirstNum, SecondNum);
return result;
}
Console.WriteLine(Degree(x1, x2));
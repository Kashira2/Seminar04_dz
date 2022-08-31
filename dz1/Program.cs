//                Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


/*
Console.WriteLine("Введите два числа: ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
double Degree(int FirstNum, int SecondNum)
{
double result = Math.Pow(FirstNum, SecondNum);
return result;
}
Console.WriteLine(Degree(x1, x2));
*/

Console.WriteLine("Введите два числа: ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int Degree(int FirstNum, int SecondNum)
{
int result = FirstNum;
for (int i = 1; i < SecondNum; i++)
{
    result = result * FirstNum;
}
return result;
}
Console.WriteLine(Degree(x1, x2));
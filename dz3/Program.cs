//               Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] NewArray(int num)
    {
        int[] newArray = new int[num];
        for (int i = 0; i < num; i++)
        {
            newArray[i] = new Random().Next(0, 10);
        }
        return newArray;
    }

foreach (int item in NewArray(8))
{
    Console.Write($"{item}, ");
}


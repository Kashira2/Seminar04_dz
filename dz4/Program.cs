//                            необязательная задача
//                    Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение.
//                    Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.


Console.WriteLine("Укажите размерность массива: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
int length = array.Length; 
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 100);
}

for (int i = 0; i < length; i++)
{
    int max = array[i];
    for (int j = i + 1 ; j < length; j++)
    {
        if ( max < array[j])
        {
        max = array[j];
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        }
    }
   
    if (i != length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
   
} 

if (length % 2 == 0)
{
    int median = array[length / 2 - 1] + array[length / 2];
    int secondMedian = median / 2; 
    Console.WriteLine();
    Console.WriteLine($"медианное значение в данном массиве: {secondMedian}");
}
else
{
   int median = array[length / 2];
    Console.WriteLine();
    Console.WriteLine($"медианное значение в данном массиве: {median}");
}  
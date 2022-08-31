//                            необязательная задача
//                    Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение.
//                    Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.

 
void ArrayCreat(int[] massive, int length)                //Создание рандомных значений

{                                                                    
    for (int i = 0; i < length; i++)
    {
        massive[i] = new Random().Next(0, 100);
    }
}

void ArraySort(int[] massive, int length)                 //Сортировка
{
    for (int i = 0; i < length; i++)                                       
    {
        int max = massive[i];
        for (int j = i + 1 ; j < length; j++)
        {
            if ( max < massive[j])
            {
            max = massive[j];
            int temp = massive[i];
            massive[i] = massive[j];
            massive[j] = temp;
            }
        }
        if (i != length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    } 
}
 
int SearchMedian(int[] massive, int length)               //Вычесление медианного значения
{
    int median = 0;
    if (length % 2 == 0)                                                          
    {
        median = massive[length / 2 - 1] + massive[length / 2];
        median = median / 2; 
        
    }
    else
    {
    median = massive[length / 2];
    }  
    return median;
}


Console.WriteLine("Укажите размерность массива: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
int length = array.Length; 

ArrayCreat(array, length);

ArraySort(array, length);

Console.WriteLine();
Console.WriteLine($"медианное значение в данном массиве: {SearchMedian(array, length)}"); 


       
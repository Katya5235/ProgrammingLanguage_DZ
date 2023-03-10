// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Fillarray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int SumEvetDig(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum = sum + 1;
        }

       
    }
 
     return sum;
}

int[] Myarray = Fillarray();
int sumvdig = SumEvetDig(Myarray);
Console.WriteLine($" Наш массив  = [{string.Join("," ,Myarray)}]");
Console.WriteLine($" Количество четных числел = {sumvdig}");













// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }

// }

// FillArray(array);
// PrintArray(array);
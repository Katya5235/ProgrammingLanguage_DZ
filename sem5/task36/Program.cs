// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 61);
    }
    return array;
}

int SumOfOddNum(int[] unamatriz)
{
    int sum = 0;
    for (int i = 0; i < unamatriz.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + unamatriz[i];
        }
    }
return sum;
}

int[] firstmet = FillArray (10);
int SOdd = SumOfOddNum (firstmet);
Console.WriteLine($"Рандомно заполненный массив = [{string.Join(",",firstmet)}]");
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {SOdd}");





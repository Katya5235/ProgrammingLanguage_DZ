// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



int SearchMaxNumber(int[] a)
{

    int max = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }

    }
    return max;
}
int SearchMinNumber(int[] b)
{
    int min = b[0];
    for (int i = 1; i < b.Length; i++)
    {
        if (b[i] < min)
        {
            min = b[i];
        }
    }
    return min;
}
int[] array = new int[] { 100, 1000, 134, 696, 979, 811, 13 };
int Maxnum = SearchMaxNumber(array);
Console.WriteLine($" Максимальное число = {Maxnum}");
int MinNum = SearchMinNumber(array);
Console.WriteLine($" Минимальное число = {MinNum}");
Console.WriteLine($" Разница между максимальным и минимальным значением  = {Maxnum  - MinNum}");




// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[] { 55, 68, 34, 6, 97, 81, 13 };

int SearchMaxNumber(int[] a)
{

    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

    }
    return max;
}
int SearchMinNumber(int[] b)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int Maxnum = SearchMaxNumber(array);
Console.WriteLine($" Максимальное число = {Maxnum}");
int MinNum = SearchMinNumber(array);
Console.WriteLine($" Минимальное число = {MinNum}");
Console.WriteLine($" Разница между максимальным и минимальным значением  = {Maxnum  - MinNum}");




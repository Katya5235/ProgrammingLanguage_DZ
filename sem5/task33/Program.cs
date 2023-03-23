// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
int[] GetRandomArray ()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int[] myArray = GetRandomArray();

int EvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}
Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine($"Массив имеет {EvenNumbers(myArray)} четных числа/число");
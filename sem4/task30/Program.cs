// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;

    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

  void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

FillArray(array);
PrintArray(array);

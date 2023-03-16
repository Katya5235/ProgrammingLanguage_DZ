// Задача 45: Напишите программу,
//которая будет создавать копию массива с помощью поэлементного копирования.

int[] GetArray()
{
    int[] array = new int[9];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 51);
    }
    return array;

}
int[] myarray = GetArray();
int[] copyarray = new int[9];
for (int i = 0; i < myarray.Length; i++)
{
copyarray[i] = myarray[i];
}

myarray[2] = 2000;

Console.WriteLine($" Array - {string.Join(", ", myarray)}");
Console.WriteLine($" Array copy - {string.Join(", ", copyarray)}");







int[] FillArray()
{
    Console.WriteLine("Введите кол-во элементов массива  ");
    int elements = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i} -  ");
        array[i] = int.Parse(Console.ReadLine());

    }
    Console.Write($"Вывод массива - {string.Join(", ", (array))}");
    return array;
}


void Reverse(int[]a)
{
    for (int i = 0; i < a.Length / 2; i++)
    {
        int temp = a[i];
        a[i] = a[a.Length - i - 1];
        a[a.Length - i - 1] = temp;
    }
Console.Write($"Массив перевёрнутый {string.Join(", ",(a))}");
}

int [] ser = FillArray();
Console.WriteLine();
Reverse(ser);





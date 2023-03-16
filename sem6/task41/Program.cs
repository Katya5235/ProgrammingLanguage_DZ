// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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
    
    return array;
}

int Positivenum(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            quantity = quantity + 1;
        }
    }
    return quantity;
}
int[] myarray =FillArray();
int qan =Positivenum(myarray);
Console.Write($"Вывод массива: {string.Join(", ", (myarray))} / кол-во положительных чисел: {qan}");


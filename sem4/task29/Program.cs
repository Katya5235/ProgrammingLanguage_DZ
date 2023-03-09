// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. 
// Данные вводятся с консоли пользователем



Console.WriteLine("Введите кол-во элементов массива  ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i} -  ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива ");

for (int i = 0; i < array.Length; i++)
{
Console.WriteLine(array[i]);
}








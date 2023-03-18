// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет
Console.WriteLine("Введите позицию элемента в строке  ");
int numrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце  ");
int numcolumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[4, 6];
FillArray(array);


if(numrows> array.GetLength(1) || numcolumn> array.GetLength(0))
{
    Console.WriteLine(" Такого элемента нет в массиве  ");
}
else {
Console.WriteLine($" элемент  строки {numrows} и столбца {numcolumn} является элемент:{array[numcolumn - 1,numrows - 1]}");
}
PrintArray(array);

void FillArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = new Random().Next(1, 16);

        }
    }
}

void PrintArray(int[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            Console.Write(arra[i, j] + " ");
        }
        
        Console.WriteLine();
    }
}






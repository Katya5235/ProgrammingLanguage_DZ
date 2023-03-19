// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет
int[,] array = new int[10, 10];
FillArray(array);
PrintArray();
Console.Write("Введите номер строки: ");
int numrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numcolumn = Convert.ToInt32(Console.ReadLine());
if (numcolumn > array.GetLength(0) && numrows > array.GetLength(1) || numcolumn < 0 && numrows < 0)
{
    Console.WriteLine("Такого элемента нет ");
}
else
{
   Console.WriteLine($" элемент  строки {numrows} и столбца {numcolumn} является элемент:{array[numrows - 1, numcolumn - 1]}");
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 16);

        }
    }

}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}










// void Main()
// {
// const int ROWS = 
// const int COLUMS =
// const int LEFTBORDER =
// const int RIGHTBORDER =
// }

// if (
//     numcolumn > array.GetLength(1)  numrows > array.GetLength(0)
//      numcolumn < 1 || numrows < 1
//     )
// {
//     Console.WriteLine(" Такого элемента нет в массиве  ");
// }
// else
// {
//     Console.WriteLine($" элемент  строки {numrows} и столбца {numcolumn} является элемент:{array[numrows - 1, numcolumn - 1]}");
// }


// Console.Write("Введите номер строки ");
// int numrows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца ");
// int numcolumn = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[4, 6];
// FillArray(array);


// if (numrows > array.GetLength(1)|| numcolumn > array.GetLength(0) 
//     numcolumn<0 || numrows<0) 


// {
//     Console.WriteLine(" Такого элемента нет в массиве  ");
// }

// else
// {
//     Console.WriteLine($" элемент  строки {numrows} и столбца {numcolumn} является элемент:{array[numcolumn , numrows ]}");
// }
// PrintArray(array);

// void FillArray(int[,] ar)
// {
//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             ar[i, j] = new Random().Next(1, 16);

//         }
//     }
// }

// void PrintArray(int[,] arra)
// {
//     for (int i = 0; i < arra.GetLength(0); i++)
//     {

//         for (int j = 0; j < arra.GetLength(1); j++)
//         {
//             Console.Write(arra[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }


// FillArray(array);
// PrintArray(array);

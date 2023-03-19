// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomArray(int rows, int colums, int leftborder, int rightborder)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(leftborder, rightborder);

        }
    }
    return array;
}
void PrintArray(int[,] array)
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
void Main()
{
    const int ROWS = 2;
    const int COLUMS = 4;
    const int LEFTBORDER = 10;
    const int RIGHTBORDER = 40;
    int[,] myarray = GetRandomArray(ROWS, COLUMS, LEFTBORDER, RIGHTBORDER);
    PrintArray(myarray);
    Average(myarray);
}

double Average(int[,] array)
{

    double aver = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            aver += array[i,j];
        }
            aver/=array.GetLength(0);
        Console.WriteLine($" среднее арифметическое столбца {j} : {aver}");
    }
return aver;
}



Main();
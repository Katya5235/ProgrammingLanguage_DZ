// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Main();
void Main()
{
    const int ROWS = 4;
    const int COLUMS = 7;
    const int LEFTBORDER = 10;
    const int RIGHTBORDER = 100;
    int[,] matrix = new int[ROWS, COLUMS];
    Fill2DMatrix(matrix, LEFTBORDER, RIGHTBORDER);
    Print2DMatrix(matrix);
    int NumberOfRow = RowNumberWithMinimumSumOfElements(matrix);
    Console.WriteLine($" Строка с наименьшей суммой элементов  = {NumberOfRow}");
}





int[,] Fill2DMatrix(int[,] array, int leftborder, int rightborder)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(leftborder, rightborder);

        }
    }
    return array;
}


void Print2DMatrix(int[,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            Console.Write(myarray[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int RowNumberWithMinimumSumOfElements(int[,] matrix)
{

    int minSum = 0;
    int index =0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($" сумма строки {i+1} = {sum} ");
        if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    
    }


    return index+1;

}









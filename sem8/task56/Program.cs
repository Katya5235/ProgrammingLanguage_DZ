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
    int summin = SumOfRowElements(matrix);
    Console.WriteLine($" min = {summin}");
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


int SumOfRowElements(int[,] matrix)
{
    int sum = 0;
    int min = 0;
    int sum1 = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum1=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            sum1 += matrix[i, j];

        }
        if (sum1 > sum)
        {
        sum = sum1;
        }
        else min =i+1;
        Console.WriteLine($" {i + 1} = {sum1}");

        

    }



    return min;
}









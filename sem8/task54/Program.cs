// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Main();
int[,] Fill2DMatrix(int rows, int colums, int leftborder, int rightborder)
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


int [,] SortAscending(int[,] sortarray)
{
    for (int i = 0; i < sortarray.GetLength(0); i++)
    {
        for (int j = 0; j < sortarray.GetLength(1); j++)
        {
            for (int a = 0; a < sortarray.GetLength(1) -1; a++)
            {

                if (sortarray[i, a] > sortarray[i, a+1])
                {
                    int temp = sortarray[i, a]; 
                    sortarray[i, a] = sortarray[i, a+1];
                    sortarray[i, a +1] = temp;
                }
            }
        }

    }
   return sortarray; 

}
void Main()
{
    const int ROWS = 4;
    const int COLUMS = 5;
    const int LEFTBORDER = 10;
    const int RIGHTBORDER = 100;
    int[,] matrix = Fill2DMatrix(ROWS, COLUMS, LEFTBORDER, RIGHTBORDER);
    Print2DMatrix(matrix);
    int [,] sortmatr = SortAscending(matrix);
     Console.WriteLine();
    Print2DMatrix(sortmatr);
   
   
}
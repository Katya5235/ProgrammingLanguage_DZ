// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 4

Main();

void Main()
{
    const int ROWS = 4;
    const int COLUMS = 5;
    const int LEFTBORDER = 1;
    const int RIGHTBORDER = 10;
    int[,] first = FirstMatrix(ROWS, COLUMS, LEFTBORDER, RIGHTBORDER);
    int[,] second = SecondMatrix(ROWS, COLUMS, LEFTBORDER, RIGHTBORDER);
    Print2DMatrix(first);
    Console.WriteLine();
    Print2DMatrix(second);
    int[,] array = new int [ROWS,COLUMS];
    int [,] matr = Matrix(first,second,array);
    Console.WriteLine();
   Print2DMatrix(matr);
    


}
int[,] FirstMatrix(int rows, int colums, int leftborder, int rightborder)
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

int[,] SecondMatrix(int rows, int colums, int leftborder, int rightborder)
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

int[,] Matrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] result)
{
    
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
           
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                result[i,j] = firstMartrix[i, j] * secomdMartrix[i, j];
            }
            
        }
    }
    return result;
}

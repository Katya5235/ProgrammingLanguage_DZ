// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] Fill2DMatrix()
{
   
    int[,] matrix = new int[4, 4];
    int element = 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = element;
        element++;
    }

    for (int i = 1; i < matrix.GetLength(0) - 1; i++)
    {
        matrix[i, matrix.GetLength(1) - 1] = element;
        element++;


    }
    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
    {
        matrix[matrix.GetLength(0) - 1, j] = element;
        element++;
    }
    for (int i = matrix.GetLength(0) - 2; i > 0; i--)
    {
        matrix[i, 0] = element;
        element++;
    }
    for (int j = matrix.GetLength(1) - 3; j < matrix.GetLength(1) - 1; j++)
    {
        matrix[matrix.GetLength(0) - 3, j] = element;
        element++;
    }

    for (int j = matrix.GetLength(1) - 2; j > 0; j--)
    {
        matrix[matrix.GetLength(0)-2,j]=element;
        element++;
    }

    return matrix;
}





void Print2DMatrix(int[,] array)
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

int[,] matr = Fill2DMatrix();
Print2DMatrix(matr);
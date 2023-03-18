// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// ​ m = 3, n = 4.
// ​ 0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9


//   double ArrayDimension

Console.WriteLine("Введие размерность строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, colums];
FillArray(array);
PrintArray(array);

void FillArray(double[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = Convert.ToDouble(new Random().Next(1, 16)) / 10;

        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        
        Console.WriteLine("");
    }
}
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// int [,,] array = new int[4, 3, 5];
// array [0,2,4] = 41;



// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             Console.Write(array[i, j, k]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// }
void Main()
{
    const int PAGE = 2;
    const int ROWS = 4;
    const int COLUMS = 6;
    int[,,] MyArray = TakeAndFill3DMatrix(PAGE, ROWS, COLUMS);
    Print3DMatrix(MyArray);
}


int [,,] TakeAndFill3DMatrix(int page, int rows, int colums)
{
    int[,,] array = new int[page, rows, colums];
    int counter = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = counter;
                counter++;
            }
        }
    }

    return array;
}
void Print3DMatrix(int[,,] FilledArray)
{

    for (int i = 0; i < FilledArray.GetLength(0); i++)
    {
        Console.WriteLine($" Namber of page №{i+1}");
        for (int j = 0; j < FilledArray.GetLength(1); j++)
        {
            for (int k = 0; k < FilledArray.GetLength(2); k++)
            {
                Console.Write($"{FilledArray[i,j,k]}:[{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Main();


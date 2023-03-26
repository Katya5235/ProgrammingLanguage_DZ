// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int N = 8;
int M = 4;

int p = SumOfNumbersFromMToN(N, M);
Console.WriteLine(p);
int SumOfNumbersFromMToN(int n, int m)
{
    int sum = n;
    if (n == m-1) return 0;


    sum += SumOfNumbersFromMToN(n - 1, m);

    return sum;

}


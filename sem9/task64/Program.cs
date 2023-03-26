// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 6;
PrintDescendingNumbers(number);
void PrintDescendingNumbers (int n)
{
    if(n==0) return;
    Console.WriteLine(n+"");
    PrintDescendingNumbers(n-1);
    
}

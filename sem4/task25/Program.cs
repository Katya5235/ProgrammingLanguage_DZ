// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadIntNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число A и B ");

int A = ReadIntNumber();
int B = ReadIntNumber();



// int count = 0;
// if (A >B)
// {
//     count = A + 1 - B;
// }
// else count = B + 1 - A;

// Решение: k=329-1-7=321.
// Console.WriteLine(count);
// int bot = A;
int a = A;
int count = B;
int sum = 1;

    sum*=a;


Console.WriteLine(sum);

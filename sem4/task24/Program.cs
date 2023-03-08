// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadIntNumber(string mesageToUser)
{
    Console.WriteLine(mesageToUser);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }

    return sum;
}

int number = ReadIntNumber("enter variable a ");
int result = SumFrom1ToA(number);
Console.WriteLine($"summa digits from 1 to {number} = {result}");


// int b = ReadIntNumber("enter variable b ");
// int c = ReadIntNumber("enter variable c ");

// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EnterNumber(string mesage)
{
    Console.WriteLine(mesage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SizeNumber(int a)
{
    int i = 0;
    while (a > 0)
    {
        i++;
        a /= 10;
    }
    return i;
}

int Sumdigit(int b)
{
    int res = 0;
    int s = 0;
    while (b > 0)
    {
        s = b % 10;
        res = res + s;
        b /= 10;
    }
    return res;
}


int num = EnterNumber(" Enter your favorite number  ");
int size = SizeNumber(num);
Console.WriteLine($" number of digits in {num} = {size}");
int sdig = Sumdigit(num);
Console.WriteLine($" Sum of digits in {num} = {sdig}");








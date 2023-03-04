// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("enter five-digit number ");
int number = Convert.ToInt32(Console.ReadLine());

int pol = 0;
int num = number;

while (number > 0)
{
    pol = pol * 10 + number % 10;
    number /= 10;
}
if (pol == num) Console.WriteLine("polyndrom");
else Console.WriteLine("not a polyndrome");
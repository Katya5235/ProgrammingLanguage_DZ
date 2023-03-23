// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string[] days = { "Monday", "Tuesday", "Wenesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.WriteLine("Enter number of day");
int numberofday = Convert.ToInt32(Console.ReadLine());
if (numberofday > 7 | numberofday < 1) Console.WriteLine("introduced the wrong number of the day!!!");


if (numberofday <= 5)
{
    Console.WriteLine(days[numberofday - 1]); Console.WriteLine("No, this is a work day!");
}
if (numberofday == 6 | numberofday == 7)
{
    Console.WriteLine(days[numberofday - 1]); Console.Write("Yes, this is the off day!");
}



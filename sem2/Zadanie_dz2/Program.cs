﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine(" Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("no third number ");

if (number >100){
    int thirdnumber = number % 10;

    Console.WriteLine(thirdnumber);
}


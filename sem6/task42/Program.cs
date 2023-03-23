// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
int number = Convert.ToInt32(Console.ReadLine());
int s = 0; int a = 0;
while (number != 0)
{
     s = number % 2;
    number = number / 2;

   
    
    a = s % 10;
    Console.Write(s);
    Console.Write(a);
}
 



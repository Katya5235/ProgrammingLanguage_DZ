// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadIntNumber(string mesageToUser)
{
    Console.WriteLine(mesageToUser);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AmountOfNumbers(int a)
{   
    int sir =1;
    while(a>10){
        a /= 10;
        sir++;
    }
    return sir;
}

int method1 = ReadIntNumber("enter number  ");
int method2 = AmountOfNumbers(method1);
Console.WriteLine($"number of digits from {method1} - {method2} digits");

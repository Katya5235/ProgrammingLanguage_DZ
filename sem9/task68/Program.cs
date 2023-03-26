// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int N = 1;
int M = 1;

Console.Write(Akerman(N,M));

int Akerman (int n, int m)
{
    
    if (n == 0)  return  m + 1;
  
       
    
      else if (m==0) return Akerman(n - 1, 1);
    
        
   
  else return  Akerman(n - 1, Akerman(n, m - 1));
    
       
    

}


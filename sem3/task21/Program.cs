// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int getInt()
{
   return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("enter coordinates of points A and B");

int x1 = getInt(); //A_x
int x2 = getInt(); //B_x
int y1 = getInt(); //A_y
int y2 = getInt(); //B_y
int z1 = getInt(); //A_z
int z2 = getInt(); //B_z

double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(res);
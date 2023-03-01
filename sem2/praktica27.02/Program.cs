// Задание Давида/ из семинара 
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 6 || n == 7){
  Console.WriteLine("да");
}
else if(n >= 1 && n <= 5){
  Console.WriteLine("нет");
}
else Console.WriteLine("Вы ввели неправильный номер дня недели!");

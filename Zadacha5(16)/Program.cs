//Напишите программу, которая принимает на вход 2 числа
//и проверяет, является ли одно число квадратов другого
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8, 9 -> нет

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b || b * b == a)
    Console.WriteLine("да");
else 
    Console.WriteLine("Нет");
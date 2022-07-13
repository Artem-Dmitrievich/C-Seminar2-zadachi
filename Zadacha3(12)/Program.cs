//Напишите программу, которая будет принимать на вход 2 числа и выводить,
//является ли второе число кратно первому. Если число 2 не кратно числу 1,
//то программа выводит остаток от деления
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Остаток при делении равен: " + Convert.ToString(a % b));
//else
//{
//  Console.Write("Остаток при делении равен: );
//  Console.Write(a % b);
//}
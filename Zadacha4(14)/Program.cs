//Напишите программу, которая прнимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23
//14 -> нет
//46 -> нет
//161 ->да
//1 способ - "условие внутри условия"
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0)
{
    if (n % 23 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine("Кратно 7, но не кратно 23");       
}
else
    Console.WriteLine ("Не кратно");

//2 способ (лог.оператор)

//if (n % 7 == 0 && n % 23 == 0) *&& - и
//  Сonsole.WriteLine("Кратно");
//else
//  Сonsole.WriteLine("Не Кратно");
// && - и(and) - * (ставится когда достаточно выполнения 1 условия или 2 сразу же)
// || - или (or) - + *когда проверяется условие,возращает True=1 или false=0
//*Буливская алгебра
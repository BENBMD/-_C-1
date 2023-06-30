/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.Write("Введите номер дня недели: ");
int nunberDayOfWeek = int.Parse(Console.ReadLine());
//
if ((nunberDayOfWeek >= 1) || (nunberDayOfWeek <= 7))
{
    if (nunberDayOfWeek == 1)
        Console.WriteLine($" понедельник");
    if (nunberDayOfWeek == 2)
        Console.WriteLine($"вторник");
    if (nunberDayOfWeek == 3)
        Console.WriteLine($" среда");
    if (nunberDayOfWeek == 4)
        Console.WriteLine($" четверг");
    if (nunberDayOfWeek == 5)
        Console.WriteLine($" пятница");
    if (nunberDayOfWeek == 6)
        Console.WriteLine($" суббота");
    if (nunberDayOfWeek == 7)
        Console.WriteLine($" воскресенье");
    if (nunberDayOfWeek >= 1 && nunberDayOfWeek < 6)
        Console.WriteLine($" день не является выходным");
    if (nunberDayOfWeek > 5)
        Console.WriteLine(" выходной день");
if (nunberDayOfWeek < 1 || nunberDayOfWeek > 7)
Console.WriteLine("введён неправильный номер дня");
return;
}
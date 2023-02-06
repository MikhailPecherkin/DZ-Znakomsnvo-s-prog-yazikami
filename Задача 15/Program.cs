// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Укажите цифру обозначающую день недели и мы узнаем выходной ли это день: ");
int day=Convert.ToInt32(System.Console.ReadLine());

if (day<8 && day >5)
{
    System.Console.WriteLine($"{day} -> да");
}
else if (day>7)
{
    System.Console.WriteLine($"{day} дня недели нет");
}
else if (day<6)
{
    System.Console.WriteLine($"{day} -> нет");
}
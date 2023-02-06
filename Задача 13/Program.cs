// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число для изучения: ");
int a=Convert.ToInt32(System.Console.ReadLine());

if (a<100)
{
    System.Console.WriteLine($"В числе {a} не третьей цифры");
}
else 
{
    while (a>999)
    {
        a = a / 10;
    }
    System.Console.WriteLine($"Третья цифра равна: {a % 10}");
}
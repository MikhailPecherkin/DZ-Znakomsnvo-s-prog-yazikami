// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write ("Введите число для анализа: ");
int a=Convert.ToInt32(Console.ReadLine());
int i=0; // число вариантов
int b=0; // итоговые числа

System.Console.Write("Получаются следующие числа: ");
while (i < a / 2 )
{
    System.Console.Write($"{b+2}  ");
    i++;
    b+=2;
}
System.Console.WriteLine("");
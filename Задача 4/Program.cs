// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) 
{
    System.Console.WriteLine($"Первое число самое большое:{a}");
    }
    else if (b > a && b > c) 
    {
        System.Console.WriteLine($"Второе число самое большое:{b}");
    }
        else if (c > a && b < c) 
        {
            System.Console.WriteLine($"Третье число самое большое:{c}");
        }
            else if (a == b && a > c) 
            {
                System.Console.WriteLine($"Первое и второе число одинаково и самое большое:{a}");
            }
                else if (a == c && a > b) 
                {
                    System.Console.WriteLine($"Первое и третье число одинаково и самое большое:{a}");
                }
                    else if (b == c && a < b) 
                    {
                        System.Console.WriteLine($"Второе и третье число одинаково и самое большое:{b}");
                    }
else
{
     System.Console.WriteLine($"Числа равны");
}
// Задача №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine("Первое число больше: {0} > {1}", a, b);
}
    else if (b > a)
    {
         System.Console.WriteLine("Второе число больше: {0} < {1}", a, b);
    }
    else 
    {
        System.Console.WriteLine("Введены равные числа: {0} = {1}", a, b);    
    }

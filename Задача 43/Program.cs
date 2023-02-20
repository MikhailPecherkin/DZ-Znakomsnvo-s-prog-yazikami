// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите b1: ");
double b1 = System.Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k1: ");
double k1 = System.Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите b2: ");
double b2 = System.Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = System.Convert.ToInt32(Console.ReadLine());

double x = Math.Round((b2 - b1) / (k1 -k2), 2);
double y = Math.Round(k1 * x +b1, 2);


System.Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
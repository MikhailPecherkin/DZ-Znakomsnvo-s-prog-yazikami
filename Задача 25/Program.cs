// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(System.Console.ReadLine());

// double c = Math.Pow(a, b);
// System.Console.WriteLine($"Число {a} в стпени {b} равно: {c}");

int rez = 1;
for (int i = 1; i <= b ; i++)
{
    rez = rez*a;
}
System.Console.WriteLine($"Число {a} в стпени {b} равно: {rez}");
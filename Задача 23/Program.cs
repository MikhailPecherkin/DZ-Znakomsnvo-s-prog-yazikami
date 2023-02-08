// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("ВВедите число N: ");
int n=Convert.ToInt32(System.Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    System.Console.Write(Math.Pow(i,3) + " ");
}
System.Console.WriteLine("");
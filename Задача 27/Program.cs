// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введите число: ");
int chislo = Convert.ToInt32(System.Console.ReadLine());

int sum = 0;
while (chislo>0)
{
     sum = chislo % 10 + sum;
     chislo = chislo / 10;
}
System.Console.WriteLine(sum);
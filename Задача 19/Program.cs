// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int chislo = Convert.ToInt32(System.Console.ReadLine());

// разбитие левой части
int a1 = chislo / 10000;
int a2 = chislo / 1000 % 10;
// разбитие правой части
int b1 = chislo % 100 / 10;
int b2 = chislo % 10;

if (chislo < 10000 || chislo > 99999)
{
    System.Console.WriteLine("Число не пятизначное, повнимательнее!!!");
}
    else if (a1 == b2 && a2 == b1)
    {
        System.Console.WriteLine("Да, число полиндром");
    }
else
{   
    System.Console.WriteLine("Нет, число не полиндром");
}


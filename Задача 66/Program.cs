// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите число М: ");
int n = ReadInt("Введите число N: ");

int Summa(int numM, int numN)
{
    if (numM == numN)
    {
        return numM;
    }
    if (numM < numN)
    {
        return numN + Summa(numM, numN - 1);
    }
    return numN + Summa(numM, numN + 1);
}
Summa(m, n);
System.Console.WriteLine($"Сумма чисел от {m} до {n} равна {Summa(m, n)}");







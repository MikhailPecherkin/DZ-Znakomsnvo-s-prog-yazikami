// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите число М: ");
int n = ReadInt("Введите число N: ");

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return m + 1;

    }
    else if ((m > 0) && (n == 0))
    {

        return Akker(m - 1, n);

    }
    else if ((n != 0) && (m == 0))
    {

        return Akker(n - 1, m);

    }
    else if ((m != 0) && (n > 0))
    {

        return Akker(m - 1, Akker(m, n - 1));

    }
    else if ((n > 0) && (m > 0))
    {

        return Akker(n - 1, Akker(n, m - 1));

    }
    else
    {
        return 0;
    }
}


// int Akker(int m, int n)
// {
//     if (!m && n)
//      return (n + 1);
//      else
//      if (m and!n)
//      return Akk(m - 1, 1);
// return Akk(m - 1, Akk(m, n - 1));
// }

System.Console.WriteLine($"Функция Аккермана = {Akker(m, n)}");
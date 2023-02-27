// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = ReadInt("Укажите количество строк первой матрицы   : ");
int cols = ReadInt("Укажите количество столбцов первой матрицы: ");
int cols2 = ReadInt("Укажите количество столбцов второй матрицы: ");

int[,] GenerateMatrix1(int rows, int cols)
{
    int[,] matrix1 = new int[rows, cols];
    var rand = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rand.Next(0, 10);
        }
    }
    return matrix1;
}
void PrintMatrix1(int[,] matrix1)
{
    System.Console.WriteLine("----------------------------------------");
    System.Console.WriteLine($"Первая матрица размером {rows} на {cols} случайных чисел");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            System.Console.Write(matrix1[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateMatrix2(int cols, int cols2)
{
    int[,] matrix2 = new int[cols, cols2];
    var rand = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rand.Next(0, 10);
        }
    }
    return matrix2;
}
void PrintMatrix2(int[,] matrix2)
{
    System.Console.WriteLine($"Вторая матрица размером {cols} на {cols2} случайных чисел");
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            System.Console.Write(matrix2[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return matrix3;
}
void PrintMatrix3(int[,] matrix3)
{
    System.Console.WriteLine("Результат перемножения двух матриц");
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            System.Console.Write(matrix3[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

var myMatrix1 = GenerateMatrix1(rows, cols);
var myMatrix2 = GenerateMatrix2(cols, cols2);
var myMatrix3 = DivMatrix(myMatrix1, myMatrix2);
PrintMatrix1(myMatrix1);
PrintMatrix2(myMatrix2);
PrintMatrix3(myMatrix3);

System.Console.WriteLine("----------------------------------------");





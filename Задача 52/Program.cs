// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = ReadInt("Укажите количество строк:    ");
int cols = ReadInt("Укажите количество столбцов: ");

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine("---------------------------------------------------");
    System.Console.WriteLine($"Таблица размером {rows} на {cols} случайных чисел");
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine("---------------------------------------------------");
for (int j = 0; j < myMatrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        sum += myMatrix[i, j];
    }
    double arth = Math.Round(sum / myMatrix.GetLength(0), 1);
    Console.Write(arth + "\t");
}
System.Console.WriteLine("");
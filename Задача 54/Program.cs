// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    System.Console.WriteLine("----------------------------------------");
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
System.Console.WriteLine("----------------------------------------");

System.Console.WriteLine("По убыванию в строке");
int[,]? copy = myMatrix.Clone() as int[,];
for (int i = 0; i < copy?.GetLength(0); i++)
{
    for (int j = 0; j < copy.GetLength(1); j++)
    {
        for (int k = 0; k < copy.GetLength(1); k++)
        {
            if (copy[i, j] <= copy[i, k])
                continue;
            else
            {
                int temp = copy[i, j];
                copy[i, j] = copy[i, k];
                copy[i, k] = temp;
            }
        }
    }
}
for (int i = 0; i < copy?.GetLength(0); i++, Console.WriteLine())
    for (int j = 0; j < copy.GetLength(1); j++)
    {
        Console.Write(copy[i, j] + "\t");
    }
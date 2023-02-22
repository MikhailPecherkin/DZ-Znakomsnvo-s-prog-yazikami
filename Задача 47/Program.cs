// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Укажите количество строк m: ");
int cols = ReadInt("Укажите количество столбцов n: ");
int min = ReadInt("Укажите минимальную границу чисел: ");
int max = ReadInt("Укажите максимальную границу чисел: ");
int toch = ReadInt("Укажите точность до какого знака после запятой: ");

double[,] GenerateMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(min, max) + rand.NextDouble(), toch);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    System.Console.WriteLine("------------------------------------------------------------------------------");
    System.Console.WriteLine($"Матрица размером {rows} на {cols} случайных чисел с точностью до {toch} знака");
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

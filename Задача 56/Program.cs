// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void Sumstrok(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
            index = 1;
        }
        else 
        if (sum < minsum)
        {
            minsum = sum;
            index = i+1;
        }
            
    }
     Console.WriteLine($"Наименьшая сумма элементов {minsum} в строке {index}");
}

var myMatrix = GenerateMatrix(rows, cols);

PrintMatrix(myMatrix);
System.Console.WriteLine("----------------------------------------");
Sumstrok(myMatrix);





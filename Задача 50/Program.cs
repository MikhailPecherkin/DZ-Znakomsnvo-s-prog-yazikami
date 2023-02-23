// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = ReadInt("Укажите количество строк:    ");
int cols = ReadInt("Укажите количество столбцов: ");
System.Console.WriteLine("Для определения значения нужного элемента укажите");
int n = ReadInt("- номер строки:  ")-1;
int m = ReadInt("- номер столбца: ")-1;

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
if (n<0 || n>rows-1 || m>cols-1 || m<0)
{
    Console.WriteLine("Такой ячейки нет в матрице, повторите ввод");
}
else 
{
     Console.WriteLine("Интересующий Вас элемент равен: = {0}", myMatrix[n, m]);
     Console.WriteLine("---------------------------------------------------");
}
    
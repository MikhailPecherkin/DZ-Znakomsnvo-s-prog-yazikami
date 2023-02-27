// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 2;
int cols = 2;
int dep = 2;
int[,,] GenerateMatrix(int rows, int cols, int dep)
{
    int[,,] matrix = new int[rows, cols, dep];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
            matrix[i, j, k] = rand.Next(10, 100);
           }
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})" + "\t");              
            }
        }
        System.Console.WriteLine();
    }
}
var myMatrix = GenerateMatrix(rows, cols, dep);
PrintMatrix(myMatrix);

﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateMatrix(int rows, int cols, int dep)
{
    int[,,] matrix = new int[rows, cols, dep];
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2); i++)
    {
        temp[i] = new Random().Next(10, 100);
        int number = temp[i];
        
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
    }
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = temp[count];
                count++;
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
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int rows = 2;
int cols = 2;
int dep = 2;

GenerateMatrix(rows, cols, dep);
var myMatrix = GenerateMatrix(rows, cols, dep);
PrintMatrix(myMatrix);
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.Write("Введите количество чисел в массиве: ");
int size = System.Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задайте минимальную границу: ");
int minValue = System.Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задайте максимальную границу: ");
int maxValue = System.Convert.ToInt32(Console.ReadLine());

double [] GenerateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
double [] myArray = GenerateArray(size, minValue, maxValue);
PrintArray (myArray);

// Разница
double min = myArray[0];
double max = myArray[0];
for (int i = 1; i < size; i++)
{
       if (myArray[i] < min)
            min = myArray[i];
       if (myArray[i] > max)
            max = myArray[i];
}
Console.WriteLine($"Разница между минимальным значением {min} и максимальным {max} составляет: {max - min}");

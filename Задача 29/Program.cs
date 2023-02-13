// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
System.Console.Write("Введите количество чисел в массиве: ");
int size = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите минимальную границу массива: ");
int min = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите минимальную границу массива: ");
int max = Convert.ToInt32(System.Console.ReadLine());

int[] FillArray()
{
    int[] arrN = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrN[i] = new Random().Next(min, max);
    }
    return arrN;
}

int[] myArray = FillArray();
PrintArray(myArray);
System.Console.WriteLine("");

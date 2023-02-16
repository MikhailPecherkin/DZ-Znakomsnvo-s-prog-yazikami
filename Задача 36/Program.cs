// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.Write("Введите количество чисел в массиве: ");
int size = System.Convert.ToInt32(Console.ReadLine());
int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int FindQ(int[] array)

{
    int rez = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        rez = array[i] + rez;
    }
    return rez;
}

int [] myArray = GenerateArray(size, 0, 100);
PrintArray (myArray);
System.Console.WriteLine($"Сумма чисел на нечётных позициях равна: {FindQ(myArray)} ");
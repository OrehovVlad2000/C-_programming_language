// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайными числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int[] FillArray(int size, int start, int stop)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, stop);
    }
    return array;
}


Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
Console.Write("Введите число начала диапазона случайных чисел: ");
int numStart = int.Parse(Console.ReadLine());
Console.Write("Введите число конца диапазона случайных чисел: ");
int numStop = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", FillArray(sizeArray, numStart, numStop)));
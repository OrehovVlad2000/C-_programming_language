// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int[,] FillArray(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 11);
        }
    }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int MinimumSumRowElements(int[,] matrix)
{
    int sum = int.MaxValue;
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count += matrix[i, j];
        }
        if (count < sum)
        {
            sum = count;
            minIndex = i;
        }
    }
    return minIndex + 1;
}

int[,] myArray = FillArray(5, 5);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine(
    $"Номер строки с наименьшей суммой элементов: {MinimumSumRowElements(myArray)}");
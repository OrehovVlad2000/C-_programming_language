// Задача 50. Напишите программу, которая на вход принимает число и генерирует 
// случайный двумерный массив, и возвращает индексы этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
    return matr;
}

void FindNumber(int[,] matr, int num)
{
    bool flag = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
            {
                flag = true;
                Console.WriteLine($"Индексы числа: {i},{j}");
                break;
            }
        }
    }
    if (flag == false) Console.WriteLine("Такого числа в массиве нет");
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

Console.Write("Введите число которое нужно найти: ");
int desiredNum = int.Parse(Console.ReadLine());
int[,] matrix = FillArray(5, 5);
PrintArray(matrix);
FindNumber(matrix, desiredNum);
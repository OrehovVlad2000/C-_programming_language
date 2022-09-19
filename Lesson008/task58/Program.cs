// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                for (int k = 0; k < matr2.GetLength(0); k++)
                {
                    result[i, j] += matr1[i, k] * matr2[k, j];
                }
            }
        }
        return result;
    }
    else
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        return matr1;
    }
}

int[,] myMatrix1 = FillArray(2, 2);
int[,] myMatrix2 = FillArray(2, 2);
PrintArray(myMatrix1);
Console.WriteLine();
PrintArray(myMatrix2);
Console.WriteLine();
PrintArray(MatrixMultiplication(myMatrix1, myMatrix2));
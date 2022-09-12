// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите b{i + 1}: ");
            else Console.Write($"Введите k{i + 1}: ");
            matr[i, j] = double.Parse(Console.ReadLine());
        }
    }
}

double[] IntersectionPoint(double[,] coef)
{
    double[] array = new double[2];
    array[0] = (coef[1, 0] - coef[0, 0]) / (coef[0, 1] - coef[1, 1]);
    array[1] = coef[0, 1] * array[0] + coef[0, 0];
    return array;
}

bool IntersectionCheck(double[,] matrix)
{
    return (matrix[0, 0] != matrix[0, 1] &&
    matrix[0, 0] != matrix[1, 0] &&
    matrix[0, 0] != matrix[1, 1] &&
    matrix[0, 1] != matrix[1, 0] &&
    matrix[0, 1] != matrix[1, 1] &&
    matrix[1, 0] != matrix[1, 1] && 
    matrix[0, 0] < matrix[0, 1] && 
    matrix[1, 0] < matrix[1, 1] && 
    matrix[0, 1] > matrix[1, 0]);
}

double[,] coefficient = new double[2, 2];
FillArray(coefficient);

if (IntersectionCheck(coefficient))
{
    Console.WriteLine(String.Join(";", IntersectionPoint(coefficient)));
}
else
{
    Console.WriteLine("Точки пересечения нет!");
}
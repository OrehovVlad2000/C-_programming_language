// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArrayDoub(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() + new Random().Next(1, 100);
    }
    return res;
}

double MaxElement (double[] array)
{
    double max = array[0];
    foreach (double el in array)
    {
        if (el > max)
        {
            max = el;
        }
    }
    return max;
}

double MinElement (double[] array)
{
    double min = array[0];
    foreach (double el in array)
    {
        if (el < min)
        {
            min = el;
        }
    }
    return min;
}

double[] myArray = GetArrayDoub(5);
Console.WriteLine(String.Join(", ", myArray));
Console.WriteLine(
    $"Разница между элементами: {MaxElement(myArray) - MinElement(myArray)}");
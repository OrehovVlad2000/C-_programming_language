// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumOfOddIndices(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count += i % 2 != 0 ? array[i] : 0;
    }
    return count;
}

int[] myArray = GetArray(5, 0, 100);
Console.WriteLine(String.Join(", ", myArray));
Console.WriteLine(
    $"Cумма элементов, стоящих на нечётных позициях: {SumOfOddIndices(myArray)}");
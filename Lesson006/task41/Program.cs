// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int NumGreaterThanZero(int amountNum)
{
    int count = 0;
    for (int i = 0; i < amountNum; i++)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) count += 1;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int amountNumbers = int.Parse(Console.ReadLine());
Console.WriteLine(
    $"Количество чисел больше нуля: {NumGreaterThanZero(amountNumbers)}");
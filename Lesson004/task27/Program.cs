// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumOfDigits(int numbers)
{
    int result = 0;
    while (numbers > 0)
    {
        result += numbers % 10;
        numbers /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfDigits(num));
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Exponentiation(int number1, int number2)
{
    int result = 1;
    if (number2 < 0)
    {
        number2 *= -1;
    }
    for (int i = 1; i <= number2; i++)
    {
        result *= number1;
    }
    return result;
}

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine(Exponentiation(numA, numB));
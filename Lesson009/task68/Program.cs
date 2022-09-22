// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AckermannFunction(int m, int n)
{
    if (m == 0) n += 1;
    else if (m > 0 && n == 0) n = AckermannFunction(m - 1, 1);
    else if (m > 0 && n > 0) n = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return n;
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermannFunction(numberM, numberN));
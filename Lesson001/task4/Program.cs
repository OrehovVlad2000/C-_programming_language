//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите превое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"max = {num2}");
}
else
{
    Console.WriteLine($"max = {num3}");
}
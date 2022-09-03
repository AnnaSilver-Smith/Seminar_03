// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
double N = double.Parse(Console.ReadLine());
Console.Write($"{N} -> ");
for(double i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)}{(i != N ? "," : "\n")}");
}
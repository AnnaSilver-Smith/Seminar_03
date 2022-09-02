//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число палиндрома: ");
string str = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
while (str.Length < 5 || str.Length > 5)
{
    str = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
}
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
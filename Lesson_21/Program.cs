// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + 
                         Math.Pow((y2 -y1), 2) + 
                         Math.Pow((z2 - z1), 2));
    }
double lenght = Math.Round(Distance(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве {lenght}");
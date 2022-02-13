//Задача 22: Найти расстояние между точками в пространстве 2D/3D
//AB = √(xb - xa)2 + (yb - ya)2

int a = new Random().Next(1, 20);
int b = new Random().Next(1, 20);
int c = new Random().Next(1, 20);
int d = new Random().Next(1, 20);
Console.WriteLine($"Координаты первой точки: х = {a}, у = {b}");
Console.WriteLine($"Координаты второй точки: х = {c}, у = {d}");
int i = ((a - c)*(a - c)) + ((b - d)*(b - d));
int n = 2;
int num = i;
double s = Math.Pow((double)num, (double)1 / n);
Console.WriteLine($"Расстояние между точками: {s}");

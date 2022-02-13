//Задача 20: Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти цифрой");
int a = int.Parse(Console.ReadLine());
if(a==1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (a == 2)
{
    Console.WriteLine("x > 0, y < 0");
}
else if (a == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else 
Console.WriteLine("x > 0, y < 0");
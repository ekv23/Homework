//Задача 24: Найти кубы чисел от 1 до N

int N = new Random().Next(1, 20);
Console.WriteLine(N);

for(int i = 0; i <= N; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
}
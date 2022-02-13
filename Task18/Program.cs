//Задача 18: Проверить истинность утверждения
//¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = true;

if ((!(x || y)) == !x && !y)
{
    Console.WriteLine("выражение x = !(x || y))== !x && !y истинно");
}
else Console.WriteLine("выражение x = !(x || y))== !x && !y ложно");

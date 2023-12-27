int x1 = 0, y1 = 0, r1 = 1; // Параметры первой окружности
int x2 = 2, y2 = 0, r2 = 2; // Параметры второй окружности
int x3 = 0, y3 = 0; // Параметры заданной точки

// Расстояние между центрами окружностей
double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

// Проверка пересечения окружностей
bool isIntersecting = distance <= r1 + r2 && distance >= Math.Abs(r1 - r2);

// Вывод параметры первой окружности
Console.WriteLine("Параметры первой окружности = X" + x1 + ":Y" + y1 + ":R" + r1);
// Вывод параметры второй окружности
Console.WriteLine("Параметры второй окружности = X" + x2 + ":Y" + y2 + ":R" + r2);

// Вывод результата окружностей
if (isIntersecting)
{
    Console.WriteLine("Окружности пересекаются\n");
}
else
{
    Console.WriteLine("Окружности не пересекаются\n");
}

// Задаём параметры точки по X
Console.Write("Укажите координаты точки по X = ");
x3 = Convert.ToInt32(Console.ReadLine());
// Задаём параметры точки по Y
Console.Write("Укажите координаты точки по Y = ");
y3 = Convert.ToInt32(Console.ReadLine());
// Вывод параметры точки
Console.WriteLine("Точка находиться по координатам = X" + x3 + ":Y" + y3);

// Проверка пересечения точки с первой окружности
bool isInsideFirst = (x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1) <= r1 * r1;
// Проверка пересечения точки с второй окружности
bool isInsideSecond = (x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2) <= r2 * r2; 

// Вывод результата точки
if (isInsideFirst && isInsideSecond)
{
    Console.WriteLine("Точка находится внутри обеих окружностей");
}
else if (isInsideFirst)
{
    Console.WriteLine("Точка находится внутри первой окружности");
} 
else if (isInsideSecond)
{
    Console.WriteLine("Точка находится внутри второй окружности");
}
else
{
    Console.WriteLine("Точка не находится внутри окружностей");
}
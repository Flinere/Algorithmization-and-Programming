// В минус не работает
while (true)
{ 
    Console.WriteLine("Введите число a");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите число b");
    double b = Convert.ToDouble(Console.ReadLine());

    if (a > b)
    {
        while (a > b)
        {
            Console.WriteLine("Введите подходящее a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите подходящее b");
            b = Convert.ToDouble(Console.ReadLine());
        }
    } 

    Console.WriteLine("Введите число h");
    double h = Convert.ToDouble(Console.ReadLine());

    if (h <= 0 || h > b)
    {
        while (h <= 0 || h > b)
        {
            Console.WriteLine("Введите подходящее h");
            h = Convert.ToDouble(Console.ReadLine());
        }
    }

    int invert_z = 0; 
    int many_t = (int)((b - a) / h) + 1; // Вычисляем количество точек
    double maximus = -10000000000000000;
    double minimus = 10000000000000000;
    double last_y = 0;
    double x = 0;
    double y = 0;
 
Console.WriteLine("|     x    |   y(x)   |");
Console.WriteLine("|----------|----------|");

    for (x = a; x <= b; x += h)
    {
        y = (Math.Cos(x * x) + (Math.Sin(x) * Math.Sin(x)));
        Console.WriteLine($"| {x, 8:F3} | {y, 8:F3} |"); // Мы выставляем ширину "8" и количество знаков после запятой "F3" чтобы табличка была ровная я взял это со Stack overflow
        if (y < minimus)
        {
            minimus = y;
        }
        if (y > maximus)
        {
            maximus = y;
        }
        if ((y > 0 & last_y < 0) || (y < 0 & last_y > 0))
            {
            invert_z++;
            }
        last_y = y;
             
    }
    if (x - h < b - 0.0000001) // костыль с помощью которого я пытался решить проблему с тем что число получалось чуть больше положенного например 5.0000000000002 надеюсь попытка не строго наказуема :)
    {
        y = (Math.Cos(x * x) + (Math.Sin(x) * Math.Sin(x)));
        Console.WriteLine($"| {x,8:F3} | {y,8:F3} |");
    }
    Console.WriteLine("|----------|----------|");
    Console.WriteLine($"max = {maximus:F3} \nmin = {minimus:F3} \nизменение знака = {invert_z} \nточки = {many_t}");
}















































































Console.WriteLine("Введите X");
double x;
while (true)
{
    string x_s = Console.ReadLine();
    if (double.TryParse(x_s, out x))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
Console.WriteLine("Введите Y");
double y;
while (true)
{
    string y_s = Console.ReadLine();
    if (double.TryParse(y_s, out y))
    {
        if (y > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Y должно быть больше 0");
        }
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
Console.WriteLine("Введите скорость");
double v;
while (true)
{
    string v_s = Console.ReadLine();
    if (double.TryParse(v_s, out v))
    {
        if (v > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("V должно быть больше 0");
        }
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
Console.WriteLine("Введите угол");
double a;
while (true)
{
    string a_s = Console.ReadLine();
    if (double.TryParse(a_s, out a))
    {
        if (a > 0 & a <= 360)
        {
            if (y == 0)
            {
                if (a > 0 & a <= 180)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("угол должен быть больше 0 и меньше 180 при высоте 0");
                }
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("угол должен быть больше 0 и меньше или равен 360");
        }
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
double g = 9.81;
double radan = a * Math.PI / 180;
double speedx = v * Math.Cos(radan);
double speedy = v * Math.Sin(radan);
double y_itog = y;
double x_itog = x;
double time = 0;
double t_short = Math.Round(2 * speedy / g, 1);
while (y_itog > 0)
{
    x_itog = x + speedx * time;
    y_itog = y + speedy * time - ((g * Math.Pow(time, 2))/ 2);

    if (y_itog < 0)
    {
        break;
    }
    Console.WriteLine($"T{time:F2} | X{x_itog:F2} | Y{y_itog:F2}");
    time = Math.Round(time + 0.1, 1);
}
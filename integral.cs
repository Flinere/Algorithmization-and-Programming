using System;
using System.Xml.Schema;

class one
{
    static double one_s(double x)
    {
        return 2 * x * x + 3 * x;
    }
    static double HS(double a, double b, double n)
    {
        double h = (b - a) / n;
        double max = 0;

        for (int i = 0; i < n; i++)
        {
            double x_mid = a + i * h ;
            max += one_s(x_mid);   
        }
        return h * max;
        
    }
    static void Main()
    {
        double a;
        while (true)
        {
            Console.Write("Введите a \n");
            string numesr = Console.ReadLine();
            if (double.TryParse(numesr, out a))
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число правильное");
            }
        }
        double b;
        while (true)
        {
            Console.Write("Введите b \n");
            string numesr2 = Console.ReadLine();
            if (double.TryParse(numesr2, out b))
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число правильное");
            }
        }
        double n;
        while (true)
        {
            Console.Write("Введите n \n");
            string numesr3 = Console.ReadLine();
            if (double.TryParse(numesr3, out n))
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число правильное");
            }
        }
        double otvet = HS(a, b, n);
        Console.WriteLine($"ответ: {otvet}");
    
    }
}
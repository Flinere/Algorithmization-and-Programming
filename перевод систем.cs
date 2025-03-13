

Console.WriteLine("Напишите число");
int num;
while (true)
{
    string numesr = Console.ReadLine();
    if (int.TryParse(numesr, out num))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
Console.WriteLine("система счисления с 2 до 10");
int q1;
while (true)
{
    string q1_s = Console.ReadLine();
    if (int.TryParse(q1_s, out q1))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
Console.WriteLine("Введите систему в которую надо перевести с 2 до 10");
int q2;
while (true)
{
    string q2_s = Console.ReadLine();
    if (int.TryParse(q2_s, out q2))
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите число правильное");
    }
}
while (q1 < 2 || q1 > 10)
{
    Console.WriteLine("Введите правильную систему счисления");
    q1 = Convert.ToInt32(Console.ReadLine());
}
while (q2 < 2 || q2 > 10)
{
    Console.WriteLine("Введите правильную систему счисления");
    q2 = Convert.ToInt32(Console.ReadLine());
}
int i = 0;
int otvet = 0;
int otvet2 = 0;
string sekibanki = "";
int otvet3 = 0;
if (q1 < 10)
{
    while (true)
    {
        int seki = num % 10;
        if (seki >= q1)
        {
            Console.WriteLine(seki + " невходит в данную систему исчисления");
            return;
        }

        otvet += seki * (int)Math.Pow(q1, i);
        i++;

        if (num < 10)
        {
            otvet3 = (otvet % q2);
            sekibanki = otvet3.ToString() + sekibanki;

            if (otvet < q2)
            {
                Console.WriteLine("Перевод из " + q1 + " в " + q2 + " выполнен ответ " + sekibanki);
                break;
            }
            otvet = otvet / q2;
        }
        num = num / 10;
    }
}
else if (q1 == 10)
{
    while (true)
    {
        otvet2 = (num % q2);
        sekibanki = otvet2.ToString() + sekibanki;

        if (num < q2)
        {
            Console.WriteLine("Перевод из " + q1 + " в " + q2 + " выполнен ответ " + sekibanki);
            break;
        }
        num = num / q2;
    }
}
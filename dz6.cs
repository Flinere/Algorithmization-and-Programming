Console.WriteLine("Напишите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("система счисления с 2 до 9");
int q1 = Convert.ToInt32(Console.ReadLine());
while (q1 < 2 || q1 > 9)
{
    Console.WriteLine("Введите правильную систему счисления");
            q1 = Convert.ToInt32(Console.ReadLine());
}
int i = 0;
int otvet = 0;
while (true)
{
    int seki = num % 10;
    if (seki >= q1)
    {
        return;
        Console.WriteLine(seki + "невходит в данную систему исчисления");
    }

    otvet += seki * (int)Math.Pow(q1, i);
    i++;

    if (num < 10)
    {
        Console.WriteLine(otvet);
        break;
    }
    num = num / 10;
}
  
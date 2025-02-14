
Console.Write("Игра начинается угадайте число от 1 до 100" + "\n");

Random rnd = new Random();
int top = rnd.Next(1, 100);
int user = Int32.Parse(Console.ReadLine());

if (user >= 1 & user <= 100)
{
    if (user == top) { Console.WriteLine("Правильно"); }
    else { Console.WriteLine("Неправильно осталось 4 попытки"); }
}
else
{
    Console.WriteLine("Неправильно, число слишком большое или маленькое, осталось 4 попытки");
}
user = Int32.Parse(Console.ReadLine());
if (user >= 1 & user <= 100)
{
    if (user == top) { Console.WriteLine("Правильно"); }
    else { Console.WriteLine("Неправильно осталось 3 попытки"); }
}
else
{
    Console.WriteLine("Неправильно, число слишком большое или маленькое, осталось 3 попытки");
}
user = Int32.Parse(Console.ReadLine());
if (user >= 1 & user <= 100)
{
    if (user == top) { Console.WriteLine("Правильно"); }
    else { Console.WriteLine("Неправильно осталось 2 попытки"); }
}
else
{
    Console.WriteLine("Неправильно, число слишком большое или маленькое, осталось 2 попытки");
}
user = Int32.Parse(Console.ReadLine());
if (user >= 1 & user <= 100)
{
    if (user == top) { Console.WriteLine("Правильно"); }
    else { Console.WriteLine("Неправильно осталось 1 попытка"); }
}
else
{
    Console.WriteLine("Неправильно, число слишком большое или маленькое, осталось 1 попытки");
}
user = Int32.Parse(Console.ReadLine());
if (user >= 1 & user <= 100)
{
    if (user == top) { Console.WriteLine("Правильно"); }
    else { Console.WriteLine("Неправильно, вы проиграли это было число " + top); }
}
else
{
    Console.WriteLine("Неправильно, число слишком большое или маленькое, вы проиграли это было число " + top);
}
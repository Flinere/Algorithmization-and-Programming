using System;

while (true)
{
    Console.WriteLine("Введите имя");
    string userFirstName = Console.ReadLine();
    Console.WriteLine("Введите фамилию");
    string userLastName = Console.ReadLine();
    Console.WriteLine("Введите месяц числом");
    int userMonth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите день числом");
    int userData = Convert.ToInt32(Console.ReadLine());
    if ((userData <= 31 && userData >= 1) && (userMonth >= 1 && userMonth <= 12))
    {
        if (userData > 29 && userMonth == 2)
        {
            Console.WriteLine("Неправленое количество дней или месяцев");
            break;
        }
        else if ((userMonth == 6 && (userData >= 22 && userData <= 30)) || (userMonth == 7 && (userData <= 22)))
        {
            Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: rak");
            break;
        }
        else if (userMonth <= 6)
        {
            if ((userMonth == 6 && (userData <= 21)) || (userMonth == 5 && (userData >= 21 && userData <= 31)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: bliznec");
                break;
            }
            else if ((userMonth == 5 && (userData <= 20)) || (userMonth == 4 && (userData >= 21 && userData <= 30)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: telec");
                break;
            }
            else if ((userMonth == 4 && (userData <= 20)) || (userMonth == 3 && (userData >= 21 && userData <= 31)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: oven");
                break;
            }
            else if ((userMonth == 3 && (userData <= 20)) || (userMonth == 2 && (userData >= 19 && userData <= 29)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: riba");
                break;
            }
            else if ((userMonth == 2 && (userData <= 18)) || (userMonth == 1 && (userData >= 21 && userData <= 31)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: vodoley");
                break;
            }
            else if (userMonth == 1 && (userData <= 20))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: kozerog");
                break;
            }
        }
        else if (userMonth >= 7)
        {
            if ((userMonth == 8 && (userData <= 22)) || (userMonth == 7 && (userData >= 23 && userData <= 31)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: lev");
                break;
            }
            else if ((userMonth == 9 && (userData <= 23)) || (userMonth == 8 && (userData >= 23 && userData <= 31)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: deva");
                break;
            }
            else if ((userMonth == 10 && (userData <= 23)) || (userMonth == 9 && (userData >= 24 && userData <= 30)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: vesi");
                break;
            }
            else if ((userMonth == 11 && (userData <= 22)) || (userMonth == 10 && (userData >= 24 && userData <= 31)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: scorpion");
                break;
            }
            else if ((userMonth == 12 && (userData <= 21)) || (userMonth == 11 && (userData >= 23 && userData <= 30)))
            {
                Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: strelec");
                break;
            }
        }
        else
        {
            Console.WriteLine("Неправленое количество дней или месяцев");
        }
    }
}

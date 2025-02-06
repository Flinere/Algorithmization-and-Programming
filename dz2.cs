using System;

while (1 != 10)
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
        switch(userMonth)
        {
            case (1):
            {
                if (userData >= 20 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: vodoley");
                    }
                else if (userData <= 19)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: kozerog");
                    }
                    break;
            }
            case (2):
                {
                    if (userData >= 19 && userData <= 29)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: riba");
                    }
                    else if (userData <= 18)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: vodoley");            
                    }
                    else
                    {
                        Console.WriteLine("Неправленое количество дней в феврале");
                    }
                    break;
                }
            case (3):
                {
                    if (userData >= 21 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: oven");
                    }
                    else if (userData <= 20)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: riba");
                    }
                    break;
                }
            case (4):
                {
                     if (userData >= 20 && userData <= 30)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: telec");
                    }
                    else if (userData <= 19)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: oven");
                    }
                    break;
                }
            case (5):
                {
                    if (userData >= 21 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: bliznec");
                    }
                    else if (userData <= 20)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: telec");
                    }
                    break;
                }
            case (6):
                {
                    if (userData <= 20)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: bliznec");
                    }
                    else if (userData >= 21 && userData <= 30)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: rak");
                    }
                    break;
                }
            case (7):
                {
                    if (userData >= 1 && userData <= 22)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: rak");
                    }
                    else if (userData >= 23 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: lev");
                    }
                    break;
                }
            case (8):
                {
                    if (userData <= 22)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: lev");
                    }
                    else if (userData >= 23 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: deva");
                    }
                    break;
                }
            case (9):
                {
                    if (userData <= 22)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: deva");
                    }
                    else if (userData >= 23 && userData <= 30)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: vesi");
                    }
                    break;
                }
            case (10):
                {
                    if (userData <= 22)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: vesi");
                    }
                    else if (userData >= 23 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: scorpion");
                    }
                    break;
                }
            case (11):
                {
                    if (userData <= 22)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: scorpion");
                    }
                    else if (userData >= 23 && userData <= 30)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: kozerog");
                    }
                    break;
                }
            case (12):
                {
                    if (userData <= 22)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: strelec");
                    }
                    else if (userData >= 23 && userData <= 31)
                    {
                        Console.WriteLine("Ваше имя: " + userFirstName + "\n" + "Ваша фамилия: " + userLastName + "\n" + "Знак зодиака: kozerog");
                    }
                    break;
                }
        }
     }
    else
    {
        Console.WriteLine("Неправленое количество дней или месяцев");
    }
    
}

        


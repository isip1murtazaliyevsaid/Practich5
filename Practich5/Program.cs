using dsgs;

int ar = 0;
string str = " ";

void Menu()
{

    Console.WriteLine("  Заказ тортов");
    Console.WriteLine("  Форма торта");
    Console.WriteLine("  Размер торта");
    Console.WriteLine("  Вкус коржей");
    Console.WriteLine("  Количество коржей");
    Console.WriteLine("  Глазурь");
    Console.WriteLine("  Декор");
    Console.WriteLine("  Конец заказа");
    Console.WriteLine("  ");
    Console.WriteLine("  Цена: " + ar);
    Console.WriteLine("  Ваш торт: " + str);
}

void in1(int pos)
{

    if (pos == 1)
    {

        ConsoleKeyInfo key;


        Console.Clear();
        Console.WriteLine("  Круг: 300");
        Console.WriteLine("  Квадрат: 400");
        Console.WriteLine("  Звездочка: 600");
        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        int po = strelka.strelka();

        if (po == 0)
        {
            str = str + "Круг ";
            ar = ar + 300;
        }
        else if (po == 1)
        {
            str = str + "Квадрат ";
            ar = ar + 400;
        }

        else if (po == 2)
        {
            str = str + "Звездочка ";
            ar = ar + 600;
        }
    }
    else if (pos == 2)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  20 см: 1000");
        Console.WriteLine("  30 см: 1500");
        Console.WriteLine("  40 см: 2000");

        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        int po = strelka.strelka();

        if (po == 0)
        {
            str = str + "20 см ";
            ar = ar + 1000;
        }
        else if (po == 1)
        {
            str = str + "30 см ";
            ar = ar + 1500;
        }

        else if (po == 2)
        {
            str = str + "40 см ";
            ar = ar + 2000;
        }
    }
    else if (pos == 3)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Шоколадный: 150");
        Console.WriteLine("  Клубничный: 200");
        Console.WriteLine("  Ананасовый: 300");
        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        int po = strelka.strelka();

        if (po == 0)
        {
            str = str + "Шоколадный ";
            ar = ar + 150;
        }
        else if (po == 1)
        {
            str = str + "Клубничный ";
            ar = ar + 200;
        }

        else if (po == 2)
        {
            str = str + "Ананасовый ";
            ar = ar + 300;
        }
    }
    else if (pos == 4)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  2 коржа: 300");
        Console.WriteLine("  3 коржа: 450");
        Console.WriteLine("  4 коржа: 600");
        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        int po = strelka.strelka();

        if (po == 0)
        {
            str = str + "2 коржа ";
            ar = ar + 300;
        }
        else if (po == 1)
        {
            str = str + "3 коржа ";
            ar = ar + 450;
        }

        else if (po == 2)
        {
            str = str + "4 коржа ";
            ar = ar + 600;
        }
    }
    else if (pos == 5)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Шоколадная: 150");
        Console.WriteLine("  Ванильная: 100");
        Console.WriteLine("  Фруктовая: 200");
        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        int po = strelka.strelka();
        if (po == 0)
        {
            str = str + "Шоколадная ";
            ar = ar + 150;
        }
        else if (po == 1)
        {
            str = str + "Ванильная ";
            ar = ar + 100;
        }

        else if (po == 2)
        {
            str = str + "Фруктовая ";
            ar = ar + 200;
        }
    }
    else if (pos == 6)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("  Ягоды: 500");
        Console.WriteLine("  Безе: 400");
        Console.WriteLine("  Крем: 300");
        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        int po = strelka.strelka();
        if (po == 0)
        {
            str = str + "Ягоды ";
            ar = ar + 500;
        }
        else if (po == 1)
        {
            str = str + "Безе ";
            ar = ar + 400;
        }

        else if (po == 2)
        {
            str = str + "Крем ";
            ar = ar + 300;
        }
    }
    else if (pos == 7)
    {
        ConsoleKeyInfo key;
        Console.Clear();
        Console.WriteLine("Спасибо за заказ!");
        string txt = "\nВаш заказ: " + str;
        string txxt = "\nЦена: " + ar;
        File.AppendAllText("C:\\Users\\akons\\Desktop\\История заказов.txt", "\n" + txt);
        File.AppendAllText("C:\\Users\\akons\\Desktop\\История заказов.txt", "\n" + txxt);
        key = Console.ReadKey();
        Strelka strelka = new Strelka();
        strelka.strelka();
        if (key.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            str = " ";
            ar = 0;

        }
    }
}


void k1()
{
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    while (key.Key != ConsoleKey.Escape)
    {

        Console.Clear();

        Menu();
        Strelka strelka = new Strelka();
        int pos = strelka.strelka();

        in1(pos);
        Menu();
    }
}
k1();
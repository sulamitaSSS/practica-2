
Console.WriteLine("выберите программу:\r\n" +
    "1.Угадай число\"\r\n" +
    "2.Таблица умножения\r\n" +
    "3.Вывод делителей числа \r\n ");

int Operation = Convert.ToInt32(Console.ReadLine());

if (Operation == 1)
{
    ygadai();
}

else if (Operation == 2)
{
    tabl();
}
else if (Operation == 3)
{
    Deliteli();
}
    static void Deliteli()
{

    Console.Write("Введите число ");
    int a = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= a; i++)
        if (a % i == 0)
            Console.WriteLine("{0} делится на {1}", a, i);
}
static void ygadai ()
{
        Random rnd = new Random();
        int a = rnd.Next(0, 101);
        while (true)
        {
            Console.WriteLine("Введите число");
            int b = int.Parse(Console.ReadLine());
            if (b == a)
            {
                Console.WriteLine("Победа!");
                break;
            }
            else if (b > a)
            {
                Console.WriteLine("Введите число меньше");
            }
            else

            {
                Console.WriteLine("Введите число больше");
            }
        }
    
}

static void tabl()
{
    int[,] tablica;
    tablica = new int[11, 11];
    for (int ryad = 1; ryad <= 10; ryad++)
        for (int mesto = 1; mesto < 11; mesto++)
            tablica[ryad, mesto] = ryad * mesto;
    for (int ryad = 1; ryad <= 10; ryad++)
    {
        for (int mesto = 1; mesto <= 10; mesto++)
        {
            Console.Write(tablica[ryad, mesto] + "\t");
        }
        Console.WriteLine();
    }
}
static void Menu()
{

    Console.WriteLine(" выберите октаву F6, F7 , F8");
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.F6)
    {
        oktavasix();
    }
    else if (key.Key == ConsoleKey.F7)
    {
        oktavaseven();
    }
    else if (key.Key == ConsoleKey.F8)
    {
        oktavaeight();
    }
}

static void oktavasix()
{
    int[] six = new[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    Sound(six);
}
static void Sound(int[] alloctaves)
{
    ConsoleKeyInfo t = Console.ReadKey();
    while (t.Key != ConsoleKey.Enter)
    {
        switch (t.Key)
        {
            case ConsoleKey.A:
                Console.Beep(alloctaves[0], 500);
                Console.Clear();
                break;
            case ConsoleKey.B:
                Console.Beep(alloctaves[1], 500);
                Console.Clear();
                break;
            case ConsoleKey.C:
                Console.Beep(alloctaves[2], 500);
                Console.Clear();
                break;
            case ConsoleKey.D:
                Console.Beep(alloctaves[3], 500);
                Console.Clear();
                break;
            case ConsoleKey.E:
                Console.Beep(alloctaves[4], 500);
                Console.Clear();
                break;
            case ConsoleKey.F:
                Console.Beep(alloctaves[5], 500);
                break;
            case ConsoleKey.G:
                Console.Beep(alloctaves[6], 500);
                Console.Clear();
                break;
            case ConsoleKey.H:
                Console.Beep(alloctaves[7], 500);
                Console.Clear();
                break;
            case ConsoleKey.I:
                Console.Beep(alloctaves[8], 500);
                Console.Clear();
                break;
            case ConsoleKey.K:
                Console.Beep(alloctaves[9], 500);
                Console.Clear();
                break;
            case ConsoleKey.L:
                Console.Beep(alloctaves[10], 500);
                Console.Clear();
                break;
            case ConsoleKey.M:
                Console.Beep(alloctaves[11], 500);
                Console.Clear();
                break;
            case ConsoleKey.Enter:
                Menu();
                break;


        }

    }

}
static void oktavaseven()
{
    int[] seven = new[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
    sound(seven);
}
static void sound(int[] alloctaves)
{
    ConsoleKeyInfo t = Console.ReadKey();
    while (t.Key != ConsoleKey.Enter)
    {
        switch (t.Key)
        {
            case ConsoleKey.A:
                Console.Beep(alloctaves[0], 500);
                Console.Clear();
                break;
            case ConsoleKey.B:
                Console.Beep(alloctaves[1], 500);
                Console.Clear();
                break;
            case ConsoleKey.C:
                Console.Beep(alloctaves[2], 500);
                Console.Clear();
                break;
            case ConsoleKey.D:
                Console.Beep(alloctaves[3], 500);
                Console.Clear();
                break;
            case ConsoleKey.E:
                Console.Beep(alloctaves[4], 500);
                Console.Clear();
                break;
            case ConsoleKey.F:
                Console.Beep(alloctaves[5], 500);
                break;
            case ConsoleKey.G:
                Console.Beep(alloctaves[6], 500);
                Console.Clear();
                break;
            case ConsoleKey.H:
                Console.Beep(alloctaves[7], 500);
                Console.Clear();
                break;
            case ConsoleKey.I:
                Console.Beep(alloctaves[8], 500);
                Console.Clear();
                break;
            case ConsoleKey.K:
                Console.Beep(alloctaves[9], 500);
                Console.Clear();
                break;
            case ConsoleKey.L:
                Console.Beep(alloctaves[10], 500);
                Console.Clear();
                break;
            case ConsoleKey.M:
                Console.Beep(alloctaves[11], 500);
                Console.Clear();
                break;

        }
    }
}
static void oktavaeight()
{
    int[] eight = new[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
    so(eight);
}
static void so(int[] alloctaves)
{
    ConsoleKeyInfo t = Console.ReadKey();
    while (t.Key != ConsoleKey.Enter)
    {
        switch (t.Key)
        {
            case ConsoleKey.A:
                Console.Beep(alloctaves[0], 500);
                Console.Clear();
                break;
            case ConsoleKey.B:
                Console.Beep(alloctaves[1], 500);
                Console.Clear();
                break;
            case ConsoleKey.C:
                Console.Beep(alloctaves[2], 500);
                Console.Clear();
                break;
            case ConsoleKey.D:
                Console.Beep(alloctaves[3], 500);
                Console.Clear();
                break;
            case ConsoleKey.E:
                Console.Beep(alloctaves[4], 500);
                Console.Clear();
                break;
            case ConsoleKey.F:
                Console.Beep(alloctaves[5], 500);
                break;
            case ConsoleKey.G:
                Console.Beep(alloctaves[6], 500);
                Console.Clear();
                break;
            case ConsoleKey.H:
                Console.Beep(alloctaves[7], 500);
                Console.Clear();
                break;
            case ConsoleKey.I:
                Console.Beep(alloctaves[8], 500);
                Console.Clear();
                break;
            case ConsoleKey.K:
                Console.Beep(alloctaves[9], 500);
                Console.Clear();
                break;
            case ConsoleKey.L:
                Console.Beep(alloctaves[10], 500);
                Console.Clear();
                break;
            case ConsoleKey.M:
                Console.Beep(alloctaves[11], 500);
                Console.Clear();
                break;

        }
    }
}

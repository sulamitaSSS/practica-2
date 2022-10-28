/*Console.WriteLine("jkkj");
Console.WriteLine("jkkj");
Console.WriteLine("jkkj");
Console.WriteLine("jkkj");
Console.WriteLine("jkkj");
Console.Clear(); // удаляет все консоль врайт
Console.SetCursorPosition(50, 10); //  отступ от левого края и от вверхнего края 
Console.WriteLine("bbbffffffffffff");*/

int position = 1;
ConsoleKeyInfo key = Console.ReadKey();
while (key.Key != ConsoleKey.Enter)
{
    /*Console.SetCursorPosition(0, position);
    Console.WriteLine("->");

    Console.SetCursorPosition(0, 1);
    Console.WriteLine("->");*/

    
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--; // position = position -1
        /*Console.SetCursorPosition(0, 0);
        Console.WriteLine("->");*/
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        position++; //position = position +1 
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("->");
    }
    Console.Clear();
    Console.WriteLine(" како цвет нрав?");
    Console.WriteLine("   1. red");
    Console.WriteLine("   2. yellow");
    Console.WriteLine("   3. blue");
    Console.WriteLine("   4. green");
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");

    key = Console.ReadKey();

}
if (position == 3)
{
    Console.WriteLine(" это голубой");
}
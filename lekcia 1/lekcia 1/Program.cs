/*int[] massive = new int[] { -1, 8, 5, -2, 0 };

*//*int min = massive.Last();
Console.WriteLine(min);*//*

int[] onlyPossitive = massive.Where(item => item >= 0).ToArray();

int first = massive.First(item => item >= 0);



int[] sorted = massive.OrderBy(item => item).ToArray();

*/



/*int[] omlyPositive;
foreach (int item in massive )
{
    if (item >=0)
    {
      Console.WriteLine(item);
    }
}*/

// лекция 7
ConsoleKeyInfo clavisha = Console.ReadKey();

if (clavisha.Modifiers.HasFlag(ConsoleModifiers.Alt) &&
    clavisha.Modifiers.HasFlag(ConsoleModifiers.Control) && 
    clavisha.Key == ConsoleKey.F6)
{
    Console.WriteLine("это ctrl + Alt + f6");
}

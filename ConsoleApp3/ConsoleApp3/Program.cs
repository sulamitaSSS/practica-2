/*string[] garderobe = new string[5]
{"куртка", "-", "пух", "-", "джинс"};

garderobe[3] = "пальто";

Console.WriteLine(garderobe[3]);
 for (int i = 0; i < garderobe.Length; i++)
{
    Console.WriteLine(garderobe[i]);
}
foreach (string kurtka in garderobe)
{
    Console.WriteLine(kurtka);
}
*/
/*List<string> garderobList = new List<string>()
{ "куртка", "-", "пуховик","джинсовка", "-"};

garderobList.Add("-");
garderobList.Add("ветровка");

garderobList.RemoveAt(4);
garderobList.Remove("-");*/




string[] ryadok = new string[5]
{ "куртка", "-", "пуховик","джинсовка", "-"};

String[,] garderobe = new string[3, 5]
{
    { "куртка", "-", "пуховик ","джинсовка", "-"},
    { "куртка", "-", "пуховик ","джинсовка", "-"},
    { "куртка", "-", "пуховик ","джинсовка", "-"}
};
Console.WriteLine(garderobe[0, 5]);

foreach (string kertka in garderobe)
{
    Console.WriteLine(kertka);
}
for (int ryad = 0; ryad < 3; ryad++)
{
    for (int mesto = 0; mesto < 5; mesto++)
    {
        Console.Write(garderobe[ryad, mesto] + "\t");
    }
}
Console.WriteLine();
{ 
for (int ryad = 0; ryad < garderobe.GetLength(0); ryad++)
    {
        for (int mesto = 0; mesto < garderobe.GetLength(1); mesto++)
        {
            Console.Write(garderobe[ryad, mesto] + "\t");
        }
    }
}
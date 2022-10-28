/*string text = File.ReadAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\v.txt");
Console.WriteLine(text);*/

/*string text = "Текст маолтмомолавыит";
*//*File.WriteAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\v.txt", text);*//*
File.AppendAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\v.txt", text);
*/
if (File.Exists("C:\\Users\\User\\OneDrive\\Рабочий стол\\a.txt")) 
{
    string text = File.ReadAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\a.txt");
    Console.WriteLine(text);
}

 else
{
    File.Create("C:\\Users\\User\\OneDrive\\Рабочий стол\\a.txt");
}

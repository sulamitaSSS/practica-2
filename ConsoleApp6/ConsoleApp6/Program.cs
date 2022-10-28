namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            string myText = "hdkssdjklhdj";
            Output(myText);
            Output("1234", 5);
        }
        static void Output(string text, int amount = 1)
        {
            for (int i = 0; i < amount; i++)    
            Console.WriteLine(text);
        }
    }

}
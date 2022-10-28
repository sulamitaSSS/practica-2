// тип данных название = new тип данных


using пара_14._10;

pizaniger margarita = new pizaniger ();
margarita.Nane = "margarita";
margarita.Diametr = 28;
margarita.bortiv = " syr";
margarita.testo = "tonkoe";
margarita.ostrota = 3;

pizaniger gavai = new pizaniger ();
gavai.Nane = "havaii";
gavai.Diametr = 33;
gavai.testo = "tonkoe";

Console.WriteLine (gavai);
Console.WriteLine(gavai.Nane = "havaii");
Console.WriteLine(gavai.Diametr = 33);
Console.WriteLine(gavai.testo = "tonkoe");

List<pizaniger> menu = new List<pizaniger> ();
menu.Add (margarita);
menu.Add (gavai);

foreach (pizaniger pizaniger in menu) 
{
    Console.WriteLine(pizaniger.Nane);
    Console.WriteLine(pizaniger.Diametr);
    Console.WriteLine(pizaniger.testo);
    Console.WriteLine(pizaniger.bortiv);
    Console.WriteLine(pizaniger.ostrota);
}
DateTime now = DateTime.Now;
Console.WriteLine(DateTime now);
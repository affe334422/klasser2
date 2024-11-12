using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using klasser2;

if(1 == 2){
bil b = new bil();
b.Tillverkare = "Saab";
b.Model = "Saab 9000 Aero";
b.År = 1984;
b.Vikt = 1365;

bil p = new bil();
p.Tillverkare = "Volvo";
p.Model = "Volvo 850 T-röd";
p.År = 1996;
p.Vikt = 1590;

testför2 a1 = new testför2("Volvo", "Volvo 850 T-röd", 1996, 1590);

Console.WriteLine(a1.Model);
}

if(1 == 2){
List<testför2> bilarlista1 = new List<testför2>();

testför2 a = new testför2("Volvo", "Volvo 850 T-röd", 1996, 1590);
bilarlista1.Add(a);
bilarlista1.Add(new testför2("bla", "la", 10, 20));

foreach(testför2 element in bilarlista1){
    Console.WriteLine(element.Tillverkare);   
    Console.WriteLine(element.Model);
    Console.WriteLine(element.År);
    Console.WriteLine(element.Vikt);
}
}

List<testför2> bilarlista = new List<testför2>();

string blabla = "ja";

do{
    string a1;
    string a2;
    int a3;
    int a4;

    Console.WriteLine("Vi kommer fråga dig om bilens tillverkare, model, året den va gjord och dens vikt");
    Console.WriteLine("Vem tillverkade bilen? " );
    a1 = Console.ReadLine();
    Console.WriteLine("Vad är det för model? ");
    a2 = Console.ReadLine();
    while (true) {
        Console.WriteLine("När skapades bilen? ");
        try
        {
            a3 = int.Parse(Console.ReadLine());
            break;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Du skulle skriva ett numer");
        }
    }

    while (true) {
        Console.WriteLine("Vad väger den? ");
        try
        {
            a4 = int.Parse(Console.ReadLine());
            break;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Du skulle skriva ett numer");
        }
    }
    

    bilarlista.Add(new testför2(a1,a2,a3,a4));

    Console.WriteLine("vill du lägga till mer bilar?");
    blabla = Console.ReadLine();
}while(blabla == "ja" || blabla == "JA" || blabla == "Ja");
int bb =1;
foreach(testför2 element in bilarlista){
    Console.WriteLine("bil numer " + bb);
    Console.WriteLine(element.Tillverkare);   
    Console.WriteLine(element.Model);
    Console.WriteLine(element.År);
    Console.WriteLine(element.Vikt);
    Console.WriteLine();
    bb++;
}
    
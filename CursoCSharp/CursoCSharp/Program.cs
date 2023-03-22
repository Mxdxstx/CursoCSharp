//***   Estándares de C#   ***
    /*
    *Los nombres de las clases se capitalizan por cada palabra
    *Los nombres de las interfaces comienzan con I
    *Los nombres de los métodos se capitalizan a partir de la primer palabra
    *Los métodos booleanos comienzan con "Is" 
    *Los atributos privados comienzan con "_" y se capitaliza a partir de la segunda palabra
    *
    */



using CursoCSharp;

Console.WriteLine("Curso de C#");
Console.WriteLine("===========");

try
{
    Console.WriteLine(new Date(2011, 11, 11));
    Console.WriteLine(new Date(2012, 12, 5));
    Console.WriteLine(new Date(1999, 12, 31));
    Console.WriteLine(new Date(2001, 3, 1));
    Console.WriteLine(new Date(2100, 2, 29));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}


Console.ReadLine();
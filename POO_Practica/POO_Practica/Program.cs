using POO_Practica;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Programacion orienrada a objetos !");
Console.WriteLine("==================================");

//instanciar un objeto de la clase year

try
{
    Console.WriteLine(new Date(2022, 2, 29));
    Console.WriteLine(new Date(2022, 12, 45));
    Console.WriteLine(new Date(1986, 11, 31));
    Console.WriteLine("==================================");
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    System.Console.WriteLine("Ingrese los kilometros conducidos: ");
    var km = Convert.ToDecimal(Console.ReadLine());
    System.Console.WriteLine("Ingrese los litros usados: ");
    var li = Convert.ToDecimal(Console.ReadLine());
    System.Console.WriteLine("El Consumo realizado fue de "+ km/li +" kilometros por litro");
}
catch (System.FormatException e)
{
    System.Console.WriteLine("error: " + e.Message);
}
catch(System.OverflowException e)
{
    System.Console.WriteLine("error: " + e.Message);
}   
catch (System.DivideByZeroException e)
{
    System.Console.WriteLine("error"+ e.Message);
}
catch (Exception)
{
    Console.WriteLine("error: debe ingresar numeros positivos");
}
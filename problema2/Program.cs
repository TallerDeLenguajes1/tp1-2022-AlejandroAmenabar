// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    System.Console.WriteLine("Ingrese el dividendo: ");
    
    var n1 = Convert.ToDecimal(Console.ReadLine());
    System.Console.WriteLine("Ingrese el divisor: ");
    var n2 = Convert.ToDecimal(Console.ReadLine());
    System.Console.WriteLine("El dividendo es "+n1+" y el divisor: "+ n2);
    System.Console.WriteLine("El resultado es: "+ n1/n2);
}
catch (System.DivideByZeroException e)
{
    System.Console.WriteLine("error"+ e.Message);
}
catch (System.FormatException e)
{
    System.Console.WriteLine("error: " + e.Message);
}
catch(System.OverflowException e)
{
    System.Console.WriteLine("error: " + e.Message);
}   

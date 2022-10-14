// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


try
{
    System.Console.WriteLine("Ingrese un numero entero: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("El numero ingresado es: "+n1+" y su cuadrado es: "+ System.Math.Pow(n1,2));
}
catch (System.FormatException e)
{
    System.Console.WriteLine("error: " + e.Message);
    throw; //debido al throw considera que la excepcion no esta manejada y por eso muestra el "unhandled error
}
catch(System.OverflowException e)
{
    System.Console.WriteLine("error: " + e.Message);
}   
catch(System.Exception e)
{
    System.Console.WriteLine("error ingrese un numero valido");
}

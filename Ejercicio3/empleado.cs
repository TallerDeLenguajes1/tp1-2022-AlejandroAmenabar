
class empleado
{
    private string Nombre;
    private string Direccion;
    private DateOnly fechaIngreso;
    private DateTime fechaNacimiento;
    private float sueldoBasico;
    private int antiguedad;
    private static float descuento = sueldoBasico - (0.15*sueldoBasico);
    private static int adicional = (0.01*sueldoBasico)*antiguedad;
    private enum EstadoCivilItem{Solero,Casado,Divorciado,Viudo};
    private int hijos;
    
    private DateTime fechaDivorcio;
    private bool estudioUniversidad;
    private string titulo;
    private string universidad;
    public int Antiguedad()
    {
        var today = DateTime.today;
        var antiguedad = today.Year - fechaIngreso.Year;
        return antiguedad;
    }

    public int edad(){
        var.today = DateTime.today;
        age = today.Year - fechaNacimiento.Year;
        return age;
    }

    public float Salario(){
        
        var salario = sueldoBasico + adicional - descuento;
    }

}
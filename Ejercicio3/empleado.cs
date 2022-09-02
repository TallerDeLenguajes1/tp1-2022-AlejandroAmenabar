
class empleado
{
    public string? Nombre;
    public string? Direccion;
    public DateTime fechaNacimiento;
    public enum EstadoCivilItem{Solero,Casado,Divorciado,Viudo};
    public DateTime fechaDivorcio;
    public DateTime fechaIngreso;
    public double sueldoBasico;
    public int Hijos;
    public bool estudioUniversidad;
    public string? titulo;
    public string? universidad;

    public empleado(string nom, DateTime fecNaci, DateTime fecIngr, double salario, int hijos){
        Nombre = nom;
        fechaNacimiento = fecNaci;
        fechaIngreso = fecIngr;
        sueldoBasico = salario;
        Hijos = hijos;
    }
    public int Antiguedad()
    {
        var today = DateTime.Today;
        var antiguedad = today.Year - fechaIngreso.Year;
        return antiguedad;
    }

    public int edad(){
        var today = DateTime.Today;
        int age = today.Year - fechaNacimiento.Year;
        return age;
    }

    public double Descuento(){
        return (sueldoBasico*0.15);
    }
    public double Adicional(){
        if(Antiguedad()>20) return 0.25*sueldoBasico;//25% del sueldo basico
        return 0.01*Antiguedad()*sueldoBasico;//1% del sueldo basico
    }
    public double Salario(){
        
        var salario = sueldoBasico + Adicional() - Descuento();
        return salario;
    }

}
public class Cuadrado : Figura
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        Nombre = "Cuadrado";
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }


}

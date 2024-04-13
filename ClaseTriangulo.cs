public class Triangulo : Figura
{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

    public Triangulo(double lado1, double lado2, double lado3)
    {
        Nombre = "Triangulo";
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public override double CalcularArea()
    {
        double semiperimetro = (Lado1 + Lado2 + Lado3) / 2;
        return Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * (semiperimetro - Lado2) * (semiperimetro - Lado3));
    }

    public override double CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }

}


public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Nombre = "Circulo";
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }

}

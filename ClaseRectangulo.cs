public class Rectangulo : Figura
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largo, double ancho)
    {
        Nombre = "Rectangulo";
        Largo = largo;
        Ancho = ancho;
    }

    public override double CalcularArea()
    {
        return Largo * Ancho;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (Largo + Ancho);
    }

}

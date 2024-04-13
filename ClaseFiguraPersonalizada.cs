public class FiguraPersonalizada : Figura
{
    public double[] Lados { get; set; }

    public FiguraPersonalizada(double[] lados)
    {
        Nombre = "Figura Personalizada";
        Lados = lados;
    }

    public override double CalcularArea()
    {
        return 0;
    }

    public override double CalcularPerimetro()
    {
        double perimetro = 0;
        foreach (double lado in Lados)
        {
            perimetro += lado;
        }
        return perimetro;
    }
}

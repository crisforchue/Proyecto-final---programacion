public abstract class Figura
{
    public string Nombre { get; set; }

    public Figura()
    {
        Nombre = string.Empty;
    }

    public abstract double CalcularArea();

    public abstract double CalcularPerimetro();

}

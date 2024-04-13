class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el lado del cuadrado:");
        double ladoCuadrado = double.Parse(Console.ReadLine());
        Cuadrado cuadrado = new Cuadrado(ladoCuadrado);
        Console.WriteLine($"Area del {cuadrado.Nombre}: {cuadrado.CalcularArea()} cm^2");
        Console.WriteLine($"Perimetro del {cuadrado.Nombre}: {cuadrado.CalcularPerimetro()} cm");

        Console.WriteLine("Ingrese el radio del circulo:");
        double radioCirculo = double.Parse(Console.ReadLine());
        Circulo circulo = new Circulo(radioCirculo);
        Console.WriteLine($"Area del {circulo.Nombre}: {circulo.CalcularArea()} cm^2");
        Console.WriteLine($"Perimetro del {circulo.Nombre}: {circulo.CalcularPerimetro()} cm");

        Console.WriteLine("Ingrese el largo y el ancho del rectangulo:");
        double largoRectangulo = double.Parse(Console.ReadLine());
        double anchoRectangulo = double.Parse(Console.ReadLine());
        Rectangulo rectangulo = new Rectangulo(largoRectangulo, anchoRectangulo);
        Console.WriteLine($"Area del {rectangulo.Nombre}: {rectangulo.CalcularArea()} cm^2");
        Console.WriteLine($"Perimetro del {rectangulo.Nombre}: {rectangulo.CalcularPerimetro()} cm");

        Console.WriteLine("Ingrese el primer lado del triangulo:");
        double lado1Triangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado del triangulo:");
        double lado2Triangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer lado del triangulo:");
        double lado3Triangulo = double.Parse(Console.ReadLine());
        Triangulo triangulo = new Triangulo(lado1Triangulo, lado2Triangulo, lado3Triangulo);
        Console.WriteLine($"Area del {triangulo.Nombre}: {triangulo.CalcularArea()} cm^2");
        Console.WriteLine($"Perimetro del {triangulo.Nombre}: {triangulo.CalcularPerimetro()} cm");


        Console.WriteLine("Ingrese el número de lados de la figura personalizada:");
        int numeroLados = int.Parse(Console.ReadLine());
        double[] lados = new double[numeroLados];
        for (int i = 0; i < numeroLados; i++)
        {
            Console.WriteLine($"Ingrese el largo del lado {i+1}:");
            lados[i] = double.Parse(Console.ReadLine());
        }
        FiguraPersonalizada figuraPersonalizada = new FiguraPersonalizada(lados);
        Console.WriteLine($"Perimetro de la {figuraPersonalizada.Nombre}: {figuraPersonalizada.CalcularPerimetro()} cm");
    }
}



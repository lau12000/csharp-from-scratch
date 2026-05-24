var circ = new Circulo();

circ.Radio = 20;
var result_area = circ.Area();
var result_perimetro = circ.Perimetro();

Console.WriteLine($"El area del circulo es: {result_area}");
Console.WriteLine($"El perimetro del circulo es: {result_perimetro}");
Console.WriteLine($"El nuevo radio es : {circ.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}
try
{
    Console.WriteLine("Número a dividir:");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Número divisor:");
    double d = double.Parse(Console.ReadLine());
    if (d == 0)
    {
        throw new DivideByZeroException();
    }

    Console.WriteLine($"El resultado de la división es:  {(n / d)}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: No se puede dividir por cero.");
}
catch (Exception)
{
    Console.WriteLine($"Error inesperado.");
}
//abstract class Figura
//{
//    public abstract double Area();
//    public abstract double Perimetro();
//}

interface IExtraCalculations
{
    public double Add10();
}
interface IFigura
{
    public double Area();
    public double Perimetro();
}
class Circulo : IFigura, IExtraCalculations
{
    public double Radio { get; set; }
    public double Area() => Math.PI * Radio * Radio;
    public double Perimetro() => 2 * Math.PI * Radio;

    public double Add10() => Radio + 10;
}


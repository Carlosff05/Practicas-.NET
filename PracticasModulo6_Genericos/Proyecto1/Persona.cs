namespace Proyecto1;

public class Persona : IPersona<double>
{
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public double Peso { get; set; }
    public double Altura { get; set; }
    public void MostrarDatosFisicos()
    {
        Console.WriteLine($"{Nombre} pesa {Peso} kilos y mide {Altura} metros");
    }

    public Persona() {}

    public Persona(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    override public string ToString()
    {
        return Nombre + " " + Apellido;
    }
}
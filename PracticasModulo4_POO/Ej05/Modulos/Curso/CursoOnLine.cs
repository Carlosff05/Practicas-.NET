using Ej05.Modulos.Alumno;

namespace Ej05;

public class CursoOnLine : Curso
{
    public CursoOnLine(string titulo, double precio, int horas, string url) : base(titulo, precio, horas, new Alumno[100])
    {
        Url = url;
    }

    public string Url
    {
        get => url;
        set
        {
            
            if (string.IsNullOrEmpty(value.Trim()))
            {
                Console.WriteLine("La URL no puede estar vacia, asignada URL por defecto");
                url = "URL por defecto";
            }
            else
            {
                url = value;
            }
        }

    }

    private string url;

    override public void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Url: {Url}");
    }

    public override double CalcularPrecio()
    {
        return Precio;
    }
}
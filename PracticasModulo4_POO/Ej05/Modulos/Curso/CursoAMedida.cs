using Ej05.Modulos.Alumno;

namespace Ej05;

public class CursoAMedida : Curso
{
    public CursoAMedida(string titulo, double precio, int horas, string cliente) 
        : base(titulo, precio, horas, new Alumno[100])
    {
        this.cliente = cliente;
    }

    public string Cliente
    {
        get => cliente;
        set
        {
            
            if (string.IsNullOrEmpty(value.Trim()))
            {
                Console.WriteLine("El cliente no puede estar vacio, asignado cliente por defecto");
                cliente = "Cliente por defecto";
            }
            else
            {
                cliente = value;
            }
        }

    }

    private string cliente;


    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Cliente: {Cliente}");
    }

    public override double CalcularPrecio()
    {
        if (Alumnos.Length > 50)
        {
            Precio *= 0.6;
        }
        else if (Alumnos.Length > 25)
        {
            Precio *= 0.8;
        }
        
        return Precio;
    }
}
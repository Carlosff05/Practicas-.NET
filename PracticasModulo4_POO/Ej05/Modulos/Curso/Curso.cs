using Ej05.Modulos.Alumno;

namespace Ej05;

public abstract class Curso
{
    public string Titulo
    {
        get => titulo;
        set 
        {
            
            if (value.Length > 100 || string.IsNullOrEmpty(value.Trim()))
            {
                Console.WriteLine("El titulo no puede estar vacio o tener mas de 100 caracteres, asignado titulo por defecto");
                titulo = "Curso";
            }
            else
            {
                titulo = value;
            }
        }
    }

    public double Precio
    {
        get => precio;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("El precio no puede ser menor que 0, asignado valor por defecto(0)");
                precio = 0;
            }
            else
            {
                precio = value;
            }
        }
    }

    public int Horas
    {
        get => horas;
        set
        {
            if (value < 0 || value > 1000)
            {
                Console.WriteLine("El numero de horas no puede ser menor que 0 o mayor de 1000, asignado valor por defecto(10)");
                horas = 10;
            }
            else
            {
                horas = value;
            }
        }
    }

    public Alumno[] Alumnos => alumnos;

    public Curso(string titulo, double precio, int horas, Alumno[] nAlumnos)
    {
        Titulo = titulo;
        Precio = precio;
        Horas = horas;
    }
    
    public Curso() {}

    private string titulo;
    private double precio;
    private int horas;
    private Alumno[] alumnos =  new Alumno[100];
    private int nAlumnos = 0;

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Precio: {CalcularPrecio()}");
        Console.WriteLine($"Horas: {Horas}");
        Console.WriteLine($"Numero de alumnos: {nAlumnos}");
    }

    public abstract double CalcularPrecio();

    public void MatricularAlumno(Alumno alumno, int posicion)
    {
        alumnos[posicion] = alumno;
        nAlumnos++;
    }
}
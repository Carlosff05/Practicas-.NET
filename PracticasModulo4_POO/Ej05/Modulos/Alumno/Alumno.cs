namespace Ej05.Modulos.Alumno;

public class Alumno
{
    private string nombre;

    public Alumno(string nombre)
    {
        Nombre = nombre;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    override public string ToString()
    {
        return Nombre;
    }
}
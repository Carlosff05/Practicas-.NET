namespace Proyecto3;

public class Persona
{
    public string Nombre { get; private set; }
    public string Apellidos { get; private set; }
    public string Dni { get; private set; }
    
    public Persona() {}

    public Persona(string nombre, string apellidos, string dni)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Dni = dni;
    }

    override public string ToString()
    {
        return $"{Dni} - {Apellidos}, {Nombre}";
    }
}
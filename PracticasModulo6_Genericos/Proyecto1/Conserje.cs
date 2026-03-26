namespace Proyecto1;

public class Conserje : Persona
{
    public bool Contratado { get; set; }

    public Conserje(string nombre)
    {
        Nombre = nombre;
    }
    
    public Conserje(string nombre, string apellido, bool contratado)
    {
        Nombre = nombre;
        Apellido = apellido;
        Contratado = contratado;
    }
}
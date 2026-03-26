namespace Proyecto1;

public class Profesor : Persona
{
    public int Clase { get; set; }
    public Profesor(string nombre, string apellido, int clase)
    {
        Nombre = nombre;
        Apellido = apellido;
        Clase = clase;
    }
}
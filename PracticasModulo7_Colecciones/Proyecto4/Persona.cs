namespace Proyecto4;

public class Persona
{
    public string Nombre {get;set;}
    public string Apellido {get;set;}
    public string Dni {get;set;}

    public Persona(string nombre, string apellido, string dni)
    {
        Nombre = nombre;
        Apellido = apellido;
        Dni = dni;
    }

    override public string ToString()
    {
        return $"Nombre: {Nombre}{Environment.NewLine}" +
               $"Apellido: {Apellido}{Environment.NewLine}" +
               $"DNI: {Dni}{Environment.NewLine}";
    }
}
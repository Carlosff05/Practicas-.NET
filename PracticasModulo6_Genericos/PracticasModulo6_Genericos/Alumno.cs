namespace PracticasModulo6_Genericos;

public class Alumno : AccionPersona<Persona, int>
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Alumno() {}

    public bool Contribuye()
    {
        return false;
    }
}

public class Alumno<T> : Persona, IContribuyente<int>
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Alumno() {}

    public bool Contribuye()
    {
        return false;
    }
}
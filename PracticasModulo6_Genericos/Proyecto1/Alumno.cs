namespace Proyecto1;

public class Alumno : Persona
{
    public string Curso { get; set; }

    public Alumno(string nombre, string apellido, string curso)
    {
        Nombre = nombre;
        Apellido = apellido;
        Curso = curso;
    }
}
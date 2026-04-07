namespace PracticasModulo8_LINQ;

public class Alumno
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
    public double Media { get; set; }
    public List<string> Asignaturas { get; set; }

    public Alumno(int id, string nombre, string apellidos, int edad)
    {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
        Edad = edad;
        Media = 0;
        Asignaturas = new List<string>();
    }

    public void CalculaMedia(List<int> notas)
    {
        Media = notas.Average();
    }

    override public string ToString()
    {
        return $"{Id} - {Nombre} - {Apellidos} - {Media}";
    }
}
namespace PracticasModulo8_LINQ;

public class Profesor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
    public string Materia { get; set; }
    
    public Profesor(int id, string nombre, string apellidos, int edad, string materia) {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
        Edad = edad;
        Materia = materia;
    }

    override public string ToString()
    {
        return $"{Id} - {Nombre} - {Apellidos} - {Materia}";
    }
}
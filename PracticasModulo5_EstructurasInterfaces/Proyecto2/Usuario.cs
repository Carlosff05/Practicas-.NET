namespace Proyecto2;

public class Usuario
{
    [Flags]
    public enum TipoUsuario
    {
        Lector = 1,
        OperadorInformes = 2,
        GestorUsuarios = 4,
        Administrador = 8
    }
    
    string Nombre { get; set; }
    public TipoUsuario Tipo { get; set; }
    
    public Usuario(string nombre)
    {
        Nombre = nombre;
    }

    override public string ToString()
    {
        return $"{Nombre}: {Tipo}";
    }
}
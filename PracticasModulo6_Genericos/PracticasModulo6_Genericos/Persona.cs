namespace PracticasModulo6_Genericos;

public class Persona : IContribuyente<int>
{
    public int Referencia { get; set; }

    public bool Contribuye()
    {
        return true;
    }
}
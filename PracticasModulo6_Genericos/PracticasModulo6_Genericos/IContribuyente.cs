namespace PracticasModulo6_Genericos;

public interface IContribuyente<T> where T: struct
{
    T Referencia { get; set; }
    bool Contribuye();
}
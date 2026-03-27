namespace Proyecto1;

public interface IPersona<T>
{
    string Nombre { get; set; }
    T Peso { get; set; }
    T Altura { get; set; }

    void MostrarDatosFisicos();
}
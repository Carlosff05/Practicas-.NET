namespace Proyecto3;

public class Superman : IPajaro, IAvion
{
    void IPajaro.Volar()
    {
        Console.WriteLine("Eso es un pajaro?");
    }

    void IAvion.Volar()
    {
        Console.WriteLine("Es un avion?");
    }

    public void Volar()
    {
        Console.WriteLine("Es superman!");
    }

    public void Aletear()
    {
        Console.WriteLine("Aleteando!");
    }
}
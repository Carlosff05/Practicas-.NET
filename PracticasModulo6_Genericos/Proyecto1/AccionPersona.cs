using System.Numerics;

namespace Proyecto1;

public class AccionPersona<TPersona>
{
    public TPersona Persona1 { get; set; }
    public TPersona Persona2 { get; set; }
    
    public AccionPersona(TPersona persona, TPersona persona2)
    {
        Persona1 = persona;
        Persona2 = persona2;
    }

    public bool Comparacion()
    {
        return Persona1.Equals(Persona2);
    }
    
    public string Union()
    {
        if (EsNumero(Persona1) && EsNumero(Persona2))
        {
            dynamic a = Persona1;
            dynamic b = Persona2;
            return $"La suma es: {a + b}";
        }
        return Persona1 + " " + Persona2;
    }
    
    private bool EsNumero(TPersona tipo)
    {
        return tipo is byte ||
               tipo is short ||
               tipo is int ||
               tipo is long ||
               tipo is float ||
               tipo is double ||
               tipo is decimal;
    }

    public string ImprimeConcreto<TArray, TPosicion>(TArray[] datos, TPosicion posicion)
    {
        dynamic accion = posicion;
        return datos[accion - 1].ToString();
    }
}
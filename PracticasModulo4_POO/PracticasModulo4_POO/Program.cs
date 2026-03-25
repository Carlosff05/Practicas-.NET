namespace Ej01;

public class Program
{
    public static void Main()
    {
        /*
         * Ej01-02
         * Console.WriteLine(Sumar(1, 2, 3));
         */
        
        /*
         * Ej03
         * string s1 = "Hello";
         * string s2 = "World";
         *
         * Intercambiar(ref s1, ref s2);
         *
         * Console.WriteLine(s1);
         * Console.WriteLine(s2);
         */
        
        Console.WriteLine(Potencia(2, 8));
    }

    //Ej01
    public static long Sumar(int[] numeros)
    {
        long suma = 0;
        foreach (int t in numeros)
        {
            suma += t;
        }
        return suma;
    }
    
    //Ej02
    public static long Sumar(int n1, int n2, int n3)
    {
        long suma = 0;
        suma += n1 + n2 + n3;
        return suma;
    }
    
    //Ej03
    public static void Intercambiar(ref string s1, ref string s2)
    {
        (s1, s2) = (s2, s1);
    }
    
    //Ej04
    public static long Potencia(long num, long exponente)
    {
        if (exponente == 0)
        {
            return 1;
        }

        if (exponente < 0) exponente *= -1;
        
        return num * Potencia(num, exponente - 1);
    }
}
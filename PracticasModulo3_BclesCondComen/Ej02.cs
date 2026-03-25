namespace PracticasModulo3_BclesCondComen;

public class Ej02
{
    static void Main(string[] args)
    {
        int[] m = new[] { 2, 2, 3, 1, 5 };
        int menor = Int32.MaxValue, mayor = Int32.MinValue;

        foreach (int num in m)
        {
            if (num > mayor)
            {
                mayor = num;
            }

            if (num < menor)
            {
                menor = num;
            }
        }
        
        Console.WriteLine(mayor);
        Console.WriteLine(menor);
    }
}
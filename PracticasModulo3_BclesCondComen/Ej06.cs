namespace PracticasModulo3_BclesCondComen;

public class Ej06
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 5; i++)
        {
            Console.WriteLine("=== Tabla del " + i + " ===");
            for (int j = 1; j <= 10; j++)
            {
                
                Console.WriteLine(i + " X " + j + " = " + (j * i));
            }
            Console.WriteLine();
        }
    }
}
namespace PracticasModulo3_BclesCondComen;

public class Ej03
{
    static void Main(string[] args)
    {
        int n1 = -1;

        do
        {
            Console.Write("Ingrese N1 (0 si quiere salir): ");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("N1 multiplicado por 3: " + n1 * 3);
        } while (n1 != 0);

    }
}
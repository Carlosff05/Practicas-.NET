namespace PracticasModulo3_BclesCondComen;

public class Ej04
{
    static void Main()
    {
        int n1 = -1;

        do
        {
            Console.Write("Ingrese N1 (0 si quiere salir): ");
            if (int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("N1 multiplicado por 3: " + n1 * 3);
            }
            else
            {
                Console.WriteLine("Valor no válido: debes introducir un número entero");
                n1 = -1;
            }
        } while (n1 != 0);
    }
}
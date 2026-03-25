namespace PracticasModulo3_BclesCondComen;

public class Ej11
{
    static void Main(string[] args)
    {
        string? seguir;
        /*
         * Versión 1, con calculos directos y variables
         *
        int c = 0, max = Int32.MinValue, min = Int32.MaxValue;
        double media = 0D;
        do
        {
            Console.Write("Introduce un número: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                c++;
                media += n;
                if (n > max)
                {
                    max = n;
                }

                if (n < min)
                {
                    min = n;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido: debes introducir un número entero");
            }
            Console.Write("\nDesea seguir? (s/n): ");
            seguir = Console.ReadLine();
            Console.WriteLine();
        } while (seguir.Equals("s", StringComparison.OrdinalIgnoreCase));

        media /= c;
        Console.WriteLine("Has introducido " + c + " numeros");
        Console.WriteLine("La media es: " + media);
        Console.WriteLine("El mayor es: " + max);
        Console.WriteLine("El menor es: " + min);
         */
        
        /*
         * Versión 2, con el uso de una matriz
         */

        int[] i = new int[1];
        int[] aux = new int[i.Length];
        do
        {
            Console.Write("Introduce un número: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                i[i.Length - 1] = n;
                i.CopyTo(aux, 0);
            }
            else
            {
                Console.WriteLine("Valor inválido: debes introducir un número entero");
            }
            Console.Write("Desea seguir? (s/n): ");
            seguir = Console.ReadLine();
            if (seguir.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                i = new int[i.Length + 1];
                aux.CopyTo(i, 0);
                aux = new int[i.Length];
            }
            Console.WriteLine();
        } while (seguir.Equals("s", StringComparison.OrdinalIgnoreCase));
        
        Console.WriteLine("Has introducido " + i.Length + " numeros");
        Console.WriteLine("La media es: " + i.Average());
        Console.WriteLine("El mayor es: " + i.Max());
        Console.WriteLine("El menor es: " + i.Min());
    }
}
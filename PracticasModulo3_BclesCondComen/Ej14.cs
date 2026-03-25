namespace PracticasModulo3_BclesCondComen;

public class Ej14
{
    static void Main()
    {
        bool primo = true;
        Console.Write("Escribe un número: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine("El numero " + n + " es primo");
            }
            else
            {
                Console.WriteLine("El numero " + n + " no es primo");
            }
        }
    }
}
namespace PracticasModulo3_BclesCondComen;

public class Ej05
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número entero del 1 al 9: ");
        if (Int32.TryParse(Console.ReadLine(), out int n1))
        {
            if (n1 >= 1 && n1 <= 9)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n1 + " X " + i + " = " + (n1 * i));
                }
            }
            else
            {
                Console.WriteLine("No se aceptan números que no esten entre 1 y 9");
            }
        }
        else
        {
            Console.WriteLine("Valor no válido: Debes introducir un número entero");
        }
    }
}
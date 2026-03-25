namespace PracticasModulo3_BclesCondComen;

public class Ej09
{
    static void Main()
    {
        Console.Write("Introduce un numero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            for (int i = 1; i <= numero; i++)
            {
                if (i == 15 || i == 21 || i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
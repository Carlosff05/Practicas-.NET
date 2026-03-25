namespace PracticasModulo3_BclesCondComen;

public class Ej08
{
    static void Main()
    {
        Console.Write("Introduce un numero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            //Version con for
            Console.WriteLine("Bucle for:");
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            
            //Version con while
            int j = 1;
            Console.WriteLine("Bucle while:");
            while (j <= numero)
            {
                Console.WriteLine(j++);
            }
            Console.WriteLine();
            
            //Versión con do-while
            int k = 1;
            Console.WriteLine("Bucle do-while:");
            do
            {
                Console.WriteLine(k++);
            } while (k <= numero);
            Console.WriteLine();
        }
    }
}
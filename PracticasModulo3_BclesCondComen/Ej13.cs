namespace PracticasModulo3_BclesCondComen;

public class Ej13
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un numero: ");
        if (Int32.TryParse(Console.ReadLine(), out int numero))
        {
            Console.Write("Introduce un numero: ");
            if (Int32.TryParse(Console.ReadLine(), out int numero2))
            {
                string res = numero > numero2 ? numero + " es el mayor" : numero2 + " es el mayor";
                Console.WriteLine(res);
            }
            else
            {
                Console.Write("Valor inválido: Debes introducir un número entero ");
            }
        }
        else
        {
            Console.Write("Valor inválido: Debes introducir un número entero ");
        }
    }
}
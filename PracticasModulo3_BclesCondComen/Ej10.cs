namespace PracticasModulo3_BclesCondComen;

public class Ej10
{
    static void Main()
    {
        Console.Write("Introduce un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            string numero = n + "";
            if (numero.Contains('-')) 
            { 
                Console.WriteLine(numero.Length - 1 + " cifras");
            }
            else 
            { 
                Console.WriteLine(numero.Length + " cifras");
            }
        }
        else
        {
            Console.WriteLine("Valor invalido, no es un número entero");
        }
    }
}
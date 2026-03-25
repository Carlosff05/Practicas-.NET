namespace PracticasModulo3_BclesCondComen;

public class Ej07
{
    static void Main()
    {
        string clave = "secreto";
        int intentos = 5;
        
        string? usuario;
        do
        {
            Console.Write("Ingrese la clave de acceso: ");
            usuario = Console.ReadLine();
            intentos--;
            if (usuario.Equals(clave))
            {
                Console.WriteLine("Acceso concedido!");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
                if (intentos == 0)
                {
                    Console.WriteLine("No le quedan más intentos");
                }
            }
        } while (intentos > 0 && !usuario.Equals(clave));
    }
}
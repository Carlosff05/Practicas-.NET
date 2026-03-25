namespace PracticasModulo3_BclesCondComen;

public class Ej15
{
    static void Main(string[] args)
    {
        Console.Write("¿Precio?: ");
        if (int.TryParse(Console.ReadLine(), out int precio))
        {
            Console.Write("¿Me pagas con...?: ");
            if (int.TryParse(Console.ReadLine(), out int pago))
            {
                int cambio = pago - precio;
                if (cambio < 0)
                {
                    Console.WriteLine("Dinero insuficiente para pagar");
                }
                else if (cambio == 0)
                {
                    Console.WriteLine("Gracias, vuelva pronto!");
                }
                else
                {
                    Console.WriteLine($"Su cambio es {cambio}: {divideCambio(cambio)}");
                }
            }
        }
    }

    static string divideCambio(int cambio)
    {
        string devolucion = "";
        while (cambio > 0)
        {
            if (cambio >= 50)
            {
                devolucion += 50 + " ";
                cambio -= 50;
            }
        
            if (cambio >= 20)
            {
                devolucion += 20 + " ";
                cambio -= 20;
            }
        
            if (cambio >= 10)
            {
                devolucion += 10 + " ";
                cambio -= 10;
            }
            if (cambio >= 5)
            {
                devolucion += 5 + " ";
                cambio -= 5;
            }
            if (cambio >= 2)
            {
                devolucion += 2 + " ";
                cambio -= 2;
            }
            if (cambio >= 1)
            {
                devolucion += 1 + " ";
                cambio -= 1;
            }
        }
        
        return devolucion;
    }
}
using System.Collections;
using System.Text.RegularExpressions;
using Proyecto3;

Queue personas = new Queue();
int eleccion;

do
{
    Console.Write(ImprimeMenu());
    try
    {
        eleccion = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Debe introducir un número entero: {e.Message}");
        eleccion = 0;
    }

    switch (eleccion)
    {
        case 1:
            AnnadePersona();
            break;
        case 2:
            PasaTurno();
            break;
        case 3:
            Console.WriteLine("Gracias, vuelva pronto!");
            break;
        default:
            Console.WriteLine("Ese no es un número válido");
            break;
    }
} while (eleccion != 3);

return;

string ImprimeMenu()
{
    string salida = $"Indique lo que quiere hacer:" +
                    $"{Environment.NewLine}\t1. Añadir persona" +
                    $"{Environment.NewLine}\t2. Pasar turno" +
                    $"{Environment.NewLine}\t3. Finalizar" +
                    $"{Environment.NewLine}¿Cual es su elección?: ";
    return salida;
}

void AnnadePersona()
{
    string nombre = EscribeNombre(),
        apellidos = EscribeApellidos(), 
        dni = EscribeDni();
    
    Persona persona = new Persona(nombre, apellidos, dni);
    personas.Enqueue(persona);
    
    Console.WriteLine($"Se ha añadido con exito a la persona{Environment.NewLine}" +
                      $"Ahora hay {personas.Count} personas en la lista{Environment.NewLine}");
}

void PasaTurno()
{
    if (personas.Count > 0)
    {
        Console.WriteLine($"Se ha atendido con exito a {personas.Dequeue()}{Environment.NewLine}" +
                          $"Ahora hay {personas.Count} personas en la lista{Environment.NewLine}");
    }
    else
    {
        Console.WriteLine($"La lista está vacía{Environment.NewLine}");
    }
    
}

string EscribeNombre()
{
    string nombre;
    do
    {
        Console.Write("Ingrese el nombre de la persona: ");
        nombre = Console.ReadLine()!;

        if (!ValidaString(nombre))
            Console.WriteLine($"El nombre no puede estar vacio{Environment.NewLine}");
    } while (!ValidaString(nombre));
    
    return nombre;
}

string EscribeApellidos()
{
    string apellidos;
    do
    {
        Console.Write("Ingrese los apellidos de la persona: ");
        apellidos = Console.ReadLine()!;

        if (!ValidaString(apellidos))
            Console.WriteLine($"Los apellidos no pueden estar vacios{Environment.NewLine}");
    } while (!ValidaString(apellidos));
    
    return apellidos;
}

string EscribeDni()
{
    string dni;
    do
    {
        Console.Write("Ingrese el dni de la persona: ");
        dni = Console.ReadLine()!;

        if (!ValidaString(dni))
            Console.WriteLine($"El dni no puede estar vacio{Environment.NewLine}");
        else if (!ValidaPatron(dni))
            Console.WriteLine($"El dni debe seguir el siguiente patron [12345678X], ocho número seguidos de una letra{Environment.NewLine}");
    } while (!ValidaString(dni) || !ValidaPatron(dni));
    
    return dni;
}

bool ValidaString(string cadena)
{
    return !string.IsNullOrEmpty(cadena);
}

bool ValidaPatron(string cadena)
{
    cadena = cadena.ToUpper();
    string patronDni = @"^[0-9]{8}[A-Z]";
    
    return Regex.IsMatch(cadena, patronDni);
}
using System.Text.RegularExpressions;
using Proyecto4;

ColeccionPersonas personas = new ColeccionPersonas();

int eleccion;
do
{
    Console.WriteLine(ImprimeMenu());
    try
    {
        eleccion = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        eleccion = 0;
    }

    switch (eleccion)
    {
        case 1:
            AnnadePersona();
            break;
        case 2:
            ModificaPersona();
            break;
        case 3:
            VerPersona();
            break;
        case 4:
            EliminaPersona();
            break;
        case 5:
            BuscaPersona();
            break;
        case 6:
            Console.WriteLine($"¡Adios, vuelva pronto!");
            break;
        default:
            Console.WriteLine($"{eleccion} no es una opcion válida, pruebe de nuevo{Environment.NewLine}");
            break;
    }
} while (eleccion != 6);

return;

string ImprimeMenu()
{
    string salida = $"Indique lo que quiere hacer:" +
                    $"{Environment.NewLine}\t1. Añadir persona" +
                    $"{Environment.NewLine}\t2. Modificar persona" +
                    $"{Environment.NewLine}\t3. Ver persona" +
                    $"{Environment.NewLine}\t4. Eliminar persona" +
                    $"{Environment.NewLine}\t5. Buscar persona" +
                    $"{Environment.NewLine}\t6. Finalizar operaciones" +
                    $"{Environment.NewLine}¿Cual es su elección?: ";
    return salida;
}

void AnnadePersona()
{
    string nombre = EscribeNombre(),
        apellidos = EscribeApellidos(), 
        dni = EscribeDni();
    
    Persona persona = new Persona(nombre, apellidos, dni);
    personas.Add(persona);
    
    Console.WriteLine($"Se ha añadido con exito a la persona{Environment.NewLine}");
}

void ModificaPersona()
{
    if (personas.Count > 0)
    {
        int i = 0;
        foreach (Persona persona in personas)
        {
            i++;
            Console.WriteLine($"{i}. {persona}");
        }
        Console.Write("Ingrese la posición de la persona a modificar: ");
        int seleccionada =  int.Parse(Console.ReadLine()!) - 1;
        string nombre = EscribeNombre(),
            apellidos = EscribeApellidos(), 
            dni = EscribeDni();
    
        Persona p = new Persona(nombre, apellidos, dni);
        personas[seleccionada] = p;
        Console.WriteLine($"Se ha modificado con exito a la persona{Environment.NewLine}");
    }
    else
    {
        Console.WriteLine("Aun no hay personas, añada alguna primero");
    }
}

void VerPersona()
{
    if (personas.Count > 0)
    {
        Console.Write($"Hay {personas.Count} personas.{Environment.NewLine}" +
                      $"Ingrese la posición de la persona que quiere ver: ");
        int seleccionada =  int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{personas[seleccionada - 1]}");
    }
    else
    {
        Console.WriteLine("Aun no hay personas, añada alguna primero");
    }
}

void EliminaPersona()
{
    if (personas.Count > 0)
    {
        int i = 0;
        foreach (Persona persona in personas)
        {
            i++;
            Console.WriteLine($"{i}. {persona}");
        }
        Console.Write("Ingrese la posición de la persona a eliminar: ");
        int seleccionada =  int.Parse(Console.ReadLine()!) - 1;
        
        Console.Write($"¿Está seguro de que quiere eliminar a {personas[seleccionada].Nombre}" +
                          $"{personas[seleccionada].Apellido}? (S/n): ");
        string seguro = Console.ReadLine()!;

        if (seguro.ToUpper() == "S")
        {
            personas.RemoveAt(seleccionada);
            Console.WriteLine($"Se ha eliminado con exito a la persona{Environment.NewLine}");
        }
    }
    else
    {
        Console.WriteLine("Aun no hay personas, añada alguna primero");
    }
}

void BuscaPersona()
{
    Console.Write("Ingrese el dato a buscar: ");
    string dato = Console.ReadLine()!;

    Console.WriteLine($"{Environment.NewLine}\"{dato}\" encontrado en el nombre:");
    foreach (Persona persona in personas)
    {
        if (persona.Nombre.Contains(dato))
        {
            Console.WriteLine($"{personas.IndexOf(persona) + 1}. {persona}");
        }
    }
    
    Console.WriteLine($"{Environment.NewLine}\"{dato}\" encontrado en el apellido:");
    foreach (Persona persona in personas)
    {
        if (persona.Apellido.Contains(dato))
        {
            Console.WriteLine($"{personas.IndexOf(persona) + 1}. {persona}");
        }
    }
    
    Console.WriteLine($"{Environment.NewLine}\"{dato}\" encontrado en el DNI:");
    foreach (Persona persona in personas)
    {
        if (persona.Dni.Contains(dato))
        {
            Console.WriteLine($"{personas.IndexOf(persona) + 1}. {persona}");
        }
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
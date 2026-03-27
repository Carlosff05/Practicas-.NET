using System.Collections;

Hashtable tabla = new Hashtable();

string nombre, largo, corto;
int contador = 0, media = 0;

do
{
    Console.WriteLine("Ingrese un nombre (Intro sin nada para salir):");
    nombre = Console.ReadLine()!;
    if (!string.IsNullOrEmpty(nombre))
    {
        tabla.Add(contador, nombre);
        contador++;
    }
    largo = (string) tabla[contador - 1]!;
    corto = (string) tabla[contador - 1]!;
} while(!string.IsNullOrEmpty(nombre));

foreach (int key in tabla.Keys)
{
    string aux = (string) tabla[key]!;

    if (aux.Length > largo.Length)
    {
        largo = aux;
    }

    if (aux.Length < corto.Length)
    {
        corto = aux;
    }

    media += aux.Length;
}

media /= contador;
Console.WriteLine($"Usted ha introducido {tabla.Count} nombres.");
Console.WriteLine($"El nombre mas largo es: {largo}");
Console.WriteLine($"El nombre mas corto es: {corto}");

int posicion = 0;

do
{
    Console.WriteLine("Introduce la posición que quieres revisar (0 para salir): ");
    posicion = Convert.ToInt32(Console.ReadLine());

    if (posicion != 0)
    {
        string elegido = (string)tabla[posicion - 1]!;
        elegido = elegido.ToUpper();

        if (elegido.Length > media)
        {
            Console.WriteLine($"En la posición {posicion}: {elegido}. Está por encima de la media de longitud");
        }
        else if (elegido.Length < media)
        {
            Console.WriteLine($"En la posición {posicion}: {elegido}. Está por debajo de la media de longitud");
        }
        else
        {
            Console.WriteLine($"En la posición {posicion}: {elegido}. Está en la media de longitud");
        }
        
        
    }
} while(posicion != 0);
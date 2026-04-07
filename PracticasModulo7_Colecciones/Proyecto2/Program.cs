using System.Collections;

Dictionary<int, string> diccionario = new Dictionary<int, string>();

string nombre, largo, corto;
int contador = 0, media = 0;

do
{
    Console.WriteLine("Ingrese un nombre (Intro sin nada para salir):");
    nombre = Console.ReadLine()!;
    if (!string.IsNullOrEmpty(nombre))
    {
        diccionario.Add(contador, nombre);
        contador++;
    }
    largo = diccionario[contador - 1]!;
    corto = diccionario[contador - 1]!;
} while(!string.IsNullOrEmpty(nombre));

foreach (int key in diccionario.Keys)
{
    string aux = diccionario[key]!;

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
Console.WriteLine($"Usted ha introducido {diccionario.Count} nombres.");
Console.WriteLine($"El nombre mas largo es: {largo}");
Console.WriteLine($"El nombre mas corto es: {corto}");

int posicion = 0;

do
{
    Console.WriteLine("Introduce la posición que quieres revisar (0 para salir): ");
    posicion = Convert.ToInt32(Console.ReadLine());

    if (posicion != 0)
    {
        string elegido = diccionario[posicion - 1]!;
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
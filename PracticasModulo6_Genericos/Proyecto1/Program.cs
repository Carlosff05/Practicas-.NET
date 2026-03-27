using Proyecto1;

Conserje persona = new Conserje("Juan", "Perez", false);
persona.Altura = 1.7;
persona.Peso = 83;

persona.MostrarDatosFisicos();

int inter = 2;

AccionPersona<int> accionPersona = new AccionPersona<int>(inter, inter + 3);

var coleccion = new string[5];
for (int j = 0; j < coleccion.Length; j++)
{
    Console.Write("Introduce texto o números: ");
    coleccion[j] = Console.ReadLine()!;
}
int random = new Random().Next(1, coleccion.Length + 1);
    
Console.WriteLine(accionPersona.ImprimeConcreto(coleccion, random));
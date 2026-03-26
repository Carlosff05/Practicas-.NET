using Proyecto1;

Profesor i = new Profesor("Manuel", "Diaz", 123);
string s = "Hola";
int inter = 2;

AccionPersona<int> accionPersona = new AccionPersona<int>(inter, inter + 3);

var coleccion = new [] {"Hola", "Mundo", "Algo mas"};

Console.WriteLine(accionPersona.ImprimeConcreto(coleccion, new Random().Next(coleccion.Length) -1));
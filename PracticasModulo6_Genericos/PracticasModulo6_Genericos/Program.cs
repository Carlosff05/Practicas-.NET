using PracticasModulo6_Genericos;

Alumno alumno = new Alumno();
alumno.Nombre = "Rubén";
alumno.Apellidos = "Rubio";

Persona persona = new Persona();

AccionPersona<Persona, int> accion = new AccionPersona<Persona, int>();
accion.Persona = persona;

Console.WriteLine(accion.EsIgual(persona));
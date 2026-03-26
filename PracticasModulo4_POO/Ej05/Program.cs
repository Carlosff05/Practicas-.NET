using Ej05;
using Ej05.Modulos.Alumno;

CursoAMedida c1 = new CursoAMedida("Curso React", 0, 50, "Carlos Fernández");
CursoOnLine c2 = new CursoOnLine("Curso Java", 0, 50, "Carlos Fernández");

/*
 * Finalmente debemos asignarle el método o métodos que tiene que ejecutar.
 * Si volvemos el evento un atributo estático este servirá para todos los objetos de la clase,
 * en este caso Curso. Sin embargo también puede ser un atributo no estático y ahí tendríamos que
 * asignarle los eventos a cada objeto de la clase. Aunque también permite que un objeto ejecute
 * varios metodos con su evento. Pero otro objeto ejecute solo 1 método con su evento
 */
Curso.OnMatriculado += aviso;
//Curso.OnMatriculado += aviso2;

for (int i = 1; i <= 75; i++)
{
    c1.MatricularAlumno(new Alumno($"Alumno #{i}"), i);
    c2.MatricularAlumno(new Alumno($"Alumno #{i}"), i);
}

c1.MostrarInfo();

Console.WriteLine(Curso.totalAlumnos);

static void aviso(Alumno alumno)
{
    Console.WriteLine(alumno);
}

// Comentario rapido de varias lineas Ctrl + k, Ctrl + c
// static void aviso2(Alumno alumno)
// {
//     Console.WriteLine("Hola");
// }
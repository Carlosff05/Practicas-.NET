using Ej05;
using Ej05.Modulos.Alumno;

CursoAMedida c1 = new CursoAMedida("Curso React", 0, 50, "Carlos Fernández");

for (int i = 1; i <= 75; i++)
{
    c1.MatricularAlumno(new Alumno($"Alumno #{i}"), i);
}

c1.MostrarInfo();
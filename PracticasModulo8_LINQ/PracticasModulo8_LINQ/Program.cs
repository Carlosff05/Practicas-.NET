using PracticasModulo8_LINQ;

List<Alumno> alumnos = new List<Alumno>();
List<Profesor> profesores = new List<Profesor>();

RellenaProfe();
RellenaAlum();

TotalAlum();
Console.WriteLine();

AlumMasTresAsig();
Console.WriteLine();

ProfesoresYSusAlumnos();
Console.WriteLine();

MediaEdad();
Console.WriteLine();

AlumnosPorMateria();
Console.WriteLine();

AlumnosNombreIniVocal();
Console.WriteLine();

TodosNombresDistintos();
Console.WriteLine();

return;

void RellenaAlum()
{
    for (int i = 0; i < 5; i++)
    {
        alumnos.Add(new Alumno(i, $"Alumno{i}", $"Apellido{i}", i + 20));
        if (i % 2 == 0)
        {
            for (int j = 0; j < 10; j++) alumnos[i].Asignaturas.Add($"Materia{j + 1}");
        }
        else
        {
            for (int j = 0; j < 2; j++) alumnos[i].Asignaturas.Add($"Materia{j + 1}");
        }
    }
}

void RellenaProfe()
{
    for (int i = 1; i <= 5; i++)
    {
        profesores.Add(new Profesor(i, $"Profesor{i}", $"Apellido{i}", i + 35, $"Materia{i}"));
    }
}

void TotalAlum()
{
    int alumTotal = alumnos.Select(alumno => alumno).Count();
    Console.WriteLine($"Total de alumnos: {alumTotal}");
}

void AlumMasTresAsig()
{
    var masTresAsig = alumnos.Where(a => a.Asignaturas.Count > 3)
        .OrderBy(a => a.Apellidos);

    Console.WriteLine($"Alumnos con mas de 3 asignaturas ordenados por apellido:");
    foreach (var a in masTresAsig)
    {
        Console.WriteLine($"\t{a}");
    }
}

void ProfesoresYSusAlumnos()
{
    var consulta = profesores.Select(profesor => new
    {
        Profesor = profesor.Nombre,
        Asignatura = profesor.Materia,
        Alumnos = alumnos
            .Where(alumno => alumno.Asignaturas.Contains(profesor.Materia))
            .ToList()
    });

    foreach (var a in consulta)
    {
        Console.WriteLine($"Profesor: {a.Profesor} ({a.Asignatura})");

        foreach (var alumno in a.Alumnos)
        {
            Console.WriteLine($"  Alumno: {alumno.Nombre}");
        }

        Console.WriteLine();
    }
}

void MediaEdad()
{
    var mediaEdad = profesores.Select(p => p.Edad)
        .Concat(alumnos.Select(a => a.Edad))
        .Average();

    Console.WriteLine($"Media de edad total: {mediaEdad}");
}

void AlumnosPorMateria()
{
    Console.WriteLine("Alumnos por materias:");
    var consulta = profesores.Select(profesor => new
    {
        Asignatura = profesor.Materia,
        Alumnos = alumnos
            .Where(alumno => alumno.Asignaturas.Contains(profesor.Materia))
            .ToList()
    });

    foreach (var a in consulta)
    {
        Console.WriteLine(a.Asignatura);
        foreach (var alumno in a.Alumnos)
        {
            Console.WriteLine(alumno.Nombre);
        }
        Console.WriteLine();
    }
}

void AlumnosNombreIniVocal()
{
    var alumIniVocal = alumnos.Where(a => a.Nombre.ToUpper().StartsWith('A'))
        .Concat(alumnos.Where(a => a.Nombre.ToUpper().StartsWith('E')))
        .Concat(alumnos.Where(a => a.Nombre.ToUpper().StartsWith('I')))
        .Concat(alumnos.Where(a => a.Nombre.ToUpper().StartsWith('O')))
        .Concat(alumnos.Where(a => a.Nombre.ToUpper().StartsWith('U')));

    Console.WriteLine($"Alumnos cuyo nombre empieza por vocal:");
    foreach (var a in alumIniVocal)
    {
        Console.WriteLine(a);
    }
}

void TodosNombresDistintos()
{
    var difNames = profesores.Select(p => p.Nombre).Distinct()
        .Concat(alumnos.Select(a => a.Nombre).Distinct());

    Console.WriteLine("Los distintos nombres de alumnos y profesores: ");
    foreach (var a in difNames)
    {
        Console.WriteLine(a);
    }
}
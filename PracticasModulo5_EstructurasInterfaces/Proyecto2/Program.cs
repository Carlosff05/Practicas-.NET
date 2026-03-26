using Proyecto2;

Usuario u1 = new Usuario("Manuel");
Usuario u2 = new Usuario("Antonio");
Usuario u3 = new Usuario("Maria");

u1.Tipo = (Usuario.TipoUsuario) 1;
u2.Tipo = (Usuario.TipoUsuario) 2 | (Usuario.TipoUsuario) 4;
u3.Tipo = (Usuario.TipoUsuario) 1 | (Usuario.TipoUsuario) 2 | (Usuario.TipoUsuario) 4 | (Usuario.TipoUsuario) 8;

Console.WriteLine($"{u1}{Environment.NewLine}\t" + 
    $"Es gestor de usuarios?: {esGestorDeUsuarios(u1)}{Environment.NewLine}\tEs administrador?:{esAdministrador(u1)}");
Console.WriteLine($"{u2}{Environment.NewLine}\t" + 
    $"Es gestor de usuarios?: {esGestorDeUsuarios(u2)}{Environment.NewLine}\tEs administrador?:{esAdministrador(u2)}");
Console.WriteLine($"{u3}{Environment.NewLine}\t" + 
    $"Es gestor de usuarios?: {esGestorDeUsuarios(u3)}{Environment.NewLine}\tEs administrador?:{esAdministrador(u3)}");

static bool esGestorDeUsuarios(Usuario u)
{
    return u.Tipo >= (Usuario.TipoUsuario) 2;
}

static bool esAdministrador(Usuario u)
{
    return u.Tipo >= (Usuario.TipoUsuario) 8;
}
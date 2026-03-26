using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string cadena =
            "En un lugar de <span>La Mancha</span> de cuyo <span>nombre</span> no quiero acordarme...";

        string patron = @">([^<]+)<+/";

        MatchCollection coincidencias = Regex.Matches(cadena, patron);

        foreach (Match m in coincidencias)
        {
            Console.WriteLine(m.Groups[1].Value);
        }
    }

    private static void validaEmail()
    {
        string correo = "usuario.principal@usuarios.empresa.com";
        int posSeparador = 0;
        
        if (!correo.Contains('@'))
        {
            Console.WriteLine("Correo invalido, debe tener un \"@\"");
            return;
        }
        
        posSeparador = correo.IndexOf('@');

        if (validaUsuario(correo, posSeparador) && validaDominio(correo, posSeparador))
        {
            Console.WriteLine($"{correo} es correcto");
        }
        else
        {
            Console.WriteLine($"{correo} no valido");
        }
    }

    private static bool validaUsuario(string correo, int posSeparador)
    {
        string patronUsuario = @"^[^@\s]";
        string usuario = correo.Substring(0, posSeparador);
        
        return Regex.IsMatch(usuario, patronUsuario);
    }
    
    private static bool validaDominio(string correo, int posSeparador)
    {
        string patronDominio = @"[^@\s]\.[^@\s]+$";
        string dominio = correo.Substring(posSeparador + 1, correo.Length - posSeparador - 1);
        return Regex.IsMatch(dominio, patronDominio);
    }
}
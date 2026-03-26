namespace Proyecto4;

public static class ExtensionesString
{
    public static string Invertir(this string str)
    {
        string invertida = "";
        for (int i = str.Length; i > 0; i--)
        {
            invertida += str[i - 1];
        }
        return invertida;
    }

    public static bool EstaVacia(this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static string Right(this string str, int caracteres)
    {
        string aux = str.Invertir();
        
        return aux.Substring(0, caracteres).Invertir();
    }
    
    public static string Left(this string str, int caracteres)
    {
        
        return str.Substring(0, caracteres);
    }
}
namespace PracticasModulo5_EstructurasInterfaces;

public class Color
{
    byte R { get; set; }
    byte G { get; set; }
    byte B { get; set; }
    
    public  Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }
}
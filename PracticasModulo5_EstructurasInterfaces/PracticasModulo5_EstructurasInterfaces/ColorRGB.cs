namespace PracticasModulo5_EstructurasInterfaces;

public struct ColorRGB
{
    byte R { get; set; }
    byte G { get; set; }
    byte B { get; set; }

    public ColorRGB(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    override public string ToString()
    {
        return ($"rgb({R}, {G}, {B})");
    }
}
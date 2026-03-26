namespace PracticasModulo5_EstructurasInterfaces;

public struct Pixel
{
    int X { get; set; }
    int Y { get; set; }
    ColorRGB Color { get; set; }
    
    public Pixel(int x, int y, ColorRGB color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    override public string ToString()
    {
        return $"(X: {X}, Y: {Y}) - {Color}";
    }
}
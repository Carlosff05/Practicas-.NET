using System.Diagnostics;
using System.Text;
using PracticasModulo5_EstructurasInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int alto = 1920, ancho = 1080;
        ColorRGB color = new ColorRGB(0, 0, 0);
        Pixel[] pixels = new Pixel[alto * ancho];

        StringBuilder salida = new StringBuilder();
        
        int contador = 0;
        for (int y = 1; y <= ancho; y++)
        {
            for (int x = 1; x <= alto; x++)
            {
                pixels[contador] = new Pixel(x, y, color);
                if (contador <= 20000)
                {
                    salida.Append(pixels[contador] + Environment.NewLine);
                }
                contador++;
            }
        }
        
        Console.WriteLine(pixels[800]);
        Console.WriteLine(salida.ToString());
        stopwatch.Stop();
        Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");
    }
}
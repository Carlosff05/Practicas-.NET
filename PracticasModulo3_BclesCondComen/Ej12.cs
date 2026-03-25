namespace PracticasModulo3_BclesCondComen;

public class Ej12
{
    static void Main(string[] args)
    {
        Console.Write("Introduce la nota del 0 al 10: ");
        string resultado = int.TryParse(Console.ReadLine(), out int nota)
            ? (nota < 5 && nota >= 0
                ? "Suspenso"
                : nota < 7 && nota >= 0
                    ? "Aprobado"
                    : nota < 9 && nota >= 0
                        ? "Notable"
                        : nota <= 10 && nota >= 0
                            ? "Sobresaliente"
                            : "Nota no válida")
            : "Valor inválido: Debes introducir un numero entero";
        Console.WriteLine(resultado);
    }
}
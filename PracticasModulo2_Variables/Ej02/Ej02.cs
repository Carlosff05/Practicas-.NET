

namespace PracticasModulo2_Variables
{
    class Ej02
    {
        string hola = "Hola";
        static void Main(string[] args)
        {
            /*
             * Se puede usar el mismo nombre para dos variables independientemente de sus tipos,
             * siempre y cuando no sean ambas variables locales del mismo método/función
             * o sean ambas globales
             */
            int hola = 10;
            Console.WriteLine(hola);
        }
    }
}
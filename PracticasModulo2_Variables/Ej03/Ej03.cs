namespace PracticasModulo2_Variables
{
    class Ej03
    {
        const string hola = "hola";
        static void Main(string[] args)
        {
            /*
             * Igual que en el Ej02, se puede usar el mismo identificador para 2 variables cuales quiera,
             * sin importar si una de ellas es const o no, siempre y cuando, no sean las 2 variables
             * locales del mismo método/función o sean ambas globales
             */
            string hola = "hola";
            Console.WriteLine(hola);
        }
    }
}



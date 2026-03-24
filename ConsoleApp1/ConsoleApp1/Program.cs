namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaro la primera matriz
            string[][] nombres = new string[3][];
            nombres[0] = new string[] { "Juan", "Pepe" };
            nombres[1] = new string[] { "Eva", "Ana", "Julia", "Sandy"};
            nombres[2] = new string[] { "Maite" };
            
            //Imprimo la primera matriz
            Console.WriteLine("PRIMERA MATRIZ");
            for (int i = 0; i < nombres.Length; i++)
            {
                for (int j = 0; j < nombres[i].Length; j++)
                {
                    Console.Write(nombres[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            //Declaro la segunda matriz
            string[][] nombresCopia = new string[nombres.Length][];
            
            //Copio la primera matriz en la segunda
            for (int i = 0; i < nombresCopia.Length; i++)
            {
                nombresCopia[i] = new string[nombres[i].Length];
                nombres[i].CopyTo(nombresCopia[i], 0);
            }
            
            //Imprimimos la segunda matriz, comprobando así que se ha copiado correctamente
            Console.WriteLine("SEGUNDA MATRIZ");
            for (int i = 0; i < nombresCopia.Length; i++)
            {
                for (int j = 0; j < nombresCopia[i].Length; j++)
                {
                    Console.Write(nombresCopia[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
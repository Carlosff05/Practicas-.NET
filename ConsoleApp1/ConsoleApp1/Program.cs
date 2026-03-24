namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[][] nombres = new string[3][];
            nombres[0] = new string[] { "Juan", "Pepe" };
            nombres[1] = new string[] { "Eva", "Ana", "Julia", "Sandy"};
            nombres[2] = new string[] { "Maite" };
            
            for (int i = 0; i < nombres.Length; i++)
            {
                for (int j = 0; j < nombres[i].Length; j++)
                {
                    Console.Write(nombres[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
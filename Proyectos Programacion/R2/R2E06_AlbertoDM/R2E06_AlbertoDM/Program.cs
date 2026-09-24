namespace R2E06_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES

            // ENTRADA

            // PROCESO

            // SALIDA
            Console.WriteLine("Ejercicio 6");

            // a)
            bool e6_a = (1 > 0) && (3 >= 3);
            // b)
            bool e6_b = (0 < 5) || (0 > 5);
            // c) 
            bool e6_c = (5 <= 7) && (2 > 4);
            // d) 
            bool e6_d = !(5 != 5);

            Console.WriteLine($"6.a) (1 > 0) && (3 >= 3) -> {e6_a}");
            Console.WriteLine($"6.b) (0 < 5) || (0 > 5)  -> {e6_b}");
            Console.WriteLine($"6.c) (5 <= 7) && (2 > 4) -> {e6_c}");
            Console.WriteLine($"6.d) !(5 != 5)           -> {e6_d}");
        }
    }
}

namespace R2E03_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  CONSTANTES

            // VARIABLES

            // ENTRADA

            // PROCESO

            // SALIDA
            Console.WriteLine("Ejercicio 3");
            double x = 2, y = 3, a = 4, b = 5, z = 1, w = 2, n = 10;
            // a)
            double e3_a = 5 * (x + y);
            // b)
            double e3_b = Math.Pow(a, 2) + Math.Pow(b, 2);
            // c)
            double e3_c = x / (y * (z + w));
            // d)
            double e3_d = (x + y) / ((n + w) / a);

            Console.WriteLine($"3.a) Traducido: 5 * (x + y) = {e3_a}");
            Console.WriteLine($"3.b) Traducido: Math.Pow(a, 2) + Math.Pow(b, 2) = {e3_b}");
            Console.WriteLine($"3.c) Traducido: x / (y * (z + w)) = {e3_c}");
            Console.WriteLine($"3.d) Traducido: (x + y) / ((n + w) / a) = {e3_d}\n");
        }
    }
}

using System.Transactions;

namespace R2E09_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            double e9a, e9b, e9c, e9d, e9e, e9f;

            // ENTRADA

            // PROCESO
            e9a = 8 + 7 * 3 + 4 * 6;
            e9b = -Math.Pow(2, 3);
            e9c = (33 + 3 * 4) / 5.0;
            e9d = Math.Pow(2, 2) * 3;
            e9e = 3 + 2 * (18 - Math.Pow(4, 2));
            e9f = 16 * 6 - 3 * 2;

            // SALIDA
            Console.WriteLine("Ejercicio 9");

            Console.WriteLine($"9.a) {e9a} | 9.b) {e9b} | 9.c) {e9c}");
            Console.WriteLine($"9.d) {e9d} | 9.e) {e9e} | 9.f) {e9f}\n");
        }
    }
}

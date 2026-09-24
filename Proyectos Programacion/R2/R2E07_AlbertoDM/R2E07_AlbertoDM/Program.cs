namespace R2E07_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            double x7, z7;
            bool resultado7a, resultado7b;

            // ENTRADA
            // a)
            x7 = 7;
            z7 = 5;

            // b)
            x7 = 3;
            z7 = 10;

            // PROCESO
            resultado7a = (4.5 > x7) && (z7 < x7 + 7.5);
            resultado7b = (4.5 > x7) && (z7 < x7 + 7.5);

            // SALIDA
            Console.WriteLine("Ejercicio 7");
            Console.WriteLine($"7.a) Resultado esperado (false): {resultado7a}");
            Console.WriteLine($"7.b) Resultado esperado (true): {resultado7b}\n)");


        }
    }
}

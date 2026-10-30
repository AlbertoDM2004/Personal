namespace R8E01V3_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_MAXIMO = 100;
            const int VALOR_MINIMO = -100;
            const int INCREMENTO = 20;

            // VARIABLES
            double celsius = VALOR_MINIMO;
            double fahrenheit = 0.0;

            // ENTRADA
            Console.WriteLine("Celsius / Fahrenheit");

            // PROCESO

            // SALIDA
            // Mostramos la tabla usando un bucle del tipo for
            // Declaramos e incrementamos la variable celsius directamente en la firma del bucle
            for (double c = VALOR_MINIMO; celsius <= VALOR_MAXIMO; celsius += INCREMENTO)
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32;
                Console.WriteLine($"{celsius}ºC\t\t{fahrenheit}ºF");
            }

        }
    }
}

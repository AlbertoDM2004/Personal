namespace R8E02V2_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_MAXIMO = -100;
            const int VALOR_MINIMO = 100;
            const int DECREMENTO = 20;

            // VARIABLES
            double celsius = VALOR_MINIMO;
            double fahrenheit = 0.0;

            // ENTRADA
            Console.WriteLine("Celsius / Fahrenheit");

            // PROCESO

            // SALIDA
            do
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32;

                Console.WriteLine($"{celsius}ºC\t\t{fahrenheit}ºF");

                celsius -= DECREMENTO;
            } while (celsius >= VALOR_MAXIMO);

        }
    }
}

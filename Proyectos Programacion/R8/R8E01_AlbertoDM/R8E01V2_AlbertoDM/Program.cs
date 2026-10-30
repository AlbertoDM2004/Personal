using System.Xml.Linq;

namespace R8E01V2_AlbertoDM
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
            // Mostramos la tabla usando el bucle de tipo do/while
            do
            {
                // Hacemos el calculo de la conversion
                fahrenheit = (9.0 / 5.0) * celsius + 32;

                // Imprimimos los valores
                Console.WriteLine($"{celsius}ºC\t\t{fahrenheit}ºF");

                // Usamos la Constante INCREMENTO para incrementar el valor de los celsius
                celsius += INCREMENTO;
            } while (celsius <= VALOR_MAXIMO);

        }
    }
}

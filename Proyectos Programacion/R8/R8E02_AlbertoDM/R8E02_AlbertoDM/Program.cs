namespace R8E02_AlbertoDM
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
            double celsius = VALOR_MINIMO;   // Variable de control que almacenara los grados celsius actuales
            double fahrenheit = 0.0;      // Almacenara el resultado del calculo

            // ENTRADA
            Console.WriteLine("Celsius / Fahrenheit");


            // PROCESO

            // SALIDA
            while (celsius >= VALOR_MAXIMO)     // Cambiamos el simbolo a ">=" para que invertir el orden de la tabla
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32;
                Console.WriteLine($"{celsius}ºC\t\t{fahrenheit}ºF");
                celsius -= DECREMENTO;
            }

        }
    }
}

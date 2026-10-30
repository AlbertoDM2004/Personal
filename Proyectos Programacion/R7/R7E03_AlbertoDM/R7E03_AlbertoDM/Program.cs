namespace R7E03_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_MIN = 0;
            const byte VALOR_MAX = 100;
            const byte INCREMENTO = 1;
            const byte DIVISOR_PAR = 2; // Para la operacion matematica

            // VARIABLES
            byte contador = VALOR_MIN;

            // ENTRADA

            // PROCESO

            // SALIDA
            while (contador <= VALOR_MAX)
            {
                // El operador "%" obtiene el residuo de la division
                // Si el residuo de dividir el contador entre 2 es 0, significa que es par
                if (contador % DIVISOR_PAR == 0)
                {
                    Console.Write(contador);
                    Console.Write("\t");
                }
                contador = (byte)(contador + INCREMENTO);
            }

        }
    }
}

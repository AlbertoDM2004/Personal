namespace R7E01V1_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_MIN = 1;
            const byte VALOR_MAX = 100;
            const byte INCREMENTO = 1;

            // VARIABLES
            byte contador = VALOR_MIN;

            // ENTRADA

            // PROCESO

            // SALIDA
            while (contador <= VALOR_MAX)
            {
                Console.Write(contador);
                Console.Write("\t");    

                contador = (byte)(contador + INCREMENTO);
            }

        }
    }
}

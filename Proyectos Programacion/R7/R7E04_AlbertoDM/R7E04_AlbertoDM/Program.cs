namespace R7E04_AlbertoDM
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
            // Usamos "int" para la suma porque el resultado acumulado supera el limite de un byte
            int suma = 0;

            // ENTRADA

            // PROCESO
            while (contador <= VALOR_MAX)
            {
                // Vamos acumulando el valor del contador en la variable suma
                suma = suma + contador;
                contador = (byte)(contador + INCREMENTO);
            }

            // SALIDA
            Console.WriteLine($"La suma de los 100 primeros numeros es: {suma}");
        }
    }
}

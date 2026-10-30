namespace R4E01_V2_AntonioMC
{
    internal class Program
    {
        // V2 Estructurar el programa aislando el protocolo de la salida
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CERO = 0;

            // VARIABLES
            int numero;
            bool esPositivo;        // Flag - Controla si el numero es positivo
            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduzca un número entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            esPositivo = numero >= VALOR_CERO;      // El Flag tendra el resultaado de la comparacion / evaluacion


            // SALIDA
            if (esPositivo)
            {
                Console.WriteLine($"El número {numero} introducido es positivo");
            }
            else
            {
                Console.WriteLine($"El número {numero} introducido es negativo");
            }

        }
    }
}

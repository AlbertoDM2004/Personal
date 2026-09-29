namespace R4E01V2_AlbertoDM
{
    internal class Program
    {
        // V2: Estructurar el Programa aislando el procesamiento de la salida
        
        
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CERO = 0;

            // VARIABLES
            int numero;
            bool esPositivo;        // Flag - Controla si el numero es positivo
            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduzca un numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            esPositivo = numero >= VALOR_CERO;  // El Flag tendra el resultado de la evaluacion/comparacion

            // SALIDA
            if (esPositivo)
            {
                Console.WriteLine($"El numero {numero} introducido es positivo");
            }
            else
            {
                Console.WriteLine($"El numero {numero} introducido es negativo");
            }
        }
    }
}

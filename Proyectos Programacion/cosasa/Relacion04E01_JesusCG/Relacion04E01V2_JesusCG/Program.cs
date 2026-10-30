namespace Relacion04E01V2_JesusCG
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
            bool esPositivo;    // Flag - Controla si el número es positivo
            string cadenaAux;

            // ENTRADA
            Console.Write("Introduzca un numero entero: ");
            cadenaAux = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAux);

            // PROCESO
            esPositivo = numero >= VALOR_CERO;  // El Flag tendrá el resultado de la evaluación / comparación

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

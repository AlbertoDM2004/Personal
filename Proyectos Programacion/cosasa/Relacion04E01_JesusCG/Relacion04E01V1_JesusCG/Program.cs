namespace Relacion04E01V1_JesusCG
{
    internal class Program
    {
        // V1: Consideramos el 0 como un valor entero positivo

        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CERO = 0;

            // VARIABLES
            int numero;

            string cadenaAux;

            // ENTRADA
            Console.Write("Introduzca un numero entero: ");
            cadenaAux = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAux);

            // PROCESO

            // SALIDA
            if (numero >= VALOR_CERO)
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

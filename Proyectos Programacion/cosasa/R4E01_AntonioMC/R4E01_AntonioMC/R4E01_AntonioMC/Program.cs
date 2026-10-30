namespace R4E01_AntonioMC
{
    internal class Program
    {
        // V1 Consideramos el 0 como una constante
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CERO = 0;
            // VARIABLES
            int numero;
            string cadenaAuxiliar;
            // ENTRADA
            Console.Write("Introduzca un número entero:");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);
            // PROCESO

            // SALIDA
            if (numero >= 0)
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

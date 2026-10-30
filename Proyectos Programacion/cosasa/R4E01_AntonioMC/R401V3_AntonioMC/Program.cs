namespace R401V3_AntonioMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CERO = 0;
            
            // VARIABLES
            int numero = 0;
            bool esPositivo = true;     // Flag
            // string cadenaAux = "";
            bool esCorrecto = true;     // Centinela
            // string resultado = "";
            string resultado = "Negativo";      // Esta va a ser nuestra cadena auxiliar para leer numeros y luego guardará si el resultado es Negativo o Positivo
            
            // ENTRADA
            Console.Write("Introduzca un número entero: ");

            // cadenaAux = Console.ReadLine();
            // esCorrecto = Int32.TryParse(cadenaAux, out numero);

            resultado = Console.ReadLine();
            esCorrecto = Int32.TryParse(resultado, out numero);

            // PROCESO

            if (esCorrecto)     // Usamos la función if para que cuando el número sea un entero funcione la función if anidada, esta convierte la cadena "resultado" en Positivo o en Negativo
            {
                esPositivo = numero >= VALOR_CERO;

                if (esPositivo)
                {
                    resultado = "Positivo";
                }
                else
                {
                    resultado = "Negativo";
                }

                // SALIDA

                Console.WriteLine($"El número {numero} introducido es {resultado}");
            }
            else        // Si no se introduce un entero nos dará un mensaje de error
            {
                Console.WriteLine("ERROR: El valor introducido no es correcto");
            }
        }
    }
}

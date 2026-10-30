namespace R8E05V3_AlbertoDM
{
    internal class Program
    {
        /// <summary>
        /// V3: Se considera que todos los números tienen 2 divisores
        /// Encontrar un divisor más --> No es primo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // CONSTANTES
            const int LIM_INFERIOR = 0;

            // VARIABLES
            int numero = 0;
            string aux = "";

            //int numeroDivisores = 2;    // Ya sabemos que tiene 2 divisores
            int divisor = 0;
            bool esPrimo = true;    // Se supone que el usuario introducirá un número primo

            // Recursos para el control de errores
            bool esValido = true;
            byte codError = 0;      // 0 -> No hay error
                                    // 1 -> El valor no es un número o fuera del rangol de los enteros
                                    // 2 -> El número no es mayor estricto de 0

            // Recursos para las pruebas de rendimiento
            DateTime tiempoInicial;
            DateTime tiempoFinal;

            TimeSpan duracion;

            // ENTRADA
            // Captar el número a evaluar
            do
            {
                // Inicializar el control de errores
                codError = 0;
                //esValido = true;  Optimización del código por una actualización posterior

                // Solicitar el dato de entrada
                Console.Write("Introduzca el número a evaluar: ");
                aux = Console.ReadLine();

                // Procesamiento de la entrada
                esValido = Int32.TryParse(aux, out numero);

                // Validación - Detectar e Identificar los errores
                if (!esValido)
                {
                    codError = 1;
                }
                else
                {
                    if (numero <= LIM_INFERIOR)
                    {
                        esValido = false;
                        codError = 2;
                    }
                }

                // Retroalimentación de errores
                switch (codError)
                {
                    case 1:
                        Console.WriteLine("ERROR");
                        break;
                    case 2:
                        Console.WriteLine("ERROR");
                        break;
                }

            } while (!esValido);        // esValido == false

            // PROCESO
            // Iniciar el control de tiempo
            tiempoInicial = DateTime.Now;

            // Encontrar el número de divisores que tiene el número introducido
            //             Quito divisor número      Quito divisor 1
            for (divisor = numero - 1; (divisor > LIM_INFERIOR + 1) && esPrimo; divisor--)
            {
                // Forzar un pequeño retraso
                Thread.Sleep(500);

                if (numero % divisor == 0)
                {
                    //numeroDivisores++;
                    esPrimo = false;
                }
            }

            // Como no utilizo el numeroDivisores no necesito evaluarlo para saber si el número es o no primo
            //if (numeroDivisores != 2)
            //{
            //    esPrimo = false;
            //}
            //else
            //{
            //    esPrimo = true;
            //}

            // Finalizar el control de tiempo
            tiempoFinal = DateTime.Now;

            // Calcular el tiempo empleado
            duracion = tiempoFinal - tiempoInicial;

            // SALIDA
            if (!esPrimo)
            {
                Console.WriteLine($"El número {numero} NO es primo");
            }
            else
            {
                Console.WriteLine($"El número {numero} es primo");
            }

            // Mostrar el tiempo empleado
            Console.WriteLine($"El tiempo empleado es {duracion.TotalSeconds} segundos");
        }

    }
}

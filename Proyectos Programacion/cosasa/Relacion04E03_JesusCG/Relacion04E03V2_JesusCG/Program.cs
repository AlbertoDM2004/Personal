namespace Relacion04E03V2_JesusCG
{
    internal class Program
    {
        // V2: Detcción de errores en la Entrada de Datos

        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            //int numero1, numero2;
            // Inicialización de los datos/variables con valores por defecto
            int numero1 = 0;
            int numero2 = 0;
            string cadenaAux = "";  // Inicialización de la cadena con la Cadena Vacía

            int mayor = -100;

            bool esCorrecto;    // Centinela que controla/detecta si se producen errores

            // ENTRADA
            // Leer el número 1
            Console.Write("Introduzca el número 1: ");
            cadenaAux = Console.ReadLine();
            //numero1 = Convert.ToInt32(cadenaAux);
            esCorrecto = Int32.TryParse(cadenaAux, out numero1);  // Comprueba si la conversión tine éxito

            if (esCorrecto)
            {
                // Leer el número 2
                Console.Write("Introduzca el número 2: ");
                cadenaAux = Console.ReadLine();
                //numero2 = Convert.ToInt32(cadenaAux);
                esCorrecto = Int32.TryParse(cadenaAux, out numero2);

            }

            // PROCESO
            if (esCorrecto)
            {
                if (numero1 > numero2)
                {
                    mayor = numero1;
                }
                else
                {
                    mayor = numero2;
                }
            }

            // SALIDA
            //if (numero1 > numero2)
            //{
            //    Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {numero1}");
            //}
            //else
            //{
            //    Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {numero2}");
            //}

            if (esCorrecto)
            {
                Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {mayor}");
            }
            else
            {
                Console.WriteLine("ERROR: Ha inntroducido de forma incorrecta algún número");
            }

        }
    }
}

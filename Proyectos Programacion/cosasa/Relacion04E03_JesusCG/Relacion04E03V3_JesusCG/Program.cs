namespace Relacion04E03V3_JesusCG
{
    internal class Program
    {
        // V3: Detección e Identificación de Errores

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
            byte codigoError = 0;   // 0 -> No hay error
                                    // 1 -> Error en la introducción del número 1
                                    // 2 -> Error en la introducción del número 2

            // ENTRADA
            // Leer el número 1
            Console.Write("Introduzca el número 1: ");
            cadenaAux = Console.ReadLine();
            //numero1 = Convert.ToInt32(cadenaAux);
            esCorrecto = Int32.TryParse(cadenaAux, out numero1);  // Comprueba si la conversión tine éxito

            // Detectar y codificar el error
            if (!esCorrecto)    // esCorrecto == false
            {
                // Codificar el error
                codigoError = 1;
            }

            // Leer el número 2
            if (esCorrecto)
            {
                // Leer el número 2
                Console.Write("Introduzca el número 2: ");
                cadenaAux = Console.ReadLine();
                //numero2 = Convert.ToInt32(cadenaAux);
                esCorrecto = Int32.TryParse(cadenaAux, out numero2);

                // Detectar y codificar el error
                if (!esCorrecto)
                {
                    codigoError = 2;    // Codificación del error
                }

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

            //if (esCorrecto)
            //{
            //    Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {mayor}");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR: Ha inntroducido de forma incorrecta algún número");
            //}

            switch (codigoError)
            {
                case 0:
                    Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {mayor}");
                    break;
                case 1:
                    Console.WriteLine("ERROR: El número 1 no es un número o ha introducido un número fuera de rango");
                    break;
                case 2:
                    Console.WriteLine("ERROR: El número 2 no es un número o ha introducido un número fuera de rango");
                    break;
            }

        }
    }
}

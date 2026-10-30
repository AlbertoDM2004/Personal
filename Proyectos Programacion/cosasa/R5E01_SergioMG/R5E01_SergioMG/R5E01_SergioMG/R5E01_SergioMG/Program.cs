namespace R5E01_SergioMG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            //const byte METROS_CUADRADOS = 4;
            //const byte LARGO_MAX = 10;
            //const byte ANCHO_MAX = 6;

            const float METROS_CUADRADOS = 4;
            const float LARGO_MAX = 10;
            const float ANCHO_MAX = 6;
            const float ANCHO_MIN = 0;
            const float LARGO_MIN = 0;

            // VARIABLES
            //Indicamos el valor de cada float
            float ancho = 0;
            float largo = 0;
            float metroCuadrado = 0;
            string cadenaAux = ""; //Inicializanción de la cadena vacia
            bool esCorrecto = true; //centinela para comprobar errores
                                    // bool esMayor = true;
            byte codigoError = 0;   /*
                                     * Error 0 Sin error
                                     * 1 valor introduccido no valido
                                     * 2 ancho introduccido mayor al permitido
                                     * 3 valor introducido no valido
                                     * 4 largo introduccido mayor al permitido
                                     * 5 resultado menor al permitido
                                     */



            // ENTRADA
            //Leer el primer dato
            Console.Write("Introduzca el ancho de la piscina: ");
            cadenaAux = Console.ReadLine();
            esCorrecto = Single.TryParse(cadenaAux, out ancho); //Comprueba si la conversión tiene exito

            //Detectar y codificar el error
            if (!esCorrecto) //esCorrecto == false
            {
                //Codificación del error
                codigoError = 1;
            }
            //if (ancho > ANCHO_MAX)
            //{
            //  codigoError = 2;
            //}

            else
            {
                if (ancho > ANCHO_MAX || ancho <= 0)
                {
                    codigoError = 2;
                    esCorrecto = false;
                }
            }

            //Leer el segundo dato

            //if (esCorrecto)
            if (codigoError == 0)   // Si el error es 0 seguimos preguntando cifras
            {
                Console.Write("Introduzca el largo de la piscina: ");
                cadenaAux = Console.ReadLine();
                esCorrecto = Single.TryParse(cadenaAux, out largo); // comprueba si la conversion tiene exito

                //Detectar y codificar el error
                if (!esCorrecto)
                {
                    codigoError = 3; //Codificación del error
                }

                else
                {
                    if (largo > LARGO_MAX || largo <= 0)
                    {
                        codigoError = 4;
                        esCorrecto = false;
                    }
                }
                

            }
            // PROCESO
            //if(esCorrecto)
            if (codigoError == 0)
            {
                metroCuadrado = ancho * largo;

                if (metroCuadrado < METROS_CUADRADOS)
                {
                    codigoError = 5;
                }
            }


            // SALIDA

            switch (codigoError)
            {
                case 0:
                    Console.WriteLine($"La superficie de la piscina es de {metroCuadrado} m2");
                    break;

                case 1:
                    Console.WriteLine($"ERROR: Se ha introduccido una cadena de caracteres");
                    break;

                case 2:
                    Console.WriteLine($"ERROR: El valor introducido es erroneo");
                    break;

                case 3:
                    Console.WriteLine($"ERROR:  Se ha introduccido una cadena de caracteres");
                    break;

                case 4:
                    Console.WriteLine($"ERROR: El valor introduciso es erroneo");
                    break;

                case 5:
                    Console.WriteLine($"ERROR: El resultado es menor que nos metros cuadrados minimos que son 4");
                    break;
            }





        }
    }
}

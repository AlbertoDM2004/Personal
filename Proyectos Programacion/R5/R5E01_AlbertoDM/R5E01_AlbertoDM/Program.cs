namespace R5E01_AlbertoDM
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

            // VARIABLES
            //Indicamos el valor de cada float
            float ancho = 0;
            float largo = 0;
            float metroCuadrado = 0;
            string cadenaAuxiliar = ""; //Inicializacion de la cadena vacia
            bool esCorrecto = true;     //centinela para comprobar errores
                                        //bool esMayor = true;

            byte codigoError = 0;

            // ENTRADA
            //Leer el primer dato
            Console.Write("Introduzca el ancho de la piscina: ");
            cadenaAuxiliar = Console.ReadLine();
            esCorrecto = Single.TryParse(cadenaAuxiliar, out ancho);    //Comprueba si la conversion tiene exito

            //Detectar y codificar el error
            if (!esCorrecto)    //esCorrecto == false
            {
                //Codificacion del error
                codigoError = 1;
            }
            //if (ancho > ANCHO_MAX)
            //{
            //    codigoError = 2;
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
            if (codigoError == 0)   //Si el error es 0 seguimos preguntando cifras
            {
                Console.Write("Introduzca el largo de la piscina: ");
                cadenaAuxiliar = Console.ReadLine();
                esCorrecto = Single.TryParse(cadenaAuxiliar, out largo);    //Comprueba si la conversion tiene exito

                //Detectar y codificar el error
                if (!esCorrecto)
                {
                    codigoError = 3;    //Codificacion del error
                }

                if (largo > LARGO_MAX)
                {
                    codigoError = 4;
                }
            }
            // PROCESO
            //if (esCorrecto)
            if (codigoError == 0)
            {

            }

            // SALIDA

        }
    }
}

namespace R10E01V1_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES


            // VARIABLES
            float ancho = 0f;
            float largo = 0f;
            float profundidad = 0;
            float superficie = 0;
            bool superficieCorrecta = true;
            float volumen = 0;


            // ENTRADA
            // 1.- Captación/lectura del ancho de la piscina
            ancho = LeerAncho();
            // 2.- Captación/lectura del largo de la piscina
            largo = LeerLargo();
            // 3.- Captación/lectura de la profundidad de la piscina
            profundidad = LeerProfundidad();

            // PROCESO
            // 1.- Calcular la superficie de la piscina
            superficie = CalcularSuperficie(ancho, largo);


            // 2.- Comprobar la superficie de la piscina
            superficieCorrecta = ComprobarSuperficie(superficie);

            // 3.- Calcular el volumen (si la superficie ok)
            if (superficieCorrecta)
            {
                volumen = CalcularVolumen(superficie, profundidad);
            }

            // SALIDA
            // 1.- Mostrar los datos de la piscina y los datos calculados o error de superficie
            if (superficieCorrecta)
            {
                // 1 Método - Todos los argumentos (ancho, largo, profundidad, superficie, volumen)

                // 1 Método - Los datos de entrada (ancho, largo, profundidad)
                // 2 Método - Los datos calculados (superficie, volumen)
            }
            else
            {
                // Mensaje de Error
                MostrarMensajeError("La Superficie no cumple con los requisitos");
            }

        }

        #region MÉTODOS DE ENTRADA DE DATOS
        static public float LeerAncho()
        {
            // CONSTANTES
            const float ANCHO_MIN = 2.5f;
            const float ANCHO_MAX = 10.25f;

            // VARIABLES
            float valorAncho = 0;

            string cadena = "";

            // Detección e Identificación de errores
            bool esCorrecto = true;
            byte codigoError = 0;   // 0 -> No hay error
                                    // 1 -> No es un valor numérico o esta fuera del rango de float
                                    // 2 -> Ancho inferior al mínimo
                                    // 3 -> Ancho es superior al máximo

            do
            {
                codigoError = 0;    // Preparamos el identificador de errores en cada repetición
                
                // ENTRADA - Solicitud empleando la interfaz de usuario
                Console.Write("Introduzca el ancho de la piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                esCorrecto = Single.TryParse(cadena, out valorAncho); // int -> Int32

                if (esCorrecto)
                {
                    // Ancho es inferior al mínimo
                    if (valorAncho < ANCHO_MIN)
                    {
                        esCorrecto = false;
                        codigoError = 2;
                    }

                    // Ancho es superior al máximo
                    if (valorAncho > ANCHO_MAX)
                    {
                        esCorrecto = false;
                        codigoError = 3;
                    }
                }
                else    // Suponemos que va a introducir un número correcto
                {
                    codigoError = 1;
                }

                // SALIDA - Retroalimentacion de Errores (Interfaz de usuario)
                switch (codigoError)
                {
                    case 1:
                        MostrarMensajeError("No ha introducido un valor numérico o está fuera de rango");
                        break;
                    case 2:
                        MostrarMensajeError($"El Ancho es inferior a {ANCHO_MIN} metros");
                        break;
                    case 3:
                        MostrarMensajeError($"El Ancho es superior a {ANCHO_MAX} metros");
                        break;
                }

            } while (!esCorrecto);



            // SALIDA - Método
            return valorAncho;
        }

        static public float LeerLargo()
        {
            // CONSTANTES
            const float LARGO_MIN = 2.5f;
            const float LARGO_MAX = 20.5f;

            // VARIABLES
            float valorLargo = 0;

            // ENTRADA

            // PROCESO

            // SALIDA
            return valorLargo;
        }

        static public float LeerProfundidad()
        {
            // TODO Pendiente de Implementar el Método LeerProfundidad
            // CONSTANTES
            const float PROFUNDIDAD_MIN = 0.5f;
            const float PROFUNDIDAD_MAX = 5.75f;

            // VARIABLES
            float valorProfundidad = 0;

            // ENTRADA


            // PROCESAMIENTO

            // SALIDA - Método
            return valorProfundidad;

        }
        #endregion

        #region MÉTODOS DE PROCESAMIENTO
        static public float CalcularSuperficie(float base1, float altura)
        {
            // CONSTANTES

            // VARIABLES
            float area = 0;

            // ENTRADA

            // PROCESO
            area = base1 * altura;

            // SALIDA
            return area;
        }

        static public bool ComprobarSuperficie(float area)
        {
            // CONSTANTES
            const float SUPERFICIE_MIN = 6;


            // VARIABLES
            bool superficieValida = true;

            // ENTRADA

            // PROCESO
            //if (area > SUPERFICIE_MIN)
            //{
            //    superficieValida = true;
            //}
            //else
            //{
            //    superficieValida = false;
            //}

            superficieValida = area > SUPERFICIE_MIN;

            // SALIDA
            return superficieValida;
        }

        static public float CalcularVolumen(float area, float hondo)
        {
            // CONSTANTES

            // VARIABLES

            // ENTRADA

            // PROCESO

            // SALIDA
            return area * hondo;
        }
        #endregion

        #region MÉTODOS DE SALIDA DE RESULTADOS

        static public void MostrarMensajeError(string mensaje)
        {

            Console.WriteLine(mensaje);

            Console.Write("Pulse Enter / Intro para continuar......");
            Console.ReadLine();
            Console.Clear();        // Limpiar la pantalla
        }

        #endregion
    }
}

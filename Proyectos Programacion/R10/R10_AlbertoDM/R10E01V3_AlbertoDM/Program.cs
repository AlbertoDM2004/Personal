namespace R10E01V3_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const float ANCHO_MIN = 2.5f;
            const float ANCHO_MAX = 10.25f;

            const float LARGO_MIN = 2.5f;
            const float LARGO_MAX = 20.5f;

            const float PROFUNDIDAD_MIN = 0.5f;
            const float PROFUNDIDAD_MAX = 5.75F;

            // VARIABLES
            float ancho = 0f;
            float largo = 0f;
            float profundidad = 0;
            float superficie = 0;
            bool superficieCorrecta = true;
            float volumen = 0;


            // ENTRADA
            // 1.- Captación/lectura del ancho de la piscina
            //ancho = EntradaDeDatos.LeerAncho();
            // V3: Lectura de la Medida mediante un método General a reutilizar con el resto de medidas
            ancho = EntradaDeDatos.LeerMedida("Ancho", ANCHO_MIN, ANCHO_MAX);

            // 2.- Captación/lectura del largo de la piscina
            //largo = EntradaDeDatos.LeerLargo();
            // V3
            largo = EntradaDeDatos.LeerMedida("Largo", LARGO_MIN, LARGO_MAX);

            // 3.- Captación/lectura de la profundidad de la piscina
            //profundidad = EntradaDeDatos.LeerProfundidad();
            // V3
            profundidad = EntradaDeDatos.LeerMedida("Profundidad", PROFUNDIDAD_MIN, PROFUNDIDAD_MAX);

            // PROCESO
            // 1.- Calcular la superficie de la piscina
            superficie = ProcesoDatos.CalcularSuperficie(ancho, largo);


            // 2.- Comprobar la superficie de la piscina
            superficieCorrecta = ProcesoDatos.ComprobarSuperficie(superficie);

            // 3.- Calcular el volumen (si la superficie ok)
            if (superficieCorrecta)
            {
                volumen = ProcesoDatos.CalcularVolumen(superficie, profundidad);
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
                SalidaResultados.MostrarMensajeError("La Superficie no cumple con los requisitos");
            }

        }



    }
}

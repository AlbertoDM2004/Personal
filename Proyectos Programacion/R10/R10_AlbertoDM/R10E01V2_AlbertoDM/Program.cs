namespace R10E01V2_AlbertoDM
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
            ancho = EntradaDeDatos.LeerAncho();
            // 2.- Captación/lectura del largo de la piscina
            largo = EntradaDeDatos.LeerLargo();
            // 3.- Captación/lectura de la profundidad de la piscina
            profundidad = EntradaDeDatos.LeerProfundidad();

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

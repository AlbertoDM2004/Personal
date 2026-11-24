namespace R13E4_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int NUM_ELEMENTOS = 5;

            // VARIABLES
            int[] listaOriginal;
            int[] listaCopia;

            int posicion;

            // Inicialización del Array Original (Instanciación)
            listaOriginal = new int[NUM_ELEMENTOS];

            // ENTRADA
            // Leer la lista de números original
            for (posicion = 0; posicion < listaOriginal.Length; posicion++)
            {
                listaOriginal[posicion] = EntradaDatos.LeerNumero(posicion);
            }

            // PROCESO
            // Inicialización del array copia (Instanciación)
            listaCopia = new int[listaOriginal.Length];
            // Duplicar el array original
            for (posicion = 0; posicion < listaCopia.Length; posicion++)
            {
                listaCopia[posicion] = listaOriginal[posicion];
            }


            // SALIDA
            // Comprobación de que los arrays (original y copia) son iguales
            Console.Clear();
            Console.WriteLine("\tORIGINAL\t\tCOPIA");
            for (posicion = 0; posicion < NUM_ELEMENTOS; posicion++)
            {
                Console.WriteLine($"\t{listaOriginal[posicion]}\t\t\t{listaCopia[posicion]}");
            }

        }
    }
}

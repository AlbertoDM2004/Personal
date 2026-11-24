using System.Reflection.PortableExecutable;

namespace SorteoParticipantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int NUM_PARTICIPANTES = 5;    // Tamaño o el número de elementos del Array

            // VARIABLES
            // TIPO     Nombre
            string[] listaNombres;      // Definición de una Array -> No puede emplearse en el programa
                                        // Aún no se le ha reservado espacio en memoria
                                        // Valor por defecto. Null

            int posicion;       // Indice que ayudará a acceder a los elementos del array
                                // Valores de la posición: 0 - (NUM_PARTICIPANTES - 1)

            //string premiado = "";
            int posicionPremiado;       // Posición del array donde está el participante premiado

            Random generadorAleatorios;


            // INICIALIZACION
            //                        Tamaño del Array
            listaNombres = new string[NUM_PARTICIPANTES];   // Reserva de Memoria (Instanciación)
            generadorAleatorios = new Random();

            // ENTRADA
            // Captar los nombres de los participantes
            for (posicion =0; posicion < NUM_PARTICIPANTES; posicion++)
            {
                Console.Write($"Introduzca el nombre del participante {posicion + 1}: ");
                listaNombres[posicion] = Console.ReadLine();
            }

            // PROCESO
            // Obtener de forma aleatoria un nombre del array
            posicionPremiado = generadorAleatorios.Next(NUM_PARTICIPANTES);

            // SALIDA
            // Mostrar los nombres de los participantes
            Console.WriteLine("Nombres de los participantes: ");
            for (posicion = 0; posicion < NUM_PARTICIPANTES; posicion++)
            {
                Console.WriteLine($"- {listaNombres[posicion]}");
            }

            Console.WriteLine($"\nEl ganador es: {listaNombres[posicionPremiado]}");

        }
    }
}

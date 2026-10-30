using System.Xml.Serialization;

namespace R7E05V1_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int valorInicial = 0;
            int valorFinal = 0;
            int contador = 0;
            int numeroImpares = 0;
            string listaImpares = "";

            string cadena = "";
            bool esCorrecto = true;
            byte codigoError = 0;   // 0 -> No hay error
                                    // 1 -> No es un valor numerico o esta fuera de rango


            // ENTRADA
            // 1.- Introduccion del valor inicial
            do
            {
                // Se establece el criterio de que el usuario no se va a equivocar
                esCorrecto = true;
                codigoError = 0;

                Console.Write("Introduzca el valor inicial: ");
                cadena = Console.ReadLine();

                esCorrecto = Int32.TryParse(cadena, out valorInicial);

                if (!esCorrecto)
                {
                    codigoError = 1;
                }

                // Retroalimentacion
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: Ha introducido para el valor inicial un dato que no es un numero o es excesivamente grande");
                        break;
                }

            } while (!esCorrecto);

            // 2.- Introduccion del valor final


            // PROCESO
            contador = valorInicial;

            while (contador <= valorFinal)
            {
                if (contador % 2 != 0)
                {
                    listaImpares += $"{contador}\t";
                    numeroImpares++;
                }
                contador++;
            }

            // SALIDA


        }
    }
}

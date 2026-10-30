using System.Runtime.CompilerServices;

namespace Ejemplomenu_AlbertoDM
{
    internal class Program
    {
        /*
        Descripción ejemplo: Mostrar al usuario un menú de opciones
            Obtener la opcion seleccionada por el usuario
            Mostrar, en caso de error, la retroalimentacion correspondiente
            Mostrar, en caso de exito, el mensaje con la opcion seleccionada
        */
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte OPCION_MAX = 5;

            // VARIABLES
            string entrada = "";
            byte opcion = 0;
            bool esValido = true;   // Deteccion de errores 
            byte codigoError = 0;   // Identificacion de errores
                                    // 0 -> No hay error
                                    // 1 -> Error de introduccion de un valor que no es un numero o se ha pasado 3 pueblos
                                    // 2 -> Error de opción fuera de las proporcionadas en el menú

            // ENTRADA
            Console.WriteLine("\t\t CAFETERIA - ROSA\n");
            Console.WriteLine("\t 1 - Bocadillo Sorpresa");
            Console.WriteLine("\t 2 - Bocadillo Mortadela");
            Console.WriteLine("\t 3 - Sandwich Jamón y Queso");
            Console.WriteLine("\t 4 - Bocadillo Tortilla");
            Console.WriteLine("\t 5 - Serranito Gigante");
            Console.WriteLine("\t 0 - Salir");
            Console.Write("Seleccione la opcion: ");
            entrada = Console.ReadLine();
            esValido = Byte.TryParse(entrada, out opcion);

            // Validación - Identificación de errores
            if (!esValido)      //if (esValido == false)
            {
                codigoError = 1;
            }
            else
            {
                if (opcion >  OPCION_MAX)
                {
                    esValido = false;
                    codigoError = 2;
                }
            }


            // PROCESO
            if (esValido)
            {
                switch (opcion)
                {
                    case 1:
                        // Acciones para elaborar el Bocadillo Sorpresa
                        break;
                    case 2:
                        // Acciones para elaborar el Bocadillo de mortadela
                        break;
                }
            }

            // SALIDA
            if (esValido)
            {
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias por venir. El proximo elija algo");
                        break;
                    case 1:
                        Console.WriteLine("Aquí tiene su Bocadillo Sorpresa");
                        break;
                
                }
            }
            else
            {
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: No ha introducido un valor numerico o esta fuera de rango");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: Ha seleccionado una opcion del menu no valida");
                        break;
                }
            }

        }
    }
}

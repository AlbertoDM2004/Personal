namespace EjemploMenu_JesusCG
{
    internal class Program
    {
        /*
         Descripción Ejemplo: Mostrar al usuario un menú de opciones
           Obtener la opción seleccionada por el usuario
           Mostrar, en caso de error, la retroalimentación correspondiente
           Mostrar, en caso de éxito, el mensaje con la opción seleccionada
         */
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte OPCION_MAX = 5;

            // VARIABLES
            string entrada = "";
            byte opcion = 0;
            bool esValido = true;   // Detección de errores
            byte codigoError = 0;   // Identificación de errores
                                    // 0 -> No hay error
                                    // 1 -> Error de introducción de un valor que no es un número o se ha pasado tres pueblos
                                    // 2 -> Error de opción fuera de las proporcionadas en el menú
            // ENTRADA
            Console.WriteLine("\t\t CAFETERIA - ROSA\n");
            Console.WriteLine("\t 1 - Bocadillo Sorpresa");
            Console.WriteLine("\t 2 - Bocadillo Mortadela");
            Console.WriteLine("\t 3 - Sandwich Jamón y Queso");
            Console.WriteLine("\t 4 - Bocadillo Tortilla");
            Console.WriteLine("\t 5 - Serranito Gigante");
            Console.WriteLine("\t 0 - Salir");
            Console.Write("Seleccione opción: ");
            entrada = Console.ReadLine();
            esValido = Byte.TryParse(entrada, out opcion);

            // Validación - Identificación de errores
            if (!esValido)      // if (esValido == false)
            {
                codigoError = 1;
            }
            else
            {
                if (opcion > OPCION_MAX)
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
                        // Acciones para elaborar el Bocadillo de Mortadela
                        break;
                }
            }
            
            // SALIDA
            if (esValido)
            {
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias por venir. El próxima elija algo");
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
                        Console.WriteLine("ERROR: No ha introducido un valor numérico o está fuera de rango");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: Ha seleccionado una opción del menú no válida");
                        break;
                }
            }

        }
    }
}

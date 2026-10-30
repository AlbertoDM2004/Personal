namespace R6E03_AntonioMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            // Establecemos las constantes de los rangos mínimos y maximos
            const float ANCHO_MAX = 10;     // 10 inclusive
            const float LARGO_MAX = 10;     // 10 inclusive
            const float MEDIDA_MIN = 0;     // Medida minima mayor de 0 (ancho, largo y diametro)
            const float DIAMETRO_MAX = 8;   // 8 inclusive
            const float AREA_MIN = 4;       // El area tiene que ser superior a 4
            const float PI = MathF.PI;      // Numero Pi adaptado a float
            const byte OPCION_MAX = 3;      // Opcion maxima del menu

            // VARIABLES
            float ancho = 0;
            float largo = 0;
            float diametro = 0;
            float area = 0;
            bool esCorrecto = true;     // Centinela
            string forma = "";          // Nos indicara la forma de la piscina en la salida
            string cadenaAux = "";
            byte error = 0;
            byte opcion = 0;                /* TABLA DE ERRORES
                                              0 - Nada
                                              1 - ERROR, caracteres introducidos
                                              2 - ERROR, numero fuera de rango
                                              3 - ERROR, caracteres introducidos
                                              4 - ERROR, ancho fuera de rango
                                              5 - ERROR, caracteres introducidos
                                              6 - ERROR, largo fuera de rango
                                              7 - ERROR, caracteres introducidos
                                              8 - ERROR, diametro fuera de rango
                                              9 - ERROR, el area calculada no es mayor que el area minima designada
                                             */

            // ENTRADA
            // Mandamos el menu de opciones para elegir el tipo de piscina
            Console.WriteLine("\t\t\t--- TIPOS DE NUESTRAS PISCINAS ---\n");
            Console.WriteLine("\t1.Rectangular - 2.Triangular - 3.Circular - 0.Salir del programa");
            Console.Write("\tInserte el número de la opción del menú que desee: ");
            // Mandamos leer el input del usuario y comprobamos si tiene algun error
            cadenaAux = Console.ReadLine();
            esCorrecto = Byte.TryParse(cadenaAux, out opcion);
            // Comprobamos que no se haya introducido una cadena de caracteres
            if (!esCorrecto)
            {
                error = 1;
            }
            // Comprobamos que el usuario no ha introducido un numero fuera de nuestro rango
            else
            {
                if (opcion > OPCION_MAX)
                {
                    esCorrecto = false;
                    error = 2;
                }
                // Indicamos los casos que aparecerian segun el numero elegido por el usuario
                else
                {
                    switch (opcion)
                    {
                        // Como el case 1 y 2 son iguales ponemos las instrucciones en el case 2 y el break al final del mismo, para que asi cierre el case 1 y 2 a la vez
                        case 1:

                        case 2:
                            Console.Write("\n\tIntroduzca el ancho de la piscina en metros: ");
                            cadenaAux = Console.ReadLine();
                            esCorrecto = Single.TryParse(cadenaAux, out ancho);
                            // Lanzamos error si el usuario introduce caracteres
                            if (!esCorrecto)
                            {
                                error = 3;
                            }
                            // Lanzamos error si el usuario no introduce un ancho dentro de nuestro rango
                            else if (ancho > ANCHO_MAX || ancho <= MEDIDA_MIN)
                            {
                                esCorrecto = false;
                                error = 4;
                            }
                            else
                            {
                                Console.Write("\n\tIntroduzca el largo de la piscina en metros: ");
                                cadenaAux = Console.ReadLine();
                                esCorrecto = Single.TryParse(cadenaAux, out largo);
                                // Lanzamos error si el usuario introduce caracteres
                                if (!esCorrecto)
                                {
                                    error = 5;
                                }
                                // Lanzamos error si el usuario no introduce un largo dentro de nuestro rango
                                else if (largo > LARGO_MAX || largo <= MEDIDA_MIN)
                                {
                                    esCorrecto = false;
                                    error = 6;
                                }
                            }
                            break;
                        case 3:
                            Console.Write("\n\tIntroduzca el diámetro de la piscina en metros: ");
                            cadenaAux = Console.ReadLine();
                            esCorrecto = Single.TryParse(cadenaAux, out diametro);
                            // Lanzamos error si el usuario introduce caracteres
                            if (!esCorrecto)
                            {
                                error = 7;
                            }
                            // Lanzamos error si el usuario no introduce un diametro dentro de nuestro rango
                            else if (diametro > DIAMETRO_MAX || diametro <= MEDIDA_MIN)
                            {
                                esCorrecto = false;
                                error = 8;
                            }
                            break;
                    }       
                }
            }

            // PROCESO
            // Pasamos a hacer los calculos de las opciones, tenemos que poner como condicion que esCorrecto == true Y que opcion no sea 0, para poder leer despues opcion y nos permita sacar el mensaje de opcion == 0 
            if (esCorrecto && opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        forma = "Rectangular";
                        area = ancho * largo;
                        break;
                    case 2:
                        forma = "Triangular";
                        area = (ancho * largo) / 2;
                        break;
                    case 3:
                        forma = "Circular";
                        area = PI * ((diametro / 2) * (diametro / 2));
                        break;
                }
                // Aqui comprobamos que el area sea mayor que AREA_MIN
                if (area <= AREA_MIN)
                {
                    esCorrecto = false;
                    error = 9;
                }
            }



            // SALIDA
            // Procedemos a hacer la salida de las opciones y los errores
            if (esCorrecto)
            {
                if (opcion == 0)
                {
                    Console.WriteLine("\n\t¡Vuelva pronto!");
                }
                else
                {
                    Console.WriteLine($"\n\tSu piscina {forma} tendrá una superficie de {area} m2.");
                }
            }
            else
            {
                switch (error)
                {
                    case 1:
                        Console.WriteLine("\nERROR: Ha introducido una cadena de caracteres.");
                        break;
                    case 2:
                        Console.WriteLine("\nERROR: Ha introducido un número fuera de rango");
                        break;
                    case 3:
                        Console.WriteLine("\nERROR: Ha introducido una cadena de caracteres.");
                        break;
                    case 4:
                        Console.WriteLine("\nERROR: El ancho introducido es un número fuera de rango");
                        break;
                    case 5:
                        Console.WriteLine("\nERROR: Ha introducido una cadena de caracteres.");
                        break;
                    case 6:
                        Console.WriteLine("\nERROR: El largo introducido es un número fuera de rango");
                        break;
                    case 7:
                        Console.WriteLine("\nERROR: Ha introducido una cadena de caracteres.");
                        break;
                    case 8:
                        Console.WriteLine("\nERROR: El diámetro introducido es un número fuera de rango");
                        break;
                    case 9:
                        Console.WriteLine("\nERROR: La superficie obtenida no entra dentro de la superficie mínima");
                        break;
                }
            }
        }
    }
}

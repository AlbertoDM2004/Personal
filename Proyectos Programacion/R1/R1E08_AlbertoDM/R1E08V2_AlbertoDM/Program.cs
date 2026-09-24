namespace R1E08V2_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            string nombre;          // Nombre del Videojuego
            string desarrollador;
            //string pegi;
            byte pegi;              // Dato de tipo numérico
            string plataforma;
            //string precio;
            float precio;           // Dato numérico con decimales

            string cadenaAuxiliar;  // Cadena temporal que permitirá captar números del teclado
                                    // para posteriormente convertirlos al tipo númerico apropiado

            // ENTRADA
            // 1.- Solicitar el nombre del videojuego
            Console.Write("Introduzca el nombre del videojuego: ");
            nombre = Console.ReadLine();

            // 2.- Solicitar el nombre del desarrollador
            Console.Write("Introduzca el nombre del desarrollador: ");
            desarrollador = Console.ReadLine();

            // 3.- Solicitar la edad mínima permitida (PEGI)
            Console.Write("Introduzca el PEGI: ");
            //pegi = Console.ReadLine();        Instrucción de lectura de variable de tipo string
            cadenaAuxiliar = Console.ReadLine();    // Leer el número del teclado (sting)
            pegi = Convert.ToByte(cadenaAuxiliar);

            // 4.- Solicitar la plataforma compatible
            Console.Write("Introduzca la plataforma del videojuego: ");
            plataforma = Console.ReadLine();

            // 5.- Solicitar el precio del videojuego
            Console.Write("Introduzca el precio del videojuego: ");
            //precio = Console.ReadLine();
            cadenaAuxiliar = Console.ReadLine();
            precio = Convert.ToSingle(cadenaAuxiliar);

            // PROCESO

            // SALIDA
            // 1.- Mostrar la cabecera de presentación
            Console.WriteLine("Ficha del videojuego");

            // 2.- Mostrar el mensaje con el nombre del videojuego y el desarrollador
            Console.Write("     ");
            Console.Write(nombre);
            Console.Write(" desarrollado por ");
            Console.WriteLine(desarrollador);

            // V1 Párrafo en una única instrucción de salida
            Console.WriteLine("     " + nombre + " desarrollado por " + desarrollador);

            // V2 Párrafo en una única instrucción de salida con caracteres de escape
            Console.WriteLine("\t" + nombre + " desarrollado por " + desarrollador);

            // 3.- Mostrar el mensaje de la edad recomendada

            // 4.- Mostrar el mensaje con la plataforma y el precio del videojuego

        }
    }
}

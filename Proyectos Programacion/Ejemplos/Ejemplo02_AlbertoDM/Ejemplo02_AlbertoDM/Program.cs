namespace Ejemplo02_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            string nombreUsuario;

            // ENTRADA
            // Solicitar el nombre del usuario
            // Mostrar mensaje de solicitud
            // Console.WriteLine("Introduzca nombre de usuario: ");
            Console.Write("Introduzca nombre de usuario: ");

            // Leer el dato (nombre del usuario)
            nombreUsuario = Console.ReadLine();

            // PROCESO

            // SALIDA
            // Mostrar el mensaje de acceso autorizado
            Console.Write("El usuario ");
            Console.Write(nombreUsuario);
            Console.WriteLine(" tiene el acceso autorizado");
            
        }
    }
}

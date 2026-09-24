namespace R3E04_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1, numero2, cociente, resto;
            string cadenaAuxiliar;

            // ENTRADA
            // Pedimos al usuario que introduzca 2 numeros
            Console.Write("Introduce el primer numero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el segundo numero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            cociente = numero1 / numero2; // Calculamos el cociente con una division
            resto = numero1 % numero2; // Calculamos el resto de la division

            // SALIDA
            Console.WriteLine("La division del " + numero1 + " entre " + numero2 + " proporciona ");
            Console.WriteLine("Cociente: " + cociente);
            Console.WriteLine("Resto: " + resto);
        }
    }
}

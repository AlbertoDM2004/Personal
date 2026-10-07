namespace R4E03_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1;
            int numero2;
            int mayor;
            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduce el primer numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el segundo numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            if (numero1 > numero2)
            {
                mayor = numero1;
            }
            else
            {
                mayor = numero2;
            }

            // SALIDA
            Console.WriteLine($"El mayor del número {numero1} y número {numero2} es el número {mayor}.");

        }
    }
}

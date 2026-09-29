namespace R4E02_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CIEN = 100;

            // VARIABLES
            int numero;
            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduzca un numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO

            // SALIDA
            if (numero > VALOR_CIEN)
            {
                Console.WriteLine($"El numero {numero} es mayor que 100");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es menor o igual que 100");
            }

        }
    }
}

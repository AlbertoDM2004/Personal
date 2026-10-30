namespace Relacion04E03V1_JesusCG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1, numero2;
            string cadenaAux;

            int mayor;

            // ENTRADA
            // Leer el número 1
            Console.Write("Introduzca el número 1: ");
            cadenaAux = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAux);

            // Leer el número 2
            Console.Write("Introduzca el número 2: ");
            cadenaAux = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAux);

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
            //if (numero1 > numero2)
            //{
            //    Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {numero1}");
            //}
            //else
            //{
            //    Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {numero2}");
            //}

            Console.WriteLine($"El mayor del número {numero1} y el número {numero2} es {mayor}");

        }
    }
}

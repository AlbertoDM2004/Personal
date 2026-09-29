namespace R4E04_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int mayor;
            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduce el primer numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el segundo numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el tercer numero entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero3 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el cuarto numero entero: ");
            cadenaAuxiliar= Console.ReadLine();
            numero4 = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    if (numero1 > numero4)
                    {
                        mayor = numero1;
                    }
                    else
                    {
                        mayor = numero4;
                    }
                }
                else
                {
                    if (numero3 > numero4)
                    {
                        mayor = numero3;
                    }
                    else
                    {
                        mayor = numero4;
                    }
                }
            }
            else
            {
                if (numero2 > numero3)
                {
                    if (numero2 > numero4)
                    {
                        mayor = numero2;
                    }
                    else
                    {
                        mayor = numero4;
                    }
                }
                else
                {
                    if (numero3 > numero4)
                    {
                        mayor = numero3;
                    }
                    else
                    {
                        mayor = numero4;
                    }
                }
            }

            // SALIDA
            Console.WriteLine("Datos introducidos");
            Console.WriteLine($"Numero 1: {numero1} -------- Numero 2: {numero2}");
            Console.WriteLine($"Numero 3: {numero3} -------- Numero 4: {numero4}");
            Console.WriteLine();
            Console.WriteLine($"El mayor de los 4 numeros es: {mayor}");

        }
    }
}

namespace Relacion03E06V1_JesusCG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int ancho, alto;
            int superficieEntera;
            float superficieDecimal;

            string cadenaAuxiliar;

            // ENTRADA
            // 1.- Captar Ancho
            Console.Write("Introduzca el ancho del Triángulo: ");
            cadenaAuxiliar = Console.ReadLine();
            ancho = Convert.ToInt32(cadenaAuxiliar);

            // 2.- Captar Alto
            Console.Write("Introduzca el alto del Triángulo: ");
            cadenaAuxiliar = Console.ReadLine();
            alto = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            superficieEntera = (ancho * alto) / 2;
            superficieDecimal = (ancho * alto) / 2;
            
            // Conversión explícita de uno de los operandos de la división empleando CASTING
            superficieDecimal = (float)(ancho * alto) / 2;

            // SALIDA
            Console.WriteLine("El Triángulo cuya Base es de " + ancho + " metros y Altura es de " + alto + " metros");
            Console.WriteLine("Tiene una Superficie de " + superficieEntera + " metros cuadrados.");

            // Versión de salida PARAMETRIZADA
            Console.WriteLine($"\n\n\tEl Triángulo cuya Base es de {ancho} metros y Altura es de {alto} metros");
            Console.WriteLine($"\tTiene una Superficie de {superficieDecimal} metros cuadrados");

        }
    }
}

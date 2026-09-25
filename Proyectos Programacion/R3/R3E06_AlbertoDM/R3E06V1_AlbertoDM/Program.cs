namespace R3E06V1_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int ancho, alto;
            int superficieEntera;
            string cadenaAuxiliar;
            float superficieDecimal;

            // ENTRADA
            // 1.- Captar ancho
            Console.Write("Introduzca el ancho del triangulo: ");
            cadenaAuxiliar = Console.ReadLine();
            ancho = Convert.ToInt32(cadenaAuxiliar);

            // 2.- Captar alto
            Console.Write("Introduzca el alto del triangulo: ");
            cadenaAuxiliar = Console.ReadLine();
            alto = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            superficieEntera = (ancho * alto) / 2;
            superficieDecimal = (ancho * alto) / 2;
            
            // Conversion explicita de uno de los operando de la division empleando CASTING
            superficieDecimal = (float)(ancho * alto) / 2;


            // SALIDA
            Console.WriteLine("El triangulo cuya Base es de " + ancho + " metros y altura es de " + alto + " metros ");
            Console.WriteLine("Tiene una superficie de " + superficieEntera + " metros cuadrados");

            // Version de salida PARAMETRIZADA
            Console.WriteLine($"\n\n\tEl triangulo cuya Base es de {ancho} metros y altura es de {alto} metros ");
            Console.WriteLine($"\tTiene una superficie de {superficieDecimal} metros cuadrados");

        }
    }
}

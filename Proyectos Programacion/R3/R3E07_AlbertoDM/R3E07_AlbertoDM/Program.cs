namespace R3E07_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int edad;
            bool mayorEdad;
            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduzca su edad: ");
            cadenaAuxiliar = Console.ReadLine();
            edad = Convert.ToByte(cadenaAuxiliar);

            // PROCESO
            mayorEdad = edad >= 18;

            // SALIDA
            Console.WriteLine("El usuario con " + edad + " años");
            // .ToString().ToLower() es necesario para que salga "true" o "false" en minusculas
            Console.WriteLine("Mayor de edad: " + mayorEdad.ToString().ToLower());

        }
    }
}

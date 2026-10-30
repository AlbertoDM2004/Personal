namespace R4E04_AntonioMC
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
            string cadenaAux;
            int esMayor;    // Este será el mayor número y será el que nos servirá para poner al final

            // ENTRADA
            // Preguntamos por los números 
            Console.Write("Introduzca el primer número entero: ");
            cadenaAux = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAux);

            Console.Write("Introduzca el segundo número entero: ");
            cadenaAux = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAux);

            Console.Write("Introduzca el tercer número entero: ");
            cadenaAux = Console.ReadLine();
            numero3 = Convert.ToInt32(cadenaAux);

            Console.Write("Introduzca el cuarto número entero: ");
            cadenaAux = Console.ReadLine();
            numero4 = Convert.ToInt32(cadenaAux);

            // PROCESO
            // Declaro a numero1 como mayor
            esMayor = numero1;

            // IMPORTANTE!!! Uso 3 if, si el numero2 es mayor que la variable esMayor se declarará como esMayor
            if(numero2 > esMayor)
            {
                esMayor = numero2;
            }
            // Aquí ocurre lo mismo, si numero3 es mayor se declarará como la nueva variable esMayor
            if(numero3 > esMayor)
            {
                esMayor = numero3;
            }
            // De nuevo ocurre lo mismo
            if(numero4 > esMayor)
            {
                esMayor = numero4;
            }
            // En el caso de que ninguno haya sido mayor que esMayor entonces numero1 será el resultado

            // SALIDA

            Console.WriteLine("Datos introducidos");
            Console.WriteLine($"Número 1: {numero1} -------- Número 2: {numero2}");
            Console.WriteLine($"Número 3: {numero3} -------- Número 4: {numero4}");
            Console.WriteLine($"El mayor de los 4 números es: {esMayor}");


        }
    }
}

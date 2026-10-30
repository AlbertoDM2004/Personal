namespace R8E01_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int valorMaximo = 100;
            const int valorMínimo = -100;
            const int incremento = 20;

            // VARIABLES
            // Se elige el double para las temperaturas porque la conversion implica divisiones
            // y operaciones con decimales
            double celsius = valorMínimo;  //Variable de control que almacenara los grados celsius actuales 
            double fahrenheit = 0.0;        //Almacenara el resultado del calculo de la conversion

            // ENTRADA
            Console.WriteLine("Celsius / Fahrenheit");
            

            // PROCESO


            // SALIDA
            // Aplicamos la tabla mediante un bucle tipo while
            while (celsius <= valorMaximo)
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32;

                // Imprimimos los valores
                Console.WriteLine($"{celsius}ºC\t\t{fahrenheit}ºF");

                // Incrementamos el valor del celsius para la siguiente fila
                celsius += incremento;

            }
            


        }
    }
}

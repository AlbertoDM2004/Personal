namespace R7E02_AlbertoDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            //Usamos el sbyte ya que permite numeros de -128 a 127.
            //Cuando llegue a 0 y reste 1, pasara a -1 y el bucle se detendra
            const sbyte VALOR_MIN = 0;
            const sbyte VALOR_MAX = 100;
            const sbyte DECRECER = 1;

            // VARIABLES
            //Empezamos desde el valor maximo (100) para ir hacia abajo
            sbyte contador = VALOR_MAX;

            // ENTRADA

            // PROCESO

            // SALIDA
            //EL bucle se ejecuta mientras el contador sea mayor o igual al minimo
            while (contador >= VALOR_MIN)
            {
                Console.Write(contador);
                Console.Write("\t");

                //Restamos en lugar de sumar para ir de forma decreciente
                contador = (sbyte)(contador - DECRECER);
            }

        }
    }
}

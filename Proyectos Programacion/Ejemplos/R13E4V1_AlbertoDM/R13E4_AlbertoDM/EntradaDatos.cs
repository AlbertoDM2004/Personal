using System;
using System.Collections.Generic;
using System.Text;

namespace R13E4_AlbertoDM
{
    public static class EntradaDatos
    {
        #region MÉTODOS DE ENTRADA DE DATOS
        /// <summary>
        /// Lectura de un número entero
        /// </summary>
        /// <param name="ordenNumero">Valor de la posición dentro de un array</param>
        /// <returns>Número entero</returns>
        public static int LeerNumero(int ordenNumero)
        {
            // VARIABLES
            int numero = 0;

            // ENTRADA
            Console.Write($"Introduzca el número {ordenNumero + 1}: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // SALIDA - Método
            return numero;
        }

        #endregion

    }
}

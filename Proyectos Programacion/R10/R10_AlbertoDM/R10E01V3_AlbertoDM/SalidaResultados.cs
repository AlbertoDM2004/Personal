using System;
using System.Collections.Generic;
using System.Text;

namespace R10E01V3_AlbertoDM
{
    public static class SalidaResultados
    {
        #region MÉTODOS DE SALIDA DE RESULTADOS

        static public void MostrarMensajeError(string mensaje)
        {

            Console.WriteLine(mensaje);

            Console.Write("Pulse Enter / Intro para continuar......");
            Console.ReadLine();
            Console.Clear();        // Limpiar la pantalla
        }

        #endregion

    }
}

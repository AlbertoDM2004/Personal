using System;
using System.Collections.Generic;
using System.Text;

namespace R10E01V3_AlbertoDM
{
    public static class ProcesoDatos
    {
        #region MÉTODOS DE PROCESAMIENTO
        static public float CalcularSuperficie(float base1, float altura)
        {
            // CONSTANTES

            // VARIABLES
            float area = 0;

            // ENTRADA

            // PROCESO
            area = base1 * altura;

            // SALIDA
            return area;
        }

        static public bool ComprobarSuperficie(float area)
        {
            // CONSTANTES
            const float SUPERFICIE_MIN = 6;


            // VARIABLES
            bool superficieValida = true;

            // ENTRADA

            // PROCESO
            //if (area > SUPERFICIE_MIN)
            //{
            //    superficieValida = true;
            //}
            //else
            //{
            //    superficieValida = false;
            //}

            superficieValida = area > SUPERFICIE_MIN;

            // SALIDA
            return superficieValida;
        }

        static public float CalcularVolumen(float area, float hondo)
        {
            // CONSTANTES

            // VARIABLES

            // ENTRADA

            // PROCESO

            // SALIDA
            return area * hondo;
        }
        #endregion

    }
}

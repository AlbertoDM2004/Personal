using System;
using System.Collections.Generic;
using System.Text;

namespace R10E01V2_AlbertoDM
{
    public static class EntradaDeDatos
    {
        #region MÉTODOS DE ENTRADA DE DATOS
        static public float LeerAncho()
        {
            // CONSTANTES
            const float ANCHO_MIN = 2.5f;
            const float ANCHO_MAX = 10.25f;

            // VARIABLES
            float valorAncho = 0;

            string cadena = "";

            // Detección e Identificación de errores
            bool esCorrecto = true;
            byte codigoError = 0;   // 0 -> No hay error
                                    // 1 -> No es un valor numérico o esta fuera del rango de float
                                    // 2 -> Ancho inferior al mínimo
                                    // 3 -> Ancho es superior al máximo

            do
            {
                codigoError = 0;    // Preparamos el identificador de errores en cada repetición

                // ENTRADA - Solicitud empleando la interfaz de usuario
                Console.Write("Introduzca el ancho de la piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                esCorrecto = Single.TryParse(cadena, out valorAncho); // int -> Int32

                if (esCorrecto)
                {
                    // Ancho es inferior al mínimo
                    if (valorAncho < ANCHO_MIN)
                    {
                        esCorrecto = false;
                        codigoError = 2;
                    }

                    // Ancho es superior al máximo
                    if (valorAncho > ANCHO_MAX)
                    {
                        esCorrecto = false;
                        codigoError = 3;
                    }
                }
                else    // Suponemos que va a introducir un número correcto
                {
                    codigoError = 1;
                }

                // SALIDA - Retroalimentacion de Errores (Interfaz de usuario)
                switch (codigoError)
                {
                    case 1:
                        SalidaResultados.MostrarMensajeError("No ha introducido un valor numérico o está fuera de rango");
                        break;
                    case 2:
                        SalidaResultados.MostrarMensajeError($"El Ancho es inferior a {ANCHO_MIN} metros");
                        break;
                    case 3:
                        SalidaResultados.MostrarMensajeError($"El Ancho es superior a {ANCHO_MAX} metros");
                        break;
                }

            } while (!esCorrecto);



            // SALIDA - Método
            return valorAncho;
        }

        static public float LeerLargo()
        {
            // CONSTANTES
            const float LARGO_MIN = 2.5f;
            const float LARGO_MAX = 20.5f;

            // VARIABLES
            float valorLargo = 0;
            string cadena = "";

            // Detección e Identificación de errores
            bool esCorrecto = true;
            byte codigoError = 0;   // 0 -> No hay error
                                    // 1 -> No es un valor numérico o está fuera del rango de float
                                    // 2 -> Largo inferior al mínimo
                                    // 3 -> Largo es superior al máximo

            do
            {
                codigoError = 0; // Preparamos el identificador de errores en cada iteración

                // ENTRADA - Solicitud empleando la Interfaz de Usuario
                Console.Write("Introduzca el Largo de la Piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                esCorrecto = Single.TryParse(cadena, out valorLargo);

                if (esCorrecto)
                {
                    // Largo es inferior al mínimo
                    if (valorLargo < LARGO_MAX)
                    {
                        esCorrecto = false;
                        codigoError = 2;
                    }

                    // Largo es superior al máximo
                    if (valorLargo > LARGO_MIN)
                    {
                        esCorrecto = false;
                        codigoError = 3;
                    }
                }
                else      // Suponemos que va a introducir un número correcto
                {
                    codigoError = 1;
                }

                // SALIDA - Retroalimentación de Errores (Interfaz de Usuario)
                switch (codigoError)
                {
                    case 1:
                        SalidaResultados.MostrarMensajeError("No ha introducido un valor numérico o está fuera de rango");
                        break;
                    case 2:
                        SalidaResultados.MostrarMensajeError($"El Largo es inferior a {LARGO_MIN} metros");
                        break;
                    case 3:
                        SalidaResultados.MostrarMensajeError($"El Largo es superior a {LARGO_MAX} metros");
                        break;
                }

            } while (!esCorrecto);

            // SALIDA
            return valorLargo;

        }

        static public float LeerProfundidad()
        {
            // TODO Pendiente de Implementar el Método LeerProfundidad
            // CONSTANTES
            const float PROFUNDIDAD_MIN = 0.5f;
            const float PROFUNDIDAD_MAX = 5.75F;

            // VARIABLES
            float valorProfundidad = 0;
            string cadena = "";

            // Detección e Identificación de errores
            bool esCorrecto = true;
            byte codigoError = 0;   // 0 -> No hay error
                                    // 1 -> No es un valor numérico o está fuera del rango de float
                                    // 2 -> Profundidad inferior al mínimo
                                    // 3 -> Profundidad es superior al máximo

            do
            {
                codigoError = 0; // Preparamos el identificador de errores en cada iteración

                // ENTRADA - Solicitud empleando la Interfaz de Usuario
                Console.Write("Introduzca la Profundidad de la Piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                Single.TryParse(cadena, out valorProfundidad);

                if (esCorrecto)
                {
                    // Profundidad es inferior al mínimo
                    if (valorProfundidad <= PROFUNDIDAD_MIN)
                    {
                        codigoError = 2;
                    }

                    // Profundidad es superior al máximo
                    if (valorProfundidad >= PROFUNDIDAD_MAX)
                    {
                        codigoError = 3;
                    }
                }
                else      // Suponemos que va a introducir un número correcto
                {
                    codigoError = 1;
                }

                // SALIDA - Retroalimentación de Errores (Interfaz de Usuario)
                switch (codigoError)
                {
                    case 1:
                        SalidaResultados.MostrarMensajeError("No ha introducido un valor numérico o está fuera de rango");
                        break;
                    case 2:
                        SalidaResultados.MostrarMensajeError($"La Profundidad es inferior a {PROFUNDIDAD_MIN} metros");
                        break;
                    case 3:
                        SalidaResultados.MostrarMensajeError($"La Profundidad es superior a {PROFUNDIDAD_MAX} metros");
                        break;
                }

            } while (!esCorrecto);

            // SALIDA - Método
            return valorProfundidad;
        }
        #endregion

    }
}

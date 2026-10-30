namespace R6E01_JuanSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTES
            const int MINIMO_OPCION = 1;    //Se fija un minimo y un maximo para evitar errores al elegir
            const int MAXIMO_OPCION = 5;    

            //VARIABLES
            int opcion;                     //int porque la opcion del menu es un numero entero
            string cadenaAuxiliar;        
            bool esCorrecto;                //centinela 
            byte codigoError = 0;           //0 esta todo correcto
                                            //1 lo introducido no es un numero
                                            //2 lo introducido no esta en el rango de opciones

            //ENTRADA
            //Mostrar el menu con las opciones
            Console.WriteLine("Selecciona la opcion de la figura que desees ver: ");
            Console.WriteLine("1.Triangulo - 2.Escuadra - 3.Escuadra2 - 4.Piramide invertida - 5.Piramide");

            //Leer la opcion y comprobar si se puede convertir a numero
            cadenaAuxiliar = Console.ReadLine();
            esCorrecto = Int32.TryParse(cadenaAuxiliar, out opcion);

            //Detectar y codificar el error
            if (!esCorrecto)
            {
                codigoError = 1;            //No es un numero
            }
            else
            {
                if (opcion < MINIMO_OPCION || opcion > MAXIMO_OPCION)
                {
                    esCorrecto = false;     //Es un numero, pero esta fuera del rango de opciones
                    codigoError = 2;
                }
            }

            //PROCESO
            //No se necesita hacer ningun calculo en este ejercicio:


            //SALIDA
            //El switch exterior decide si hay error y el interior decide que figura dibujar
            switch (codigoError)
            {
                case 0:     //Si no hay errores entonces se dibuja la figura elegida
                    Console.WriteLine();
                    switch (opcion)
                    {
                        case 1:     
                            Console.WriteLine("*");
                            Console.WriteLine("* *");
                            Console.WriteLine("* * *");             //Triangulo
                            Console.WriteLine("* * * *");
                            Console.WriteLine("* * * * *");
                            break;
                        case 2:     
                            Console.WriteLine("* * * * *");
                            Console.WriteLine("* * * *");
                            Console.WriteLine("* * *");              //Escuadr
                            Console.WriteLine("* *");
                            Console.WriteLine("*");
                            break;
                        case 3:     
                            Console.WriteLine("* * * * *");
                            Console.WriteLine("  * * * *");
                            Console.WriteLine("    * * *");         //Escuadra 2
                            Console.WriteLine("      * *");
                            Console.WriteLine("        *");
                            break;
                        case 4:     
                            Console.WriteLine("* * * * *");
                            Console.WriteLine(" * * * *");
                            Console.WriteLine("  * * *");           //Piramide invertida
                            Console.WriteLine("   * *");
                            Console.WriteLine("    *");
                            break;
                        case 5:     
                            Console.WriteLine("    *");
                            Console.WriteLine("   * *");
                            Console.WriteLine("  * * *");           //Piramide
                            Console.WriteLine(" * * * *");
                            Console.WriteLine("* * * * *");
                            break;
                    }
                    break;
                case 1:   
                    Console.WriteLine("ERROR: Lo introducido no es un numero");
                    break;
                case 2:     
                    Console.WriteLine($"ERROR: La opcion {opcion} no esta entre el rango establecido 1-5.");
                    break;
            }
        }
    }
}

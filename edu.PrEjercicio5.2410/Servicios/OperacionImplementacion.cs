using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace edu.PrEjercicio5._2410.Servicios
{
    /// <summary>
    /// implementación de la OperaciónInterfaz.
    /// <author>CMR-061123</author>
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        MenuInterfaz mi = new MenuImplementacion();

        /// <summary>
        /// Metodo que imprime por pantalla la opción de continuar la consulta.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <returns></returns>
        public string menuSelecc()
        {
            string opcionSeleccionada;
            
            Console.WriteLine("s-Realizar otra consulta");
            opcionSeleccionada = Console.ReadLine();
             return opcionSeleccionada;
        }



        /// <summary>
        /// Metodo que realiza la operacion del año y mes solicitado por el usuario con el calculo de si el año es bisiesto o no.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <param name="añoSelec"></param>
        /// <param name="mesSelec"></param>
        public void menuBisiesto(int añoSelec, int mesSelec)
        {
            
            
            if (añoSelec % 4 == 0)
            {
                

                if (añoSelec % 100 == 0)
                {

                    if (añoSelec % 400 == 0)
                    {
                        // meses y año bisiesto al cumplirse todas las operaciones.
                        if (mesSelec >= 1 & mesSelec <= 12){

                            if (mesSelec == 1 | mesSelec == 3 | mesSelec == 5 | mesSelec == 7 | mesSelec == 8 | mesSelec == 10 | mesSelec == 12)
                            {
                                Console.WriteLine("El mes seleccionado tiene 31 dias");

                            }
                            else if (mesSelec == 4 | mesSelec == 6 | mesSelec == 9 | mesSelec == 11)
                            {
                                Console.WriteLine("El mes seleccionado tiene 30 dias");
                            }
                            else
                            {
                                Console.WriteLine("El mes seleccionado tiene 29 dias");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El número marcado no coincide con ningun mes");
                        }
                    }
                    // meses y año NO bisesto al no cumplirse la division %400.
                    else
                    {
                        if (mesSelec >= 1 & mesSelec <= 12)
                        {

                            if (mesSelec == 1 | mesSelec == 3 | mesSelec == 5 | mesSelec == 7 | mesSelec == 8 | mesSelec == 10 | mesSelec == 12)
                            {
                                Console.WriteLine("El mes seleccionado tiene 31 dias");

                            }
                            else if (mesSelec == 4 | mesSelec == 6 | mesSelec == 9 | mesSelec == 11)
                            {
                                Console.WriteLine("El mes seleccionado tiene 30 dias");
                            }
                            else
                            {
                                Console.WriteLine("El mes seleccionado tiene 28 dias");
                            }
                        }

                        else
                        {
                            Console.WriteLine("El número marcado no coincide con ningun mes");
                        }
                    }
                }
                // meses y año No bisiesto al no cumplirse la división %100
                else {

                    if (mesSelec >= 1 & mesSelec <= 12)
                    {

                        if (mesSelec == 1 | mesSelec == 3 | mesSelec == 5 | mesSelec == 7 | mesSelec == 8 | mesSelec == 10 | mesSelec == 12)
                        {
                            Console.WriteLine("El mes seleccionado tiene 31 dias");

                        }
                        else if (mesSelec == 4 | mesSelec == 6 | mesSelec == 9 | mesSelec == 11)
                        {
                            Console.WriteLine("El mes seleccionado tiene 30 dias");
                        }
                        else
                        {
                            Console.WriteLine("El mes seleccionado tiene 28 dias");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número marcado no coincide con ningun mes");
                    }

                }


            }
            //meses y año No bisiesto al no cumplirse la divsión %4.
            else {
                if (mesSelec >= 1 & mesSelec <= 12)
                {

                    if (mesSelec == 1 | mesSelec == 3 | mesSelec == 5 | mesSelec == 7 | mesSelec == 8 | mesSelec == 10 | mesSelec == 12)
                    {
                        Console.WriteLine("El mes seleccionado tiene 31 dias");

                    }
                    else if (mesSelec == 4 | mesSelec == 6 | mesSelec == 9 | mesSelec == 11)
                    {
                        Console.WriteLine("El mes seleccionado tiene 30 dias");
                    }
                    else
                    {
                        Console.WriteLine("El mes seleccionado tiene 28 dias");
                    }
                }
                else
                {
                    Console.WriteLine("El número marcado no coincide con ningun mes");
                }

            }

            
           



        }
        



    }
}

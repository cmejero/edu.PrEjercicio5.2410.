using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PrEjercicio5._2410.Servicios
{
    /// <summary>
    /// Implementacion del MenuInterfaz
    /// <author>CMR-061123</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método donde se solicita al usuario la introduccion de un mes mediante un número.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <returns></returns>
        public int pedirMes()
        {
            int Mes;
            Console.WriteLine("Elija un mes (Enero=1, Febrero=2... Diciembre=12)");
            Mes =Convert.ToInt32(Console.ReadLine());

            return Mes;
        }

        /// <summary>
        /// Método donde se solicita al usuario la introduccion de un año mediante un número.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <returns></returns>
        public int pedirAño()
        {
            int año;
            Console.WriteLine("Elija un año");
            año= Convert.ToInt32(Console.ReadLine());
            return año;
           
        }

            
    }
}

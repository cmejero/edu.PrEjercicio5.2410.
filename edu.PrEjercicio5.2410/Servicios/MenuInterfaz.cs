using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PrEjercicio5._2410.Servicios
{

    /// <summary>
    /// Interfaz que declara las solicitudes de números del usuario.
    /// <author>CMR-061123</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra la opción de introducir el mes al usuario.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <returns>devuelve un entero</returns>
        public int pedirMes();

        /// <summary>
        /// Muestra la opción de introducir el año al usuario.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <returns>devuelve un entero</returns>
        public int pedirAño();

    }
}

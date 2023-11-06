using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PrEjercicio5._2410.Servicios
{
    /// <summary>
    /// /// Interfaz que declara los métodos operativos.
    /// <author>CMR-061123</author>
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Solicita la operacion del año y mes que el usuario ha indicado.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <param name="añoSelec"></param>
        /// <param name="mesSelec"></param>
        public void menuBisiesto(int añoSelec , int mesSelec);

        /// <summary>
        /// Solicita al usuario la opción para seguir operando.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <returns></returns>
        public string menuSelecc();

        
    }
}

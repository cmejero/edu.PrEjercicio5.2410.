
using edu.PrEjercicio5._2410.Servicios;

namespace edu.PrEjercicio5._2410.Controladores
{

    /// <summary>
    /// Clase principal de la aplicación
    /// <author>CMR-061123</author>
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Método main de la aplicación, es el núcleo procedimental.
        /// <author>CMR-061123</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
                                  
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();

            int añoSelec = mi.pedirAño();
            int mesSelec = mi.pedirMes();
            oi.menuBisiesto(añoSelec, mesSelec);
                      

            bool cerrarMenu = false;
            string opcionSeleccionada;

            
                opcionSeleccionada = oi.menuSelecc();
                Console.WriteLine(opcionSeleccionada);

                switch(opcionSeleccionada)
                {
                   
                    case "s":
                        
                         Main(args);

                        break;
                    default:
                        cerrarMenu = true;
                        break;

                }
            
            
                
              

                

                    
                    
                        

                





            

            








        }

    }

}
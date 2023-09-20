using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FormAutos_Ejercicio9_G2_2024_1
{
    internal class Automoviles
    {
        private int precio;
        static int[] arregloPrecios;

        public Automoviles(int precio)
        {
            this.precio = precio;
        }
        public static void Asignar()
        {
            
            for (int i = 0; i < 50; i++)
            {
                int precio = 100000;
                Automoviles.arregloPrecios[precio] = precio + 20000;
            }

            for (int i = 0; i < Automoviles.arregloPrecios.Length; i++)
            {
                Console.WriteLine(" ${0} ", arregloPrecios[i]);
            }
        }
        








    }
}

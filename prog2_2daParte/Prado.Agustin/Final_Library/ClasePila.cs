using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Library
{
    public class ClasePila
    {
        // PUNTO 2
        public static Stack<Double> OrdenInverso(Stack<Double> pilaOriginal)
        {
            Stack<Double> pilaNueva = new Stack<double>();          
            while(pilaOriginal.Count >= 1)
            {
                pilaNueva.Push(pilaOriginal.Pop());
            }
            return pilaNueva;
        }
    }
}

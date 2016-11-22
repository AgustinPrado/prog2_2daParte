using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Moneda moneda = new Moneda();
            // para pasarle la posicion de memoria del metodo manejador al delegado.
            moneda.EventoGanar += new DelegadoMoneda(Program.ManejadorGanar);
            moneda.EventoPerder += new DeleMon(p.ManejadorPerder);

            for (int i = 0; i < 20; i++)
            {
                moneda.Tirar(ELado.Cara);
            }

            Console.ReadKey();
        }

        // misma firma que el delegado.
        public static void ManejadorGanar()
        {
            Console.WriteLine("USTED GANÓ!!!");
        }

        public void ManejadorPerder(ELado lado)
        {
            Console.WriteLine("USTED PERDIÓ!!! El lado era: " + lado.ToString());
        }
    }
}

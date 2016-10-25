using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_8_Library;

namespace ConsoleApp
{
    public class Vista : IGrafica
    {
        public void Main()
        {
            Empleado emp = new Empleado("Agustin", "Prado", "104303", Empleado.EPuestoJerarquico.Sistemas, 14000);
            emp.Mostrar(this);
        }

        void IGrafica.MostrarEnGUI(string cadena)
        {
            Console.WriteLine(cadena);
        }
    }
}

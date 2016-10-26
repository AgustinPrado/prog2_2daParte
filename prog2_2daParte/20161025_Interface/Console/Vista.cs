using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_8_Library;
using System.IO;

namespace ConsoleApp
{
    public class Vista : IGrafica
    {
        
        private Empleado emp;

        public Vista()
        {
            emp = new Empleado("Agustin", "Prado", "104303", Empleado.EPuestoJerarquico.Sistemas, 14000);
        }

        public void Main()
        {
            emp.Mostrar(this);
        }

        void IGrafica.MostrarEnGUI(string cadena)
        {
            Console.WriteLine(cadena);
        }


        bool IGrafica.EscribirTxt(string path, string cadena)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);

                sw.Write(cadena);

                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.InnerException.ToString());
                return false;
            }
            
        }

        bool IGrafica.LeerTxt(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);

                Console.WriteLine("Texto del archivo:");
                Console.WriteLine(sr.ReadToEnd());

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.InnerException.ToString());
                return false;
            }
        }
    }
}

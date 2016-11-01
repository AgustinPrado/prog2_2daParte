using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            string cadena = "Hola";
            string aux;

            string pathTexto = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\texto.txt";
            string pathXml = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\texto.xml";

            Texto text = new Texto();

            text.guardar(pathTexto, num.ToString());
            text.guardar(pathTexto, cadena);

            text.leer(pathTexto, out aux);

            Console.WriteLine("En el archivo hay: " + aux);

            Console.ReadKey();

            Xml<string> xmlFile = new Xml<string>();

            xmlFile.guardar(pathXml, cadena);
            xmlFile.leer(pathXml, out aux);

            Console.WriteLine("En el archivo xml hay: " + aux);

            Console.ReadKey();
        }
    }
}

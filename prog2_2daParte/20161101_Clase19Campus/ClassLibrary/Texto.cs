using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class Texto : IArchivo<string>
    {
        public bool guardar(string archivo, string datos)
        {
            try
            {
                StreamWriter sw = new StreamWriter(archivo, true);

                sw.Write(datos);

                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al guardar: " + e.ToString());
                return false;
            }
        }

        public bool leer(string archivo, out string datos)
        {
            try
            {
                StreamReader sr = new StreamReader(archivo);

                datos = sr.ReadToEnd();

                sr.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer: " + e.ToString());

                datos = "";

                return false;
            }
        }
    }
}

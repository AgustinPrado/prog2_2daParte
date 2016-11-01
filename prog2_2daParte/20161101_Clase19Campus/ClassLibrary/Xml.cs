using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class Xml<T> : IArchivo<T>
    {

        public bool guardar(string archivo, T datos)
        {
            XmlSerializer ser;
            XmlTextWriter writer;

            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));

                ser.Serialize(writer, datos);

                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la escritura:");
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool leer(string archivo, out T datos)
        {
            XmlSerializer ser;
            XmlTextReader reader;

            try
            {
                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(T));

                datos = (T)ser.Deserialize(reader);

                reader.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura:");
                Console.WriteLine(e.ToString());

                datos = default(T);

                return false;
            }
        }
    }
}

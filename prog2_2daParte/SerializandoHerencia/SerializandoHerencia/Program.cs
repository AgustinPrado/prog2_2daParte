using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace SerializandoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro e instancio una lista genérica de tipo ClaseAbstracta
            List<ClaseAbstracta> lista = new List<ClaseAbstracta>();

            //Agrego elementos a la lista (recordar que las clases abstractas no se pueden instanciar)
            lista.Add(new ClaseHija1(1, "Cadena1", 1.1));
            lista.Add(new ClaseHija2(2, "Cadena2", true));
            lista.Add(new ClaseHija1(3, "Cadena3", 2.2));
            lista.Add(new ClaseHija2(4, "Cadena4", false));


            try
            {
                //Utilizo un objeto de tipo XmlTextWriter para poder escribir en un archivo XML.
                using (XmlTextWriter writer = new XmlTextWriter("C:\\DatosListaHerencia.xml", System.Text.Encoding.UTF8))
                {
                    //Utilizo un objeto de tipo XmlSerializer para serializar la lista genérica.
                    XmlSerializer ser = new XmlSerializer((typeof(List<ClaseAbstracta>)));
                    //Serializo
                    ser.Serialize(writer, lista);
                }

                Console.WriteLine("Objetos serializados con exito!!!");
                Console.Read();

                Console.WriteLine("Deserializando...");
                Console.Read();
                Console.Clear();

                //Utilizo un objeto de tipo XmlTextReader para poder leer de un archivo XML.
                using (XmlTextReader reader = new XmlTextReader("C:\\DatosListaHerencia.xml"))
                {
                    //Utilizo un objeto de tipo XmlSerializer para deserializar la lista genérica.
                    XmlSerializer ser = new XmlSerializer((typeof(List<ClaseAbstracta>)));

                    //Deserializo
                    lista = (List<ClaseAbstracta>)ser.Deserialize(reader);
                }


                //Por último recorro la lista genérica y muestro sus elementos
                foreach (ClaseAbstracta item in lista)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error al Serializar los Datos");
            }


            Console.ReadLine();
        }
        /*
         * Utilizar la depuración paso a paso para poder observar el proceso de 
         * serialización y deserialización de la lista genérica.
         * Realizar la misma observación al momento de recorrer y mostrar los
         * ítems de la lista de tipo ClaseAbstracta
         */
    }
}

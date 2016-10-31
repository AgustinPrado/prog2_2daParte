using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializacion.Entidades;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion.Test
{
    public class Program
    {
        private const string pathPersona = "C:\\persona.xml";
        private const string pathListaPersonas = "C:\\misPersonas.xml";
        private const string pathListaAlumnos = "C:\\misAlumnos.xml";
        private const string pathListaPersonasAlumnos = "C:\\misPersonasAlumnos.xml";

        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Agustin", "Prado", 37143078);
            Persona persona2 = new Persona("Santiado", "Prado", 12345678);
            Persona persona3 = new Persona("Carolina", "Sin", 85963744);

            Alumno alu1 = new Alumno(10, 444);
            Alumno alu2 = new Alumno(5, 99999);

            XmlSerializer ser;
            XmlTextWriter writer;
            XmlTextReader reader;

            List<Persona> listaPersona = new List<Persona>();
            List<Alumno> listaAlumno = new List<Alumno>();

            try
            {
                writer = new XmlTextWriter(pathPersona, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Persona));

                ser.Serialize(writer, persona1);

                writer.Close();
                Console.WriteLine("Se escribió persona satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la escritura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


            try
            {
                reader = new XmlTextReader(pathPersona);
                ser = new XmlSerializer(typeof(Persona));

                Persona aux = (Persona)ser.Deserialize(reader);

                Console.WriteLine(aux.ToString());

                reader.Close();
                Console.WriteLine("Se leyó satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


            listaPersona.Add(persona1);
            listaPersona.Add(persona2);
            listaPersona.Add(persona3);
            try
            {
                writer = new XmlTextWriter(pathListaPersonas, Encoding.UTF8);
                ser = new XmlSerializer(typeof(List<Persona>));

                ser.Serialize(writer, listaPersona);

                writer.Close();
                Console.WriteLine("Se escribió lista de personas satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la escritura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


            try
            {
                reader = new XmlTextReader(pathListaPersonas);
                ser = new XmlSerializer(typeof(List<Persona>));

                List<Persona> aux = (List<Persona>)ser.Deserialize(reader);

                foreach (Persona item in aux)
                {
                    Console.WriteLine(item.ToString());
                }

                reader.Close();
                Console.WriteLine("Se leyó lista de personas satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }



            listaAlumno.Add(alu1);
            listaAlumno.Add(alu2);
            try
            {
                writer = new XmlTextWriter(pathListaAlumnos, Encoding.UTF8);
                ser = new XmlSerializer(typeof(List<Alumno>));

                ser.Serialize(writer, listaAlumno);

                writer.Close();
                Console.WriteLine("Se escribió lista de alumnos satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la escritura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


            try
            {
                reader = new XmlTextReader(pathListaAlumnos);
                ser = new XmlSerializer(typeof(List<Alumno>));

                List<Alumno> aux = (List<Alumno>)ser.Deserialize(reader);

                foreach (Alumno item in aux)
                {
                    Console.WriteLine(item.ToString());
                }

                reader.Close();
                Console.WriteLine("Se leyó lista de personas satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }





            listaPersona.Add(alu1);
            listaPersona.Add(alu2);
            try
            {
                writer = new XmlTextWriter(pathListaPersonasAlumnos, Encoding.UTF8);
                ser = new XmlSerializer(typeof(List<Persona>));

                ser.Serialize(writer, listaPersona);

                writer.Close();
                Console.WriteLine("Se escribió lista de personas y alumnos satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la escritura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }

            try
            {
                reader = new XmlTextReader(pathListaPersonasAlumnos);
                ser = new XmlSerializer(typeof(List<Persona>));

                List<Persona> aux = (List<Persona>)ser.Deserialize(reader);

                foreach (Persona item in aux)
                {
                    Console.WriteLine(item.ToString());
                }

                reader.Close();
                Console.WriteLine("Se leyó lista de personas y alumnos satisfactoriamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}

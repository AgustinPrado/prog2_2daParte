using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Empleado : Persona, IArchivos<Empleado>
    {
        //private string _nombre;
        //private string _apellido;

        private int _legajo;

        protected override int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public Empleado(string nombre, string apellido, int legajo)
            : base(nombre, apellido)
        {
            //this._nombre = nombre;
            //this._apellido = apellido;
            this.Legajo = legajo;
        }

        public Empleado()
        {
            // Para poder serializar.
        }

        public static string MostrarDatos(Empleado e)
        {
            return e.ToString();
        }

        public bool guardar(string archivo, Empleado datos)
        {
            XmlTextWriter writer;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Empleado));

                ser.Serialize(writer, datos);

                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new NoGuardoException(e);
            }
        }

        public bool leer(string archivo, out Empleado datos)
        {
            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(Empleado));

                datos = (Empleado)ser.Deserialize(reader);

                reader.Close();

                return true;
            }
            catch (Exception e)
            {
                datos = default(Empleado);
                throw new NoLeeException(e);
            }
        }
    }
}

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
    public class Empleado : Persona, IArchivos<object>
    {
        //private string _nombre;
        //private string _apellido;

        private string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\empleado.xml";

        private Empleado empAux;
        public Empleado EmpleadoLeido
        {
            get { return this.empAux; }
        }

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

        public void guardar(object datos)
        {
            XmlTextWriter writer;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(this.archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Empleado));

                ser.Serialize(writer, datos);

                writer.Close();
            }
            catch (Exception e)
            {
                throw new NoGuardoException(e);
            }
        }

        public void leer()
        {
            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(this.archivo);
                ser = new XmlSerializer(typeof(Empleado));

                this.empAux = (Empleado)ser.Deserialize(reader);

                reader.Close();
            }
            catch (Exception e)
            {
                this.empAux = default(Empleado);
                throw new NoLeeException(e);
            }
        }
    }
}

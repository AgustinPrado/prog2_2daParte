using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion.Entidades
{
    [Serializable]
    // para que me reconozca en las listas esta clase hija.
    [XmlInclude(typeof(Alumno))]
    public class Persona
    {
        private string _nombre;
        public string Nombre
        {
            set
            {
                this._nombre = value;
            }
            get
            {
                return this._nombre;
            }
        }
        private string _apellido;
        public string Apellido
        {
            set
            {
                this._apellido = value;
            }
            get
            {
                return this._apellido;
            }
        }
        private long _dni;
        public long DNI
        {
            set
            {
                this._dni = value;
            }
            get
            {
                return this._dni;
            }
        }

        public Persona(string nombre, string apellido, long dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
        }
        public Persona()
        {

        }

        public static void MostrarPersona(Persona p)
        {
            Console.WriteLine(p.ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Dni: " + this.DNI.ToString());
            return sb.ToString();
        }

    }
}


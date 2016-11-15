using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Empleado))]
    public abstract class Persona
    {
        private string _nombre;
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }
        private string _apellido;
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }
        protected abstract int Legajo { set; get; }

        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public Persona()
        {
            // Para poder serializar.
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.AppendLine("NOMBRE: " + this.Nombre);
            sBuilder.AppendLine("APELLIDO: " + this.Apellido);
            sBuilder.AppendLine("LEGAJO: " + this.Legajo);
            sBuilder.AppendLine("<------------------------------->");
            return sBuilder.ToString();
        }
    }
}

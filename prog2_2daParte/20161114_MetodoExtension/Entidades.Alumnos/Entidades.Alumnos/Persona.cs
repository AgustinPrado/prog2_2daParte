using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
    public class Persona
    {
        protected string _nombre;
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }
        protected string _apellido;
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }
        protected int _edad;
        public int Edad
        {
            get
            { 
                return this._edad; 
            }
        }
        protected ESexo _sexo;
        public ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Su nombre es: " + this.Nombre);
            sb.AppendLine("Su apellido es: " + this.Apellido);
            sb.AppendLine("Su edad es: " + this.Edad);
            sb.AppendLine("Su sexo es: " + this.Sexo.ToString());

            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion.Entidades
{
    [Serializable]
    public class Alumno : Persona
    {
        public int nota;
        public int legajo;

        public Alumno()
            : base()
        {

        }
        public Alumno(int nota, int legajo)
            : base("NOMBRE", "APELLIDO", 1111)
        {
            this.nota = nota;
            this.legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Nota: " + this.nota.ToString());
            sb.AppendLine("Legajo: " + this.legajo.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

    }
}

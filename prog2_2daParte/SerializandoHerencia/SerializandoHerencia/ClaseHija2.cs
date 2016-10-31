using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializandoHerencia
{
    /* Defino la clase derivada como pública (recordar que la serialización XML solo serializa miembros públicos).
     * Defino que dicha clase se va a poder serializar a XML ([Serializable])
     * Defino el constructor por defecto (recordar que sin el constructor por defecto no se podrá serializar)
     * Agrego los atributos a la clase (si no son públicos, colocar propiedades de lectura/escritura)
     * Por último, aplico polimorfismo sobre el método ToString().
     */
    [Serializable]
    public class ClaseHija2 : ClaseAbstracta
    {
        public bool datoBooleano;

        public ClaseHija2()
        { 
        }

        public ClaseHija2(int datoEntero, string datoTexto, bool datoBoolean)
            : base(datoEntero, datoTexto)
        {
            this.datoBooleano = datoBoolean;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("######################################");
            sb.AppendLine(base.ToString());

            sb.AppendLine("Datos de la Clase Hija2");
            sb.AppendLine(this.datoBooleano.ToString());
            sb.AppendLine("######################################");
            sb.AppendLine();

            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializandoHerencia
{
    /* Defino la clase abstracta como pública (recordar que la serialización XML solo serializa miembros públicos).
     * Defino que dicha clase se va a poder serializar a XML ([Serializable])
     * Indico también que las clases derivadas (ClaseHija1 y ClaseHija2) se deben incluir en la serialización.
     * Defino el constructor por defecto (recordar que sin el constructor por defecto no se podrá serializar)
     * Agrego los atributos a la clase (si no son públicos, colocar propiedades de lectura/escritura)
     * Por último, aplico polimorfismo sobre el método ToString().
     */
    [Serializable]
    [XmlInclude(typeof(ClaseHija1))]
    [XmlInclude(typeof(ClaseHija2))]
    public abstract class ClaseAbstracta
    {
        protected int _datoEntero;
        protected string _datoTexto;

        public int DatoEntero 
        { 
            get
            {
                return this._datoEntero;
            }
            set
            {
                this._datoEntero = value;
            }
        }

        public string DatoTexto
        {
            get
            {
                return this._datoTexto;
            }
            set
            {
                this._datoTexto = value;
            }
        }

        public ClaseAbstracta()
        { 
        }

        public ClaseAbstracta(int datoEntero, string datoTexto)
        {
            this._datoEntero = datoEntero;
            this._datoTexto = datoTexto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la Clase Padre");
            sb.AppendLine(this._datoEntero.ToString());
            sb.AppendLine(this._datoTexto);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}

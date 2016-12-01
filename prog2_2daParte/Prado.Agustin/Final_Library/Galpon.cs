using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Final_Library
{
    public delegate void DelegadoCantidad(Object obj, EventArgs args);

    [Serializable]
    public class Galpon<T> : IGuardarXML
    {
        public List<T> lista;
        private int _cantidad;

        public int Cantidad
        {
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El valor a ingresar fue 0");
                }
                else if (value.EsImpar())
                {
                    this.EsImpar(value, new EventArgs());
                }
                this._cantidad = value;
            }
        }

        public event DelegadoCantidad EsImpar;

        public bool SerializarXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Galpon<Deposito>));


            return false;
        }
    }
}

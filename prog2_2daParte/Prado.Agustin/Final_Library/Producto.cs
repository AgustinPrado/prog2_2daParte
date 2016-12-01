using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_Library
{
    [Serializable]
    [XmlInclude(typeof(ProdVendido)), XmlInclude(typeof(ProdImpuesto)), XmlInclude(typeof(ProdExport)), XmlInclude(typeof(Deposito)), XmlInclude(typeof(Galpon<Deposito>))]
    public class Producto
    {
        public string Nombre;
        public int Stock;

        public Producto(string nombre, int stock)
        {
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public Producto()
        {
            // para serializar.
        }

        public static bool operator ==(Producto uno, Producto dos)
        {
            if (uno.Nombre == dos.Nombre)
                return true;
            return false;
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }
    }
}

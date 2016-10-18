using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161017_Pintura
{
    public class Pintura
    {
        private int _cantidad;
        public int Cantidad
        {
            set
            {
                this._cantidad = value;
            }
            get
            {
                return this._cantidad;
            }
        }

        public Pintura(int cantidad)
        {
            this.Cantidad = cantidad;
        }

        public static bool operator ==(Pintura pinturaUno, Pintura pinturaDos)
        {
            return (pinturaUno.Cantidad == pinturaDos.Cantidad);
        }

        public static bool operator !=(Pintura pinturaUno, Pintura pinturaDos)
        {
            return !(pinturaUno == pinturaDos);
        }

        public override string ToString()
        {
            return this.Cantidad.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Pintura);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161017_Pintura
{
    public class DepoPintura
    {
        private List<Pintura> _lista;
        private int _cantMax;

        public DepoPintura(int _cantMax)
        {
            this._cantMax = _cantMax;
            this._lista = new List<Pintura>();
        }

        public static bool operator +(DepoPintura deposito, Pintura pintura)
        {
            if (deposito._cantMax > deposito._lista.Count)
            {
                if (deposito != pintura)
                {
                    deposito._lista.Add(pintura);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(DepoPintura deposito, Pintura pintura)
        {
            foreach (Pintura item in deposito._lista)
            {
                if (item == pintura)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(DepoPintura deposito, Pintura pintura)
        {
            return !(deposito == pintura);
        }

        public bool Agregar(Pintura pintura)
        {
            return (this + pintura);
        }

        public bool EstaEnElDeposito(Pintura pintura)
        {
            return (this == pintura);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nLa cantidad máxima es: " + this._cantMax);

            foreach (Pintura item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}

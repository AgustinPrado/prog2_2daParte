using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161017_Pintura
{
    public class DepoAuto
    {
        private List<Auto> _lista;
        private int _cantMax;
        
        public DepoAuto(int _cantMax)
        {
            this._cantMax = _cantMax;
            this._lista = new List<Auto>();
        }

        public static bool operator +(DepoAuto deposito, Auto auto)
        {
            if (deposito._cantMax > deposito._lista.Count)
            {
                if (deposito != auto)
                {
                    deposito._lista.Add(auto);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(DepoAuto deposito, Auto auto)
        {
            foreach (Auto item in deposito._lista)
            {
                if (item == auto)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(DepoAuto deposito, Auto auto)
        {
            return !(deposito == auto);
        }

        public bool Agregar(Auto auto)
        {
            return (this + auto);
        }

        public bool EstaEnElDeposito(Auto auto)
        {
            return (this == auto);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nLa cantidad máxima es: " + this._cantMax);

            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}

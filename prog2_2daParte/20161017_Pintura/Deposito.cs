using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161017_Pintura
{
    // al poner <T> la hago genérica
    public class Deposito <T>
    {
        private List<T> _lista;
        private int _cantMax;
        
        public Deposito(int _cantMax)
        {
            this._cantMax = _cantMax;
            this._lista = new List<T>();
        }

        public static bool operator +(Deposito<T> deposito, T obj)
        {
            if (deposito._cantMax > deposito._lista.Count)
            {
                if (deposito != obj)
                {
                    deposito._lista.Add(obj);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Deposito<T> deposito, T obj)
        {
            foreach (T item in deposito._lista)
            {
                if (item.Equals(obj))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Deposito<T> deposito, T obj)
        {
            return !(deposito == obj);
        }

        public bool Agregar(T obj)
        {
            return (this + obj);
        }

        public bool EstaEnElDeposito(T obj)
        {
            return (this == obj);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nLa cantidad máxima es: " + this._cantMax);

            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}

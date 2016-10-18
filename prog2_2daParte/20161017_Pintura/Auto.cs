using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161017_Pintura
{
    public class Auto
    {
        private string _marca;
        public string Marca
        {
            get
            {
                return this._marca;
            }
        }
        private string _color;
        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public Auto(string marca, string color)
        {
            this._marca = marca;
            this._color = color;
        }

        public static bool operator ==(Auto autoUno, Auto autoDos)
        {
            if (String.Compare(autoUno.Marca, autoDos.Marca) == 0)
            {
                if (String.Compare(autoUno.Color, autoDos.Color) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }

        public override string ToString()
        {
            return "La marca es " + this.Marca + " y el color es " + this.Color;
        }

        public override bool Equals(object obj)
        {
            if (obj is Auto)
            {
                if (this == (Auto)obj)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

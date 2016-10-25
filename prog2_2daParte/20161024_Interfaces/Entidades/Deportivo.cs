using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp)
            : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        double IAFIP.CalcularImpuesto()
        {
            return this.Precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this.Precio * 0.23;
        }
 

        public override void MostrarPatente()
        {
            Console.WriteLine("La patente del auto deportivo es " + this._patente);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio del auto deportivo es " + this.Precio);
        }

        public override double Precio
        {
            get { return this._precio; }
        }

        double IAFIP.Impuesto
        {
            get
            {
                return ((IAFIP)this).CalcularImpuesto();
            }
        }
    }
}

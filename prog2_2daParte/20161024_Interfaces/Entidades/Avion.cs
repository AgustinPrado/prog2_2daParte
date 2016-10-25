using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            :base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double IAFIP.CalcularImpuesto()
        {
            return this.Precio * 0.33;
        }
        
        double IARBA.CalcularImpuesto()
        {
            return this.Precio * 0.27;
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

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio del avion es " + this.Precio);
        }
    }
}

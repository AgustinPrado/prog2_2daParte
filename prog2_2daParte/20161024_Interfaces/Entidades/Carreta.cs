using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta:Vehiculo, IARBA
    {
        public Carreta(double precio)
            : base(precio)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio de la carreta es " + this.Precio);
        }

        public override double Precio
        {
            get { return this._precio; }
        }

        double IARBA.CalcularImpuesto()
        {
            return this.Precio * 0.18;
        }
    }
}

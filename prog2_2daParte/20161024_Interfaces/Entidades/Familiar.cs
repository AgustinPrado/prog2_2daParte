﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos)
            : base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }


        public override void MostrarPatente()
        {
            Console.WriteLine("La patente del auto familiar es " + this._patente);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio del auto familiar es " + this.Precio);
        }

        public override double Precio
        {
            get { return this._precio; }
        }
    }
}

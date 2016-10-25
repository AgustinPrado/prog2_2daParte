﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado : Avion
    {
        protected int _valoracionServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion)
            : base(precio, velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio del avion privado es " + this.Precio);
        }

    }
}

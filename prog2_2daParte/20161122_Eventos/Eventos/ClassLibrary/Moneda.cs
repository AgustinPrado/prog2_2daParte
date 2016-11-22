using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // solo almacena direcciones de memoria de metodos.
    public delegate void DelegadoMoneda();
    public delegate void DeleMon(ELado lado);

    public class Moneda
    {
        public event DelegadoMoneda EventoGanar;
        public event DeleMon EventoPerder;

        private static Random _random;
        private ELado _lado;
        public ELado Lado
        {
            get
            {
                return this._lado;
            }
        }

        static Moneda()
        {
            _random = new Random();
        }

        public Moneda()
        {
            this.CambiarLado();
        }

        public void Tirar(ELado lado)
        {
            if (lado == this.Lado)
                this.EventoGanar();
            else
                this.EventoPerder(this.Lado);

            this.CambiarLado();
        }

        private void CambiarLado()
        {
            this._lado = (ELado)_random.Next(0, 2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161011
{
    public class Numero
    {
        protected double _numero;
        public double ValorNumero
        {
            get
            {
                return this._numero;
            }
        }

        #region CONSTRUCTORES
        public Numero(double numero)
        {
            this._numero += numero;
            this.Asignar(numero);
            
        }
        #endregion

        private double Asignar(double numero)
        {
            return Numero.Validar(numero);
        }

        private static double Validar(double numero)
        {
            if (numero > 0)
                return numero;
            else
                throw new Exception("El número " + numero + " no es mayor a 0.");
        }       
    }
}

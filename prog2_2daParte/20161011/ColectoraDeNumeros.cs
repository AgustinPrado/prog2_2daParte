using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161011
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;
        private static Numero Contador;

        #region CONSTRUCTORES
        public ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        static ColectoraDeNumeros()
        {
            ColectoraDeNumeros.Contador = new Numero(0);
        }
        #endregion

        #region METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Numero item in this._numeros)
            {
                sb.AppendLine(item.ValorNumero.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static ColectoraDeNumeros operator +(ColectoraDeNumeros colectora, Numero numero)
        {
            if (Verificadora.VerificarNumero(numero, Verificadora.ETipoNumero.Par))
                colectora._numeros.Add(numero);
            else
                throw new Exception("El número " + numero.ValorNumero.ToString() + " no es par.");
            return colectora;
        }
        #endregion
    }
}

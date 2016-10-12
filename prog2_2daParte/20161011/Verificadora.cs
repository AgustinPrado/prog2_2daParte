using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161011
{
    public class Verificadora
    {
        public enum ETipoNumero
        {
            Par,
            Impar,
            Positivo,
            Negativo,
            Cero
        }

        public static bool VerificarNumero(Numero numero, ETipoNumero tipo)
        {
            switch (tipo)
            {
                case ETipoNumero.Par:
                    return ((numero.ValorNumero % 2) == 0);

                case ETipoNumero.Impar:
                    return !(Verificadora.VerificarNumero(numero, ETipoNumero.Par));

                case ETipoNumero.Positivo:
                    return (numero.ValorNumero > 0);

                case ETipoNumero.Negativo:
                    return (numero.ValorNumero < 0);

                case ETipoNumero.Cero:
                    return (numero.ValorNumero == 0);

                default:
                    return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
    public static class PersonaEstatica
    {
        public static string ObtenerInfo(this Externa.Sellada.PersonaExternaSellada p)
        {
            return "SIMULA QUE ESTÁ DENTRO DE LA CLASE SELLADA.";
        }

        public static bool EsNulo(this Object obj)
        {
            return (obj == null);
        }

        public static bool EsPrimo(this Int32 num)
        {
            int cont = 0;
            for (int i = 1; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    cont++;
                }
            }
            if (cont >= 2)
                return false;
            return true;
        }

        public static Int32 CantidadLetras(this String cadena)
        {
            return cadena.Length;
        }
    }
}

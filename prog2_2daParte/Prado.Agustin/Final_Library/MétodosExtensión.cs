using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Library
{
    public static class MétodosExtensión
    {
        // PUNTO 1
        public static bool EsPar(this Int32 obj)
        {
            if ((obj % 2) == 0)
                return true;
            return false;
        }

        public static bool EsImpar(this Int32 obj)
        {
            return !(obj.EsPar());
        }
    }
}

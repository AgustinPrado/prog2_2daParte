using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivos<T>
    {
        void guardar(T datos);
        void leer();
    }
}

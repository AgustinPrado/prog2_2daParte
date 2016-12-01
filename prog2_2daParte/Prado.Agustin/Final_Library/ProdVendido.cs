using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Library
{
    [Serializable]
    public class ProdVendido : Producto
    {
        public int Cantidad;

        public ProdVendido()
            : base()
        {

        }
    }
}

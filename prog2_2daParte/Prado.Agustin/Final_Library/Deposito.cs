using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Library
{
    [Serializable]
    public class Deposito
    {
        public List<Producto> Lista;

        public Deposito()
        {
            this.Lista = new List<Producto>();
        }

        public static List<Producto> operator +(Deposito uno, Deposito dos)
        {
            List<Producto> lista = new List<Producto>();
            bool estaEnLaLista = false;
            
            foreach (Producto itemUno in uno.Lista)
            {
                lista.Add(itemUno);
            }
            foreach (Producto itemDos in dos.Lista)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (itemDos == lista[i])
                    {
                        lista[i].Stock += itemDos.Stock;
                        estaEnLaLista = true;
                    }
                }
                if (!estaEnLaLista)
                {
                    lista.Add(itemDos);
                }
            }

            return lista;
        }
    }
}

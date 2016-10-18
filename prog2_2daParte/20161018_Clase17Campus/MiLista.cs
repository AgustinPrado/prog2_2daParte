using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161018_Clase17Campus
{
    public class MiLista <T>
    {
        public T[] lista;

        public int Count
        {
            get
            {
                return this.lista.Length;
            }
        }

        public MiLista()
        {
            this.lista = new T[0];
        }

        public void Add(T obj)
        {
            Array.Resize(ref this.lista, this.lista.Length + 1);

            this.lista[this.lista.Length-1] = obj;
        }

        public void Remove(T obj)
        {
            //T[] aux = new T[this.lista.Length - 1];

            for (int i = 0; i < this.lista.Length; i++)
            {
                if (this.lista[i].Equals(obj))
                {
                    for (int j = i; j < this.lista.Length - 1; j++)
                    {
                        this.lista[j] = this.lista[j + 1];
                    }
                    Array.Resize(ref this.lista, this.lista.Length - 1);
                    break;
                    //if (i > 0)
                    //    Array.ConstrainedCopy(this.lista, 0, aux, 0, i);
                    //if (i < this.lista.Length)
                    //    Array.ConstrainedCopy(this.lista, i + 1, aux, i, this.lista.Length - i - 1);
                    //break;
                }
            }


            //Array.Resize(ref this.lista, this.lista.Length - 1);
            //Array.ConstrainedCopy(aux, 0, this.lista, 0, this.lista.Length);
        }

        //#region IEnumerable<T> Members

        //public IEnumerator<T> GetEnumerator()
        //{
        //    foreach (T item in this.lista)
        //    {
        //        yield return item;
        //    }
        //}

        //#endregion

        //#region IEnumerable Members

        //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //{
        //    for (int i = 0; i < this.lista.Length; i++)
        //    {
        //        // Yield each day of the week.
        //        yield return this.lista[i];
        //    }
        //}

        //#endregion

    }
}

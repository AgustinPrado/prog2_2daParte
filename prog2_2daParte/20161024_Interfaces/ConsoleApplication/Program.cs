using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado avionPrivado = new Privado(500000, 700, 9);
            Comercial avionComercial = new Comercial(700000, 600, 100);

            Deportivo autoDeportivo = new Deportivo(300000, "ABC123", 300);
            Familiar autoFamiliar = new Familiar(40000, "XYZ123", 5);

            Carreta vehiculoCarreta = new Carreta(100);

            List<Vehiculo> lista = new List<Vehiculo>();
            lista.Add(avionPrivado);
            lista.Add(avionComercial);
            lista.Add(autoDeportivo);
            lista.Add(autoFamiliar);
            lista.Add(vehiculoCarreta);

            foreach (Vehiculo item in lista)
            {
                item.MostrarPrecio();
            }

            Console.ReadKey();

        }
    }
}

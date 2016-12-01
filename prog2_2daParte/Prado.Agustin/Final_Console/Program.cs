using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Library;
using System.IO;

namespace Final_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // PUNTO 2
            Stack<Double> pila = new Stack<double>();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            pila = ClasePila.OrdenInverso(pila);

            // PUNTO 3
            Deposito depo1 = new Deposito();
            Deposito depo2 = new Deposito();
            Producto prod1 = new Producto("Helado", 5);
            Producto prod2 = new Producto("Azucar", 5);
            Producto prod3 = new Producto("Carne", 5);
            Producto prod4 = new Producto("Helado", 5);

            depo1.Lista.Add(prod1);
            depo1.Lista.Add(prod2);
            depo2.Lista.Add(prod3);
            depo2.Lista.Add(prod4);

            List<Producto> lista = depo1 + depo2;

            // PUNTO 4

            Galpon<int> galpon = new Galpon<int>();

            galpon.EsImpar += new DelegadoCantidad(Program.Manejador);

            try
            {
                galpon.Cantidad = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR AL ESCRIBIR EN ARCHIVO: " + e.Message); 
            }
            

        }

        public static void Manejador(Object obj, EventArgs args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\log.txt";
            DateTime time = new DateTime();
            
            // No uso try-catch ya que lo estoy capturando el error en el main.
            StreamWriter sr = new StreamWriter(path, true);

            time = DateTime.Now;
            sr.WriteLine(time.ToLongTimeString() + "  " + ((int)obj).ToString());

            sr.Close();
        }
    }
}

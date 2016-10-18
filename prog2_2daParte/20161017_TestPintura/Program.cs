using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20161017_Pintura;

namespace _20161017_TestPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito<Auto> depoAuto = new Deposito<Auto>(5);
            Deposito<Pintura> depoPintura = new Deposito<Pintura>(5);

            //DepoPintura depoPintura = new DepoPintura(5);
            //DepoAuto depoPintura = new DepoAuto(5);

            Pintura p1 = new Pintura(1);
            Pintura p2 = new Pintura(2);
            Pintura p3 = new Pintura(3);
            Pintura p4 = new Pintura(1);
            Pintura p5 = new Pintura(4);
            Pintura p6 = new Pintura(8);
            Pintura p7 = new Pintura(10);

            if (!(depoPintura.Agregar(p1)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p2)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p3)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p4)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p5)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p6)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p7)))
                Console.WriteLine("No se pudo agregar pintura");
            if (!(depoPintura.Agregar(p1)))
                Console.WriteLine("No se pudo agregar pintura");

            Console.WriteLine(depoPintura.ToString());

            if (depoPintura.EstaEnElDeposito(p2))
                Console.WriteLine("La pintura está en el depósito");
            if (depoPintura.EstaEnElDeposito(p5))
                Console.WriteLine("La pintura está en el depósito");
            if (depoPintura.EstaEnElDeposito(p7))
                Console.WriteLine("La pintura está en el depósito");

            Console.ReadKey();

            Auto a1 = new Auto("Ford", "Azul");
            Auto a2 = new Auto("Ford", "Verde");
            Auto a3 = new Auto("Ford", "Rojo");
            Auto a4 = new Auto("Ford", "Azul");
            Auto a5 = new Auto("Renault", "Azul");
            Auto a6 = new Auto("Renault", "Rojo");
            Auto a7 = new Auto("Renault", "Negro");

            if (!(depoAuto.Agregar(a1)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a2)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a3)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a4)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a5)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a6)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a7)))
                Console.WriteLine("No se pudo agregar auto");
            if (!(depoAuto.Agregar(a1)))
                Console.WriteLine("No se pudo agregar auto");

            Console.WriteLine(depoAuto.ToString());

            if (depoAuto.EstaEnElDeposito(a2))
                Console.WriteLine("El auto está en el depósito");
            if (depoAuto.EstaEnElDeposito(a5))
                Console.WriteLine("El auto está en el depósito"); 
            if (depoAuto.EstaEnElDeposito(a7))
                Console.WriteLine("El auto está en el depósito");

            Console.ReadKey();

        }
    }
}

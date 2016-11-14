using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;

namespace AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Agustin", "Prado", 24, ESexo.Masculino);
            //Entidades.Externa.PersonaExterna perExt = new Entidades.Externa.PersonaExterna("Agus", "Prado", 19, Entidades.Externa.ESexo.Masculino);
            //PersonaHeredada perHer = new PersonaHeredada("Santi", "Prado", 19, Entidades.Externa.ESexo.Masculino);
            Entidades.Externa.Sellada.PersonaExternaSellada perSell = new Entidades.Externa.Sellada.PersonaExternaSellada("Santi", "Prado", 19, Entidades.Externa.ESexo.Masculino);
            
            Console.WriteLine(per.ToString());

            //Console.WriteLine(perExt.ToString());

            //Console.WriteLine(perHer.ToString());

            Console.WriteLine(perSell.ObtenerInfo());


            string cadena = "agu5555555555555555555stin";

            Console.WriteLine("Cant letras: " + cadena.CantidadLetras());
            

            Console.ReadKey();
        }

        
    }
}

/*
 * Metodo de extension
 * Tienen que estar en una clase estatica.
 * Por ende, tiene metodos estaticos.
 * Definir un public static string ObtenerInfo()
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20161011;

namespace TestNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ColectoraDeNumeros cn = new ColectoraDeNumeros();

                //Numero n1 = new Numero(23);
                Numero n2 = new Numero(56);
                Numero n3 = new Numero(-59);
                Numero n4 = new Numero(-18);
                Numero n5 = new Numero(0);
                //Numero n6 = new Numero(double.Parse("segurola que rompe!!!"));

                //cn += n1;
                cn += n2;
                cn += n3;
                cn += n4;
                cn += n5;

                Console.WriteLine(cn);

                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.Write(ex.Message);
                Console.ReadKey();
            }
            catch (OverflowException ex)
            {
                Console.Write(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Write(ex.InnerException.Message);
                Console.ReadKey();
            }
        }
    }
}

/*
 * Manejo de excepciones.
 * Excepcion -> Error en tiempo de ejecucion.
 * Capturar excepciones y tratarlas.
 * Continuar con la aplicacion.
 * try-catch
 * Exception es la clase base.
 * Exception lo tengo que dejar al final, por si no considere alguna excepcion.
 * 
 * Lanzar excepciones. throw
 * 
 */

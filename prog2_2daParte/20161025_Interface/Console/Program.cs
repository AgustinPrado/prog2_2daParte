using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20161025_Interface";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();

            Vista view = new Vista();
            view.Main();

            Console.ReadKey();
        }
    }
}

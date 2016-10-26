using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public interface IGrafica
    {
        void MostrarEnGUI(string cadena);
        bool EscribirTxt(string path, string cadena);
        bool LeerTxt(string path);
    }
}

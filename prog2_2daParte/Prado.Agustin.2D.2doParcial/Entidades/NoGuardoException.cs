using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoGuardoException : Exception
    {
        public NoGuardoException(Exception e)
            : this("Error al guardar.", e)
        {

        }

        public NoGuardoException(string message, Exception e)
            : base(message)
        {

        }

        public NoGuardoException()
            : base()
        {

        }
    }
}

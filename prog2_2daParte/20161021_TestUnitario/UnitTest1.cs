using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20161021_Clase16_TestUnitarioLibrary;

namespace _20161021_TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Persona per = new Persona("Agus", "Prado", 0, Persona.ENacionalidad.Argentino);

        }
    }
}

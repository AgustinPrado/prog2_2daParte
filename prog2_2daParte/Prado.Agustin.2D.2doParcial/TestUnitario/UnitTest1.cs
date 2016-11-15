using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Esqueleto2doParcial_20161114;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoGuardar()
        {
            Empleado emp = new Empleado("Agustin", "Prado", 111111);

            try
            {
                // Pruebo guardarlo en un directorio que no existe.
                emp.guardar("C:\\TEST\\archivo.xml", emp);

                Assert.Fail("Error al capturar al excepcion.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NoGuardoException));
            }
        }

        [TestMethod]
        public void GuardarCorrectamente()
        {
            Empleado emp = new Empleado("Agustin", "Prado", 111111);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\empleado.xml";

            try
            {
                Empleado aux;

                emp.guardar(path, emp);

                emp.leer(path, out aux);

                // No guarda correctamente en el XML.
                Assert.AreEqual(emp.Nombre, aux.Nombre);
                Assert.AreEqual(emp.Apellido, aux.Apellido);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}

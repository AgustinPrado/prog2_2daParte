using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_8_Library;

namespace WindowsForms
{
    public partial class Form1 : Form, IGrafica
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado("Agustin", "Prado", "104303", Empleado.EPuestoJerarquico.Sistemas, 14000);
            emp.Mostrar(this);
        }

        void IGrafica.MostrarEnGUI(string cadena)
        {
            richTextBoxMostrar.Text = cadena;
        }


        bool IGrafica.EscribirTxt(string path)
        {
            throw new NotImplementedException();
        }

        bool IGrafica.LeerTxt(string path)
        {
            throw new NotImplementedException();
        }
    }
}

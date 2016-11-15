using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Esqueleto2doParcial_20161114
{
    public partial class frmParcial : Form
    {
        private Empleado _emp;
        private string path;

        public frmParcial()
        {
            InitializeComponent();
            this._emp = new Empleado("Agustin", "Prado", 104303);
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\empleado.xml";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // falta hilos.
            //Thread hilo = new Thread();
            this._emp.guardar(this.path, this._emp);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // falta hilos.
            //Thread hilo = new Thread();
            Empleado aux;
            this._emp.leer(this.path, out aux);
        }
    }
}

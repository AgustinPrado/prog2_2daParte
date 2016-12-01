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

        public frmParcial()
        {
            InitializeComponent();
            this._emp = new Empleado("Agustin", "Prado", 104303);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this._emp.guardar);
            hilo.Start(this._emp);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this._emp.leer);
            hilo.Start();
            // si no le pongo pausa, no llega a leer.
            Thread.Sleep(1000);
            MessageBox.Show("Nombre: " + this._emp.EmpleadoLeido.Nombre + ". Apellido: " + this._emp.EmpleadoLeido.Apellido);
        }
    }
}

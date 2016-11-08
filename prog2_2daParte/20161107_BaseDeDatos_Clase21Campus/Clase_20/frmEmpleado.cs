﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_8_Library;
using Clase_10_Library;

namespace Clase_8
{
    public partial class frmEmpleado : Form
    {
        Empresa _empresa;

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa(this._empresa);
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._empresa = frm.Empresa;
            }
            else
            {
                this.Close();
            }
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtLegajo.Text = "";
            cmbPuesto.SelectedIndex = -1;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            this.generarEmpleadoDesdeFormulario();
            // Muestro la empresa por pantalla
            rtxtConsola.Text = this._empresa.MostrarEmpresa();
        }

        private Persona generarEmpleadoDesdeFormulario()
        {
            Empleado.EPuestoJerarquico puesto;
            int salario;
            // Controlo que los valores ingresados respeten el tipo de dato
            if (!Enum.TryParse<Empleado.EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto))
            {
                MessageBox.Show("Error en el combo de Puesto del empleado.");
                return null;
            }
            if (!Int32.TryParse(mtxtSalario.Text.Substring(1,mtxtSalario.Text.Length-1), out salario))
            {
                MessageBox.Show("Error en el salario del empleado.");
                return null;
            }
            // Compruebo si debo agregar un Empleado o un Accionista
            if (puesto == Empleado.EPuestoJerarquico.Accionista)
            {
                // Agrego el accionista a la empresa
                Accionista accionista = new Accionista(txtNombre.Text, txtApellido.Text, salario);
                this._empresa += accionista;

                return accionista;
            }
            else
            {
                // Agrego el empleado a la empresa
                Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, salario);
                this._empresa += empleado;

                return empleado;
            }
        }

        static string ARCHIVO = "empleado.xml";
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.eliminar(ARCHIVO);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)this.generarEmpleadoDesdeFormulario();
            if (!persona.Equals(null))
            {
                if (persona is Empleado)
                {
                    ((Empleado)persona).guardar(ARCHIVO);
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)this.generarEmpleadoDesdeFormulario();
            if (!persona.Equals(null))
            {
                if (persona is Empleado)
                {
                    ((Empleado)persona).modificar(ARCHIVO);
                }
            }
        }

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.leer(ARCHIVO, out empleado);

            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            mtxtLegajo.Text = empleado.Legajo.ToString();
            cmbPuesto.Text = empleado.PuestoJerarquico.ToString();
            mtxtSalario.Text = empleado.Salario.ToString();
        }
    }
}

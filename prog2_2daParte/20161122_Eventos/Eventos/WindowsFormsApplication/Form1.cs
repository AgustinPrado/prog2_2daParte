using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private static int cantGanar;
        private static int cantPerder;

        public Form1()
        {
            InitializeComponent();
            foreach (ELado item in Enum.GetValues(typeof(ELado)))
            {
                this.comboBoxLado.Items.Add(item);
            }
            this.comboBoxLado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxLado.SelectedIndex = 0;

            cantGanar = 0;
            cantPerder = 0;

            this.labelCantGanar.Text = cantGanar.ToString();
            this.labelCantPerder.Text = cantPerder.ToString();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            Moneda moneda = new Moneda();

            moneda.EventoGanar += new DelegadoMoneda(this.ManejadorGanar);
            moneda.EventoPerder += new DeleMon(this.ManejadorPerder);

            moneda.Tirar((ELado)this.comboBoxLado.SelectedItem);
        }

        public void ManejadorGanar()
        {
            MessageBox.Show("GANASTE");
            cantGanar++;
            this.labelCantGanar.Text = cantGanar.ToString();
        }

        public void ManejadorPerder(ELado lado)
        {
            MessageBox.Show("PERDISTE. Valor era: " + lado.ToString());
            cantPerder++;
            this.labelCantPerder.Text = cantPerder.ToString();
        }
    }
}

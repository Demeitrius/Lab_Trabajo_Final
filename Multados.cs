using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Trabajo_Final
{
    public partial class Multados : Form
    {
        public Multados()
        {
            InitializeComponent();
        }
        Vehiculo seleccionado = null;

        private void btVer_Click(object sender, EventArgs e)
        {
            if (lbMultados.SelectedIndex != -1)
            {
                seleccionado = Form1.vVehiculo[lbMultados.SelectedIndex];
                MessageBox.Show("Fecha registro: " + seleccionado.Fecha() + " Hora: " + seleccionado.Hora() +
                    "\nTipo de vehiculo: " + seleccionado.TipoVehiculo +
                    "\nCosto abonado: " + seleccionado.Abonado);
            }
            lbMultados.ClearSelected();
        }

        private void lbMultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMultados.SelectedIndex != -1)
                btVer.Enabled = true;
            else btVer.Enabled = false;
        }
    }
}

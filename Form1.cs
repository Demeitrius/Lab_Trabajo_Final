using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Trabajo_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Vehiculo[] vVehiculo = new Vehiculo[20];
        Vehiculo seleccionado = null;
        int cantMultas = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tBPatente.Text != "" && tBCap.Text != "")
            {
                Ticket miVentanita = new Ticket();
                Vehiculo miVehiculo;
                double costoTotal;
                double precioBase;
                double recargo = 0;
                double bonificacion = 0;
                string tipo = "";
                bool multa = false;
                if (rBtnCamion.Checked)
                {
                    tipo = rBtnCamion.Text;
                    if (NUPH.Value >= 6 && NUPH.Value <= 20)
                    {
                        bonificacion = 0.02;
                    }
                    else
                    {
                        recargo = 0.08;
                    }
                }
                if (rBtnFurgoneta.Checked)
                {
                    tipo = rBtnFurgoneta.Text;
                }
                miVehiculo = new Vehiculo(Convert.ToInt32(tBPatente.Text), tipo, Convert.ToInt32(tBCap.Text),
                    (int)NUPA.Value, (int)NUPB.Value, (int)NUPC.Value,(int)NUPDay.Value,(int)NUPMonth.Value,
                    (int)NUPYear.Value,(int)NUPH.Value,(int)NUPMin.Value);
                int diferenciaPeso = miVehiculo.Capacidad - miVehiculo.PesoTotal();


                if (diferenciaPeso >= 150)
                {
                    recargo += 0.1; //representa el 10% de recargo
                }
                else if (diferenciaPeso < 150 && diferenciaPeso >= 10)
                {
                    recargo += 0.07; //representa el 7% de recargo
                }
                else if (diferenciaPeso < 10 && diferenciaPeso >= -10)
                {
                    bonificacion += 0.05; //representa el -5% de recargo
                }
                else if (diferenciaPeso < -10 && diferenciaPeso >= -50)
                {
                    recargo += 0.18; //representa el 18% de recargo
                }
                else
                {
                    recargo += 0.5;
                    multa = true;
                }

                precioBase = 2.54 * miVehiculo.PesoTotal();
                costoTotal = precioBase + (bonificacion * precioBase) - (precioBase * recargo);

                if (rBtnNoHabil.Checked)
                {
                    costoTotal += 3500;
                }

                miVehiculo.Abonado = costoTotal;

                if (cantMultas < 20 && multa)
                {
                    vVehiculo[cantMultas] = miVehiculo;
                    cantMultas++;
                }


                miVentanita.lbTicket.Items.Add("Fecha: " + miVehiculo.Fecha() + " Hora: " + miVehiculo.Hora());
                miVentanita.lbTicket.Items.Add("Tipo vehiculo: " + miVehiculo.TipoVehiculo);
                miVentanita.lbTicket.Items.Add("Patente: " + miVehiculo.Patente.ToString());
                miVentanita.lbTicket.Items.Add("Capacidad maxima: " + miVehiculo.Capacidad.ToString());
                miVentanita.lbTicket.Items.Add("Precio base: " + precioBase + " $");
                miVentanita.lbTicket.Items.Add("Recargo: " + recargo + "%" + " $" + precioBase * recargo);
                miVentanita.lbTicket.Items.Add("Bonificacion: " + bonificacion + "%" + " $" + bonificacion * precioBase);
                miVentanita.lbTicket.Items.Add("Total abonado: " + miVehiculo.Abonado.ToString() + " $");

                miVentanita.ShowDialog();
                miVentanita.Dispose();

            }
            else 
            {
                MessageBox.Show("Formulario incompleto");
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Ordenar(vVehiculo);
            for (int i = 0; i < cantMultas; i++)
            {
                lBMultados.Items.Add("Patente: " + vVehiculo[i].Patente);
            }

        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int pos = BusqBinaria(vVehiculo, seleccionado.Patente);
            MessageBox.Show("Fecha registro: " + seleccionado.Fecha() +
                "\nTipo de vehiculo: " + seleccionado.TipoVehiculo +
                "\nCosto abonado: " + seleccionado.Abonado);
        }
        private void lBMultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBMultados.SelectedIndex > -1)
            {
                seleccionado = vVehiculo[lBMultados.SelectedIndex];
            }
        }

        public int BusqBinaria(Vehiculo[] v, int buscado)
        {
            int pos = -1;
            int left = 0;
            int right = cantMultas - 1;

            while (left <= right && pos == -1)
            {
                int mid = left + (right - left) / 2;

                if (v[mid].Patente == buscado)
                    pos = mid;
                else if (v[mid].Patente < buscado)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return pos;
        }

        public void Ordenar(Vehiculo[]v) 
        {
            Vehiculo aux;
            for (int i = 0 ; i < cantMultas - 1 ; i++) 
            {
                for (int j = 0; j < cantMultas - i - 1; j++) 
                {
                    if (v[j].Patente > v[j + 1].Patente) 
                    {
                        aux = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aux;
                    }
                }
            }
        }
        private void tBPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBCap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

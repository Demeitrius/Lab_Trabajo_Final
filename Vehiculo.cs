using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Trabajo_Final
{
    public class Vehiculo
    {
        private int patente;
        private string tipoVehiculo;
        private int cantTipoA;
        private int cantTipoB;
        private int cantTipoC;
        private int capacidad;
        private int d, m, y;
        private int h, min;
        private double abonado;

        public Vehiculo(int patente, string tipo, int capacidad, int tipoA, int tipoB, int tipoC, int day, int month, int year, int hour, int minute)
        {
            Patente = patente;
            tipoVehiculo = tipo;
            this.capacidad = capacidad;

            cantTipoA = tipoA;
            cantTipoB = tipoB;
            cantTipoC = tipoC;

            d = day;
            m = month;
            y = year;
            h = hour;
            min = minute;
        }

        public int Patente
        {
            get { return patente; }
            private set { patente = value; }
        }

        public int Capacidad
        {
            get { return capacidad; }
            private set { capacidad = value; }
        }

        public string TipoVehiculo 
        {
            get { return tipoVehiculo; }
            private set { tipoVehiculo = value; }
        }

        public double Abonado
        {
            get { return abonado; }
            set { abonado = value; }
        }
        
        public string Fecha()
        {
            string fecha = d + "/" + m + "/" + y;
            return fecha;
        }
        public string Hora()
        {
            string hora = h + ":" + min;
            return hora;
        }
        public int PesoTotal()
        {
            return cantTipoA * 5 + cantTipoB * 15 + cantTipoC * 30;
        }
    }
}
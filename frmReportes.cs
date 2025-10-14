using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHerramientas
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }
        private void btn_taxis_Click(object sender, EventArgs e)
        {
            frmTaxis taxis = new frmTaxis();
            taxis.Show();
            this.Hide();
        }
        private void btn_pagos_Click(object sender, EventArgs e)
        {
            frmPagos pagos = new frmPagos();
            pagos.Show();
            this.Hide();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
            this.Hide();
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.Show();
            this.Hide();
        }

        private void btn_conductores_Click(object sender, EventArgs e)
        {
            frmConductores conductores = new frmConductores();
            conductores.Show();
            this.Hide();
        }
    }
}

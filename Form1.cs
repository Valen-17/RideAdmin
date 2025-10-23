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
    public partial class Form1 : Form
    {
        private string nombreUsuario;
        public Form1(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            lb_usuario.Text = usuario;
        }

        private void btn_taxis_Click(object sender, EventArgs e)
        {
            frmTaxis taxis = new frmTaxis(nombreUsuario);
            taxis.Show();
            this.Hide();
        }

        private void btn_conductores_Click(object sender, EventArgs e)
        {
            frmConductores conductores = new frmConductores(nombreUsuario);
            conductores.Show();
            this.Hide();
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            frmPagos pagos = new frmPagos(nombreUsuario);
            pagos.Show();
            this.Hide();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes(nombreUsuario);
            reportes.Show();
            this.Hide();
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion(nombreUsuario);
            configuracion.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Ingreso inicio = new Ingreso();
            inicio.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

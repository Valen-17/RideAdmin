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
    public partial class frmTaxis : Form
    {
        public frmTaxis()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(); 
            inicio.Show();
            this.Hide();
        }

        private void btn_conductores_Click(object sender, EventArgs e)
        {
            frmConductores conductores = new frmConductores();
            conductores.Show();
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            panel_agregar.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CentrarPanel(panel_agregar);
            panel_agregar.Visible = true;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llene solo los datos que desee actualizar", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CentrarPanel(panel_agregar);
            panel_agregar.Visible = true;
        }

        private void CentrarPanel(Panel panel)
        {
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;
            panel.Location = new Point(x, y);
        }

    }
}

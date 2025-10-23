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
    public partial class frmConfiguracion : Form
    {

        private string nombreUsuario;
        public frmConfiguracion(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            panel_usuario.Visible = false;
        }

        private void btn_cerrarCon_Click(object sender, EventArgs e)
        {
            panel_contraseña.Visible = false;
        }


        private void btn_cambiarUsu_Click(object sender, EventArgs e)
        {
            CentrarPanel(panel_usuario);
            panel_usuario.Visible = true;
        }

        private void btn_cambiarCon_Click(object sender, EventArgs e)
        {
            CentrarPanel(panel_contraseña);
            panel_contraseña.Visible = true;
        }

        private void CentrarPanel(Panel panel)
        {
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;
            panel.Location = new Point(x, y);
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1(nombreUsuario);
            inicio.Show();
            this.Hide();
        }
        private void btn_taxis_Click(object sender, EventArgs e)
        {
            frmTaxis taxis = new frmTaxis(nombreUsuario);
            taxis.Show();
            this.Hide();
        }
        private void btn_conductores_Click(object sender, EventArgs e)
        {
            frmConductores conductores = new frmConductores (nombreUsuario);
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

        
    }
}

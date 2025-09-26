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
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
        private void btn_conductores_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.Show();
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

        
    }
}

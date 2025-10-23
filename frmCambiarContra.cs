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
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();
        }

        private void btn_cerrarCon_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            this.Close();
            ingreso.Show();
        }
        // Botones mostrar y ocultar codigo

        private void rdb_ver_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ver.Checked)
            {
                txt_codigo.PasswordChar = '\0'; // Muestra texto
                rdb_ocultar.Visible = true;
                rdb_ver.Visible = false;
                rdb_ocultar.Checked = false;
            }
        }

        private void rdb_ocultar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ocultar.Checked)
            {
                txt_codigo.PasswordChar = '*'; // Oculta texto
                rdb_ocultar.Visible = false;
                rdb_ver.Visible = true;
                rdb_ver.Checked = false;
            }
        }

    }
}

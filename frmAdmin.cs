using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHerramientas
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            CargarDatos();
            txtUsuario.Text = "Ingrese el usuario";
            txtCorreo.Text = "Ingrese el correo";
            txtContraseña.Text = "Ingrese la contraseña";
            txtUsuario.ForeColor = Color.Gray;
            txtCorreo.ForeColor = Color.Gray;
            txtContraseña.ForeColor = Color.Gray;
        }

        //Textbox con mensaje
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese el usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese el usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Ingrese el correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Ingrese el correo";
                txtCorreo.ForeColor = Color.Gray;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese la contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.PasswordChar = '*';
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "Ingrese la contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                if (!rdbVer.Checked)
                {
                    txtContraseña.PasswordChar = '*';
                }
                else
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
        }

        //Ver y ocultar contraseña
        private void rdbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVer.Checked)
            {
                txtContraseña.PasswordChar = '\0';
                rdbVer.Visible = false;
                rdbOcultar.Visible = true;
                rdbOcultar.Checked = false;
            }
        }
        private void rdbOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOcultar.Checked)
            {
                rdbOcultar.Visible = false;
                rdbVer.Visible = true;
                rdbVer.Checked = false;

                if (txtContraseña.Text != "Ingrese la contraseña")
                {
                    txtContraseña.PasswordChar = '*';
                }
                else
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
        }
        private void rdb_verE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_verE.Checked)
            {
                txt_contraseña.PasswordChar = '\0';
                rdb_verE.Visible = false;
                rdb_ocultarE.Visible = true;
                rdb_ocultarE.Checked = false;
            }
        }

        private void rdb_ocultarE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ocultarE.Checked)
            {
                rdb_ocultarE.Visible = false;
                rdb_verE.Visible = true;
                rdb_verE.Checked = false;
                txt_contraseña.PasswordChar = '*';
            }
        }
        //Botones de volver y de salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picturebox_salir_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.Show();
            this.Close();

        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            panel_cambios.Visible = false;
        }
        private void btn_cerrarE_Click(object sender, EventArgs e)
        {
            panel_editar.Visible = false;
        }

        //Cargar datos en datagridview
        private void CargarDatos()
        {
            dgvUsuarios.DataSource = UsuarioConexion.MostrarUsuarios();
            // Copiar la lista de usuarios en una variable para contar cuántos usuarios hay
            DataTable dt = (DataTable)dgvUsuarios.DataSource;

            // Mostrar total de usuarios
            lbl_totalusu.Text = $"Total usuarios: {dt.Rows.Count}";
        }

        //Centrar panel
        private void CentrarPanel(Panel panel)
        {
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;
            panel.Location = new Point(x, y);
        }

        //Uso de botones en admin
        //Agregar usuario
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            panel_cambios.Visible = true;
            CentrarPanel(panel_cambios);
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToLower().Trim();
            string correo = txtCorreo.Text.ToLower().Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection con = ConexionBD.Conectar())
                {
                    // Verificar si el usuario o correo ya existen
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @usuario OR Correo = @correo", con);
                    checkCmd.Parameters.AddWithValue("@usuario", usuario);
                    checkCmd.Parameters.AddWithValue("@correo", correo);

                    //ExecuteScalar() consulta que devuelve un solo valor 
                    //checkCmd tipo de objeto SqlCommand, representa instrucción SQL
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El usuario o correo ya existen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Usuario usu = new Usuario(usuario, correo, contrasena);

                    // Llamar al método que inserta en la base de datos
                    bool agregar = UsuarioConexion.RegistrarUsuario(usu);

                    if (agregar)
                    {
                        MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        CargarDatos();
                        // Limpiar campos
                        txtUsuario.Clear();
                        txtCorreo.Clear();
                        txtContraseña.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Editar usuario
        private void btn_editar_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llenar los TextBox con los datos de la fila seleccionada
            txt_usuario.Text = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
            txt_correo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            txt_contraseña.Text = dgvUsuarios.CurrentRow.Cells["Contrasena"].Value.ToString();

            panel_editar.Visible = true;
            CentrarPanel(panel_editar);
        }
        private void btn_guardarEdit_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string correo = txt_correo.Text.Trim();
            string contrasena = txt_contraseña.Text.Trim();
            int id;
            int resultado = 0;

            //Verificar fila seleccionada
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("No hay un usuario seleccionado para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel_editar.Visible = false; // Oculta el panel si no hay selección válida
                return;
            }

            // Verificar que no hayan campos vacios
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos de edición.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID de la fila seleccionada de forma segura
            id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);

            // Crear un objeto Usuario con los datos de los TextBox
            Usuario usu = new Usuario(usuario, correo, contrasena);

            resultado = UsuarioConexion.EditarUsuario(usu, id);

            if (resultado > 0)
            {
                MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel_editar.Visible = false;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo editar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Eliminar usuario
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                // Toma el ID de la persona seleccionada 
                int idPersona = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);

                int resp = UsuarioConexion.Eliminar(idPersona);

                if (resp > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        
    }
}

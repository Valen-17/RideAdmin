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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            CentrarPanel(panel_ingresar);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            txtUsuario.Text = "Ingrese su usuario";
            txtCorreo.Text = "Ingrese su correo";
            txtContraseña.Text = "Ingrese su contraseña";
            txtConfirmar.Text = "Confirme su contraseña";
            txt_usuario.Text = "Ingrese su usuario";
            txt_contraseña.Text = "Ingrese su contraseña";
            txtUsuario.ForeColor = Color.Gray;
            txtCorreo.ForeColor = Color.Gray;
            txtContraseña.ForeColor = Color.Gray;
            txtConfirmar.ForeColor = Color.Gray;
            txt_usuario.ForeColor = Color.Gray;
            txt_contraseña.ForeColor= Color.Gray;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Textbox con texto ingresado
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Ingrese su correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Ingrese su correo";
                txtCorreo.ForeColor = Color.Gray;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese su contraseña")
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
                txtContraseña.Text = "Ingrese su contraseña";
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
        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Confirme su contraseña")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.Black;
                txtConfirmar.PasswordChar = '*';
            }
        }
        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmar.Text))
            {
                txtConfirmar.Text = "Confirme su contraseña";
                txtConfirmar.ForeColor = Color.Gray;
                txtConfirmar.PasswordChar = '\0';
            }
            else
            {
                if (!rdbVer.Checked)
                {
                    txtConfirmar.PasswordChar = '*';
                }
                else
                {
                    txtConfirmar.PasswordChar = '\0';
                }
            }
        }
        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Ingrese su usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.Black;
            }
        }
        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Ingrese su usuario";
                txt_usuario.ForeColor = Color.Gray;
            }
        }
        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "Ingrese su contraseña")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.Black;
                if (!rdb_ver.Checked)
                {
                    txt_contraseña.PasswordChar = '*';
                }
                else
                {
                    txt_contraseña.PasswordChar = '\0';
                }
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                txt_contraseña.PasswordChar = '\0';
                txt_contraseña.Text = "Ingrese su contraseña";
                txt_contraseña.ForeColor = Color.Gray;
            }
        }

        //Ver y ocultar contraseña
        private void rdb_ver_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ver.Checked)
            {
                txt_contraseña.PasswordChar = '\0';

                rdb_ver.Visible = false;
                rdb_ocultar.Visible = true;
                rdb_ocultar.Checked = false;
            }
        }
        private void rdb_ocultar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ocultar.Checked)
            {
                rdb_ocultar.Visible = false;
                rdb_ver.Visible = true;
                rdb_ver.Checked = false;

                if (txt_contraseña.Text != "Ingrese su contraseña")
                {
                    txt_contraseña.PasswordChar = '*';
                }
                else
                {
                    txt_contraseña.PasswordChar = '\0';
                }
            }
        }
        private void rdbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVer.Checked)
            {
                txtContraseña.PasswordChar = '\0';
                txtConfirmar.PasswordChar = '\0';
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

                if (txtContraseña.Text != "Ingrese su contraseña")
                {
                    txtContraseña.PasswordChar = '*';
                    txtConfirmar.PasswordChar = '*';
                }
                else
                {
                    txtContraseña.PasswordChar = '\0';
                    txtConfirmar.PasswordChar = '\0';
                }
            }
        }

        //Movimiento entre paneles
        private void lbl_registrar_Click(object sender, EventArgs e)
        {
            panel_ingresar.Visible = false;
            panel_registrar.Visible = true;
            CentrarPanel(panel_registrar);

            //Reestablecer placeholder
            if (txt_usuario.Text != "Ingrese su usuario")
            {
                txt_usuario.Text = "Ingrese su usuario";
                txt_usuario.ForeColor = Color.Gray;
            }

            if (txt_contraseña.Text != "Ingrese su contraseña")
            {
                txt_contraseña.Text = "Ingrese su contraseña";
                txt_contraseña.ForeColor = Color.Gray;
                txt_contraseña.PasswordChar = '\0'; 
            }
        }

        private void CentrarPanel(Panel panel)
        {
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;
            panel.Location = new Point(x, y);
        }

        private void lbl_ingresar_Click(object sender, EventArgs e)
        {
            panel_registrar.Visible = false;
            panel_ingresar.Visible = true;
            CentrarPanel(panel_ingresar);
            //Reestablecer placeholder
            if (txtUsuario.Text != "Ingrese su usuario")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.Gray;
            }

            if (txtCorreo.Text != "Ingrese su correo")
            {
                txtCorreo.Text = "Ingrese su correo";
                txtCorreo.ForeColor = Color.Gray;
            }

            if (txtContraseña.Text != "Ingrese su contraseña")
            {
                txtContraseña.Text = "Ingrese su contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.PasswordChar = '\0';
            }

            if (txtConfirmar.Text != "Confirme su contraseña")
            {
                txtConfirmar.Text = "Confirme su contraseña";
                txtConfirmar.ForeColor = Color.Gray;
                txtConfirmar.PasswordChar = '\0';
            }
        }

        //Registrarse
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToLower().Trim();
            string correo = txtCorreo.Text.ToLower().Trim();
            string contrasena = txtContraseña.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contrasena != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    bool registrado = UsuarioConexion.RegistrarUsuario(usu);

                    if (registrado)
                    {
                        MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar campos
                        txtUsuario.Clear();
                        txtCorreo.Clear();
                        txtContraseña.Clear();
                        txtConfirmar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Iniciar sesión
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.ToLower().Trim();
            string contrasena = txt_contraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (usuario == "admin" && contrasena == "admin1234")
            {
                MessageBox.Show("Bienvenido Admin ha iniciado sesión correctamente", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAdmin adminForm = new frmAdmin();
                adminForm.Show();
                this.Hide();
            }
            else
            {

                try
                {
                    using (SqlConnection con = ConexionBD.Conectar())
                    {
                        //Verificar el usuario y contraseña en la base de datos
                        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @usuario AND Contrasena = @contrasena", con);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show($"Bienvenido {usuario} ha iniciado sesión exitosamente ", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 Homepage = new Form1(usuario);
                            Homepage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Boton cambiar contraseña
        private void lbl_CambiarContra_Click(object sender, EventArgs e)
        {
            frmCambiarContra contra = new frmCambiarContra();
            contra.Show();
            this.Hide();
        }
    }
}

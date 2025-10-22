using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHerramientas
{
    internal class UsuarioConexion
    {
        public static bool RegistrarUsuario(Usuario u)
        {
            try
            {
                using (SqlConnection con = ConexionBD.Conectar())
                {
                    // Insertar usuario nuevo
                    SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (NombreUsuario, Correo, Contrasena) VALUES (@usuario, @correo, @contrasena)", con);
                    cmd.Parameters.AddWithValue("@usuario", u.NombreUsuario);
                    cmd.Parameters.AddWithValue("@correo", u.Correo);
                    cmd.Parameters.AddWithValue("@contrasena", u.Contrasena);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}

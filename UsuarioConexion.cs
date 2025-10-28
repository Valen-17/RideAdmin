using System;
using System.Collections.Generic;
using System.Data;
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
        public static DataTable MostrarUsuarios()
        {
            using (SqlConnection cone = ConexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuario", cone);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static int EditarUsuario(Usuario u, int id)
        {
            int resultado = 0;

            using (SqlConnection con = ConexionBD.Conectar())
            {
                //Actualizar usuario
                SqlCommand cmd = new SqlCommand( "UPDATE Usuario SET NombreUsuario = @usuario, Correo = @correo, Contrasena = @contrasena WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@usuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@correo", u.Correo);
                cmd.Parameters.AddWithValue("@contrasena", u.Contrasena);
                cmd.Parameters.AddWithValue("@id", id);

                resultado = cmd.ExecuteNonQuery();
            }

            return resultado;
        }

        public static int Eliminar(int idPersona)
        {
            int resultado = 0;

            using (SqlConnection cone = ConexionBD.Conectar())
            {
                SqlCommand comando = new SqlCommand("DELETE FROM Usuario WHERE Id = @Id", cone);
                comando.Parameters.AddWithValue("@Id", idPersona);

                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }

    }
}

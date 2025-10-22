using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerramientas
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string nombreUsuario, string correo, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Correo = correo;
            Contrasena = contrasena;
        }
    }
}
